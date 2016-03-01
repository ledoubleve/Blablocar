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
    /// Logique d'interaction pour fenetrePrincipal.xaml
    /// </summary>
    public partial class fenetrePrincipal : Window
    {
        Bdd bdd = new Bdd();

        public fenetrePrincipal()
        {
            InitializeComponent();
            bdd.recupVilleInList();
            bdd.recupPersonneInList();
            bdd.recupVoitureInList();
            this.VilleArrivee.DataContext = Ville.ville;
            this.VilleDepart.DataContext = Ville.ville;
            
        }

        private void rechercheTrajet_Click(object sender, RoutedEventArgs e)
        {

            // recuperation des villes de depart et d'arrivée
            Ville ville_depart = (Ville)this.VilleDepart.SelectedItem;
            Ville ville_arrivee = (Ville)this.VilleArrivee.SelectedItem;

            bdd.recupTrajetInList(ville_depart, ville_arrivee);
            this.listeTrajet.DataContext = Trajet.trajet;
                
        }

        private void listeTrajet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Trajet detail_trajet = (Trajet)this.listeTrajet.SelectedItem;
            this.villeDep.Text = detail_trajet.villeDepart.nom_Ville;
        }
    }
}
