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
    public class Ville
    {
        public int id_Ville { get; set; }
        public string nom_Ville { get; set; }

        // Définition des attributs static

        public static List<Ville> ville = new List<Ville>();

        public Ville(int id, string nom)
        {
            this.id_Ville = id;
            this.nom_Ville = nom;
            Ville.ville.Add(this);
        }

    }
}