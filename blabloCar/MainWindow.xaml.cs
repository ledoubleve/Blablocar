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

namespace blabloCar
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        Bdd bdd = new Bdd();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void connexion_Click(object sender, RoutedEventArgs e)
        { 


            if (bdd.VerifLogin(email.Text, mdp.Password))
            {
                
                fenetrePrincipal fenetreprincipale = new fenetrePrincipal();
                fenetreprincipale.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur login et mot de passe !");
            }
        }

        private void inscription_Click(object sender, RoutedEventArgs e)
        {
            Window1 inscription = new Window1();
            inscription.Show();
        }
    }
}
