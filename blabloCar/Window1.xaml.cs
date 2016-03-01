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

namespace blabloCar
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Bdd bdd = new Bdd();

        public Window1()
        {
            InitializeComponent();
        }

        private void bouton_inscrire_Click(object sender, RoutedEventArgs e)
        {
            if ((this.passwdPersonne.Password == this.secondPasswdPersonne.Password) && nomPersonne.Text != "" && prenomPersonne.Text != "" && mailPersonne.Text != "" && telPersonne.Text != "")
            {
                Personne personne = new Personne(nomPersonne.Text, prenomPersonne.Text, mailPersonne.Text, telPersonne.Text, passwdPersonne.Password);
                bdd.AjouterLogin(personne);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur dans le formulaire");
            }
        }
    }
}
