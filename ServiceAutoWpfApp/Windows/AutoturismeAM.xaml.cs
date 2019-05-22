using ServiceAutoClassLibrary;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for AutoturismeAM.xaml
    /// </summary>
    public partial class AutoturismeAM : Window
    {
        private SRClient.SAClientClient uowClient;
        private SRSasiu.SASasiuClient uowSasiu;
        private SRAuto.SAAutoClient uowAuto;

        public AutoturismeAM(SRClient.SAClientClient uowClientReceived, SRSasiu.SASasiuClient uowSasiuReceived, SRAuto.SAAutoClient uowAutoReceived)
        {
            InitializeComponent();
            uowClient = uowClientReceived;
            uowSasiu = uowSasiuReceived;
            uowAuto = uowAutoReceived;
        }

        public AutoturismeAM(SRClient.SAClientClient uowClientReceived, SRSasiu.SASasiuClient uowSasiuReceived, SRAuto.SAAutoClient uowAutoReceived, string text) : this(uowClientReceived, uowSasiuReceived, uowAutoReceived)
        {
            this.Title = text;
            btnAddMod.Content = text;
            cmbClientId.ItemsSource = uowClient.GetAll().Select(c => c.ClientId.ToString()).ToArray();
            cmbSasiuId.ItemsSource = uowSasiu.GetAll().Select(s => s.SasiuId.ToString()).ToArray();
        }

        public AutoturismeAM(SRClient.SAClientClient uowClientReceived, SRSasiu.SASasiuClient uowSasiuReceived, SRAuto.SAAutoClient uowAutoReceived, string text, Auto row) : this(uowClientReceived, uowSasiuReceived, uowAutoReceived, text)
        {
            txtId.Text = row.AutoId.ToString();
            txtNrAuto.Text = row.NumarAuto.ToString();
            cmbSasiuId.SelectedIndex = cmbSasiuId.Items.IndexOf(row.SasiuId.ToString());
            txtSerieSasiu.Text = row.SerieSasiu.ToString();
            cmbClientId.SelectedIndex = cmbClientId.Items.IndexOf(row.ClientId.ToString());
        }

        private void BtnAddMod_Click(object sender, RoutedEventArgs e)
        {
            if (txtId.Text == "")
            {
                var auto = new Auto() { NumarAuto = txtNrAuto.Text, SasiuId = Convert.ToInt32(cmbSasiuId.Text), SerieSasiu = txtSerieSasiu.Text, ClientId = Convert.ToInt32(cmbClientId.Text)};
                uowAuto.Add(auto);
            }
            else
            {
                var auto = new Auto() { AutoId = Convert.ToInt32(txtId.Text), NumarAuto = txtNrAuto.Text, SasiuId = Convert.ToInt32(cmbSasiuId.Text), SerieSasiu = txtSerieSasiu.Text, ClientId = Convert.ToInt32(cmbClientId.Text) };
                uowAuto.Modify(auto);
            }
            DialogResult = true;
            this.Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
