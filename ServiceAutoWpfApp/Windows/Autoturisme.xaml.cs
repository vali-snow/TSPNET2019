using ServiceAutoClassLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ServiceAutoWpfApp
{
    /// <summary>
    /// Interaction logic for Autoturisme.xaml
    /// </summary>
    public partial class Autoturisme : Window
    {
        internal Dictionary<string, string> onCloseParameters = new Dictionary<string, string>();
        private SRClient.SAClientClient uowClient = new SRClient.SAClientClient();
        private SRSasiu.SASasiuClient uowSasiu = new SRSasiu.SASasiuClient();
        private SRAuto.SAAutoClient uowAuto = new SRAuto.SAAutoClient();


        public Autoturisme()
        {
            InitializeComponent();
            cmbClientId.ItemsSource = uowClient.GetAll().Select(c => c.ClientId.ToString()).ToArray();
            cmbSasiuId.ItemsSource = uowSasiu.GetAll().Select(s => s.SasiuId.ToString()).ToArray();
        }

        public Autoturisme(Dictionary<string, string> parameters) : this()
        {
            if (parameters.ContainsKey("clientId"))
            {
                cmbClientId.SelectedIndex = cmbClientId.Items.IndexOf(parameters["clientId"]);
            }
            if (parameters.ContainsKey("sasiuId"))
            {
                cmbSasiuId.SelectedIndex = cmbSasiuId.Items.IndexOf(parameters["sasiuId"]);
            }
        }

        private void RefreshGrid()
        {
            var allAuto = uowAuto.GetAll();
            if (cmbClientId.Text != "" && cmbSasiuId.Text != "")
            {
                var clientId = Convert.ToInt32(cmbClientId.Text);
                var sasiuId = Convert.ToInt32(cmbSasiuId.Text);
                gwAutoturisme.ItemsSource = allAuto.Where(a => a.ClientId == clientId && a.SasiuId == sasiuId).ToList();
            }
            else if (cmbClientId.Text != "")
            {
                var clientId = Convert.ToInt32(cmbClientId.Text);
                gwAutoturisme.ItemsSource = allAuto.Where(a => a.ClientId == clientId).ToList();
            }
            else if (cmbSasiuId.Text != "")
            {
                var sasiuId = Convert.ToInt32(cmbSasiuId.Text);
                gwAutoturisme.ItemsSource = allAuto.Where(a => a.SasiuId == sasiuId).ToList();
            }
            else
            {
                gwAutoturisme.ItemsSource = allAuto;
            }

            gwAutoturisme.SelectedIndex = -1;
            btnLinkComenzi.IsEnabled = false;
            btnModifySelected.IsEnabled = false;
            btnRemoveSelected.IsEnabled = false;
            btnRefresh.IsEnabled = true;
            btnAddNew.IsEnabled = true;
            btnExit.IsEnabled = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshGrid();
        }

        private void GwAutoturisme_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "AutoId":
                    e.Column.Header = "Id";
                    break;
                case "Client":
                case "Comenzi":
                case "Sasiu":
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void GwAutoturisme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (gwAutoturisme.SelectedItems.Count)
            {
                case 0:
                    btnLinkComenzi.IsEnabled = false;
                    btnModifySelected.IsEnabled = false;
                    btnRemoveSelected.IsEnabled = false;
                    btnRefresh.IsEnabled = true;
                    btnAddNew.IsEnabled = true;
                    btnExit.IsEnabled = true;
                    break;
                case 1:
                    btnLinkComenzi.IsEnabled = true;
                    btnModifySelected.IsEnabled = true;
                    btnRemoveSelected.IsEnabled = true;
                    btnRefresh.IsEnabled = true;
                    btnAddNew.IsEnabled = true;
                    btnExit.IsEnabled = true;
                    break;
                default:
                    btnLinkComenzi.IsEnabled = false;
                    btnModifySelected.IsEnabled = false;
                    btnRemoveSelected.IsEnabled = true;
                    btnRefresh.IsEnabled = true;
                    btnAddNew.IsEnabled = true;
                    btnExit.IsEnabled = true;
                    break;
            }
        }

        private void CmbClientId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count != 0)
            {
                cmbClientId.Text = e.AddedItems[0].ToString();
                RefreshGrid();
            }
        }

        private void CmbSasiuId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count != 0)
            {
                cmbSasiuId.Text = e.AddedItems[0].ToString();
                RefreshGrid();
            }
        }

        private void BtnClearFilters_Click(object sender, RoutedEventArgs e)
        {
            cmbClientId.SelectedIndex = -1;
            cmbSasiuId.SelectedIndex = -1;
            RefreshGrid();
        }

        private void BtnLinkComenzi_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            onCloseParameters.Add("toOpen", "Comenzi");
            onCloseParameters.Add("autoId", (gwAutoturisme.SelectedItem as Auto).AutoId.ToString());
            this.Close();
        }

        private void BtnModifySelected_Click(object sender, RoutedEventArgs e)
        {
            var toOpen = new AutoturismeAM(uowClient, uowSasiu, uowAuto, "Modify Auto", gwAutoturisme.SelectedItem as Auto);
            toOpen.ShowDialog();
            if (toOpen.DialogResult.HasValue && toOpen.DialogResult.Value)
            {
                RefreshGrid();
            }
        }

        private void BtnRemoveSelected_Click(object sender, RoutedEventArgs e)
        {
            var autoToDelete = new ObservableCollection<Auto>();
            foreach (var selectedRow in gwAutoturisme.SelectedItems)
            {
                autoToDelete.Add(uowAuto.GetById(Convert.ToInt32((selectedRow as Auto).AutoId)));
            }
            uowAuto.RemoveRange(autoToDelete);
            RefreshGrid();
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            RefreshGrid();
        }

        private void BtnAddNew_Click(object sender, RoutedEventArgs e)
        {
            var toOpen = new AutoturismeAM(uowClient, uowSasiu, uowAuto, "Add Auto");
            toOpen.ShowDialog();
            if (toOpen.DialogResult.HasValue && toOpen.DialogResult.Value)
            {
                RefreshGrid();
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
