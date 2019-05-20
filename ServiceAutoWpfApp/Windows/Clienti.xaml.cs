using ServiceAutoClassLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
    /// Interaction logic for Clienti.xaml
    /// </summary>
    public partial class Clienti : Window
    {
        private SRClient.SAClientClient uowClient = new SRClient.SAClientClient();

        public Clienti()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            gwClienti.ItemsSource = uowClient.GetAll();
            gwClienti.SelectedIndex = -1;
            btnLinkAutoturisme.IsEnabled = false;
            btnLinkComenzi.IsEnabled = false;
            btnModifySelected.IsEnabled = false;
            btnRemoveSelected.IsEnabled = false;
            btnRefresh.IsEnabled = true;
            btnAddNew.IsEnabled = true;
            btnExit.IsEnabled = true;
        }

        private void GwClienti_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "ClientId":
                    e.Column.Header = "Id";
                    break;
                case "Autoturisme":
                case "Comenzi":
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void GwClienti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (gwClienti.SelectedItems.Count)
            {
                case 0:
                    btnLinkAutoturisme.IsEnabled = false;
                    btnLinkComenzi.IsEnabled = false;
                    btnModifySelected.IsEnabled = false;
                    btnRemoveSelected.IsEnabled = false;
                    btnRefresh.IsEnabled = true;
                    btnAddNew.IsEnabled = true;
                    btnExit.IsEnabled = true;
                    break;
                case 1:
                    btnLinkAutoturisme.IsEnabled = true;
                    btnLinkComenzi.IsEnabled = true;
                    btnModifySelected.IsEnabled = true;
                    btnRemoveSelected.IsEnabled = true;
                    btnRefresh.IsEnabled = true;
                    btnAddNew.IsEnabled = true;
                    btnExit.IsEnabled = true;
                    break;
                default:
                    btnLinkAutoturisme.IsEnabled = false;
                    btnLinkComenzi.IsEnabled = false;
                    btnModifySelected.IsEnabled = false;
                    btnRemoveSelected.IsEnabled = true;
                    btnRefresh.IsEnabled = true;
                    btnAddNew.IsEnabled = true;
                    btnExit.IsEnabled = true;
                    break;
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnRemoveSelected_Click(object sender, RoutedEventArgs e)
        {
            var clientsToDelete = new ObservableCollection<Client>();
            foreach (var selectedRow in gwClienti.SelectedItems)
            {
                clientsToDelete.Add(uowClient.GetById(Convert.ToInt32((selectedRow as Client).ClientId)));
            }
            uowClient.RemoveRange(clientsToDelete);
            RefreshGrid();
        }

        private void BtnAddNew_Click(object sender, RoutedEventArgs e)
        {
            var toOpen = new ClientiAM(uowClient, "Add Client");
            toOpen.ShowDialog();
            if (toOpen.DialogResult.HasValue && toOpen.DialogResult.Value) {
                RefreshGrid();
            }
        }

        private void BtnModifySelected_Click(object sender, RoutedEventArgs e)
        {
            var toOpen = new ClientiAM(uowClient, "Modify Client", gwClienti.SelectedItem as Client);
            toOpen.ShowDialog();
            if (toOpen.DialogResult.HasValue && toOpen.DialogResult.Value)
            {
                RefreshGrid();
            }
        }
    }
}
