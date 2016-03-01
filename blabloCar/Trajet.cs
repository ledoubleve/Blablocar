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
    public class Trajet
    {
        public int id { get; set; }
        public int placesDispo { get; set; }
        public string heureDepart { get; set; }

        // Définition des attributs static
        public static List<Trajet> trajet = new List<Trajet>();

        //Définition des attributs externes

        public Voiture voiture { get; set; }
        public Ville villeDepart { get; set; }
        public Ville villeArrivee { get; set; }


        public Trajet(int id, int placesDispo, string heureDepart, Ville villeDepart, Ville villeArrivee, Voiture voiture)
        {
            this.id = id;
            this.placesDispo = placesDispo;
            this.heureDepart = heureDepart;
            this.villeDepart = villeDepart;
            this.villeArrivee = villeArrivee;
            this.voiture = voiture;
        }

        public Trajet(int placesDispo, string heureDepart, Ville villeDepart, Ville villeArrivee, Voiture voiture)
        {
            this.placesDispo = placesDispo;
            this.heureDepart = heureDepart;
            this.villeDepart = villeDepart;
            this.villeArrivee = villeArrivee;
            this.voiture = voiture;

            // Appel de la methode d ajout de Trajet dans la BDD
            Trajet.trajet.Add(this);

        }
    }
}