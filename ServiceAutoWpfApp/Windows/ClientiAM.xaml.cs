using ServiceAutoClassLibrary;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for ClientiAM.xaml
    /// </summary>
    public partial class ClientiAM : Window
    {
        private SRClient.SAClientClient uowClient;

        public ClientiAM(SRClient.SAClientClient uowClientReceived)
        {
            InitializeComponent();
            uowClient = uowClientReceived;
        }

        public ClientiAM(SRClient.SAClientClient uowClientReceived, string text) : this(uowClientReceived)
        {
            this.Title = text;
            btnAddMod.Content = text;
            cmbJudet.ItemsSource = new[] { "Alba", "Arad", "Arges", "Bacau", "Bihor", "Bistrita Nasaud", "Botosani", "Braila", "Brasov", "Bucuresti", "Buzau", "Calarasi", "Caras Severin", "Cluj", "Constanta", "Covasna", "Dambovita", "Dolj", "Galati", "Giurgiu", "Gorj", "Harghita", "Hunedoara", "Ialomita", "Iasi", "Ilfov", "Maramures", "Mehedinti", "Mures", "Neamt", "Olt", "Prahova", "Salaj", "Satu Mare", "Sibiu", "Suceava", "Teleorman", "Timis", "Tulcea", "Valcea", "Vaslui", "Vrancea" };
        }

        public ClientiAM(SRClient.SAClientClient uowClientReceived, string text, Client row): this(uowClientReceived, text)
        {
            txtId.Text = row.ClientId.ToString();
            txtNume.Text = row.Nume;
            txtPrenume.Text = row.Prenume;
            txtAdresa.Text = row.Adresa;
            txtLocalitate.Text = row.Localitate;
            cmbJudet.Text = row.Judet;
            txtTelefon.Text = row.Telefon;
            txtEmail.Text = row.Email;
        }

        private void BtnAddNew_Click(object sender, RoutedEventArgs e)
        {
            if (txtId.Text == "")
            {
                var client = new Client() { Nume = txtNume.Text, Prenume = txtPrenume.Text, Adresa = txtAdresa.Text, Localitate = txtLocalitate.Text, Judet = cmbJudet.Text, Telefon = txtTelefon.Text, Email = txtEmail.Text };
                uowClient.Add(client);
            }
            else
            {
                var client = new Client() { ClientId = Convert.ToInt32(txtId.Text), Nume = txtNume.Text, Prenume = txtPrenume.Text, Adresa = txtAdresa.Text, Localitate = txtLocalitate.Text, Judet = cmbJudet.Text, Telefon = txtTelefon.Text, Email = txtEmail.Text };
                uowClient.Modify(client);
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
