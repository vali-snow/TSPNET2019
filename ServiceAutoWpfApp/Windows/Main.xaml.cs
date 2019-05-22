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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ServiceAutoWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnClienti_Click(object sender, RoutedEventArgs e)
        {
            var toOpen = new Clienti();
            toOpen.ShowDialog();
            if (toOpen.DialogResult.HasValue && toOpen.DialogResult.Value)
            {
                Router(toOpen.onCloseParameters);
            }
        }

        private void BtnAutoturisme_Click(object sender, RoutedEventArgs e)
        {
            var toOpen = new Autoturisme();
            toOpen.ShowDialog();
            if (toOpen.DialogResult.HasValue && toOpen.DialogResult.Value)
            {
                Router(toOpen.onCloseParameters);
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Router(Dictionary<string, string> parameters) {
            switch (parameters["toOpen"])
            {
                case "Autoturisme":
                    var openAuto = new Autoturisme(parameters);
                    openAuto.ShowDialog();
                    if (openAuto.DialogResult.HasValue && openAuto.DialogResult.Value)
                    {
                        Router(openAuto.onCloseParameters);
                    }
                    break;
                case "Clienti":
                    var openClienti = new Clienti();
                    openClienti.ShowDialog();
                    if (openClienti.DialogResult.HasValue && openClienti.DialogResult.Value)
                    {
                        Router(openClienti.onCloseParameters);
                    }
                    break;
                default:
                    break;
            }
        }        
    }
}
