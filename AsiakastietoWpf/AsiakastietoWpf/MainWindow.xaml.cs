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

namespace AsiakastietoWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnTervehdys_Click(object sender, RoutedEventArgs e)
        {
            if (txtNimi.Text == "" || txtKotiOsoite.Text == "")
            {
                MessageBox.Show("Anna molemmat tiedot", "Otsikko", MessageBoxButton.OKCancel);
            }
            else
            {
                MessageBoxResult tulos = MessageBox.Show("Asiakas: " + txtNimi.Text + 
                    ", Osoite: " + txtKotiOsoite.Text, "Asiakastietojen tallennus", MessageBoxButton.YesNoCancel);
                switch (tulos)
                {
                    case MessageBoxResult.Yes:
                        txtNimi.Background = Brushes.Green;
                        txtKotiOsoite.Background = Brushes.Green;
                        break;
                    case MessageBoxResult.No:
                        txtNimi.Background = Brushes.White;
                        txtKotiOsoite.Background = Brushes.White;
                        txtNimi.Text = "";
                        txtKotiOsoite.Text = "";
                        break;
                    case MessageBoxResult.Cancel:
                        txtNimi.Background = Brushes.White;
                        txtKotiOsoite.Background = Brushes.White;
                        break;
                }
            }
        }
    }
}
