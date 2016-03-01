using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blabloCar
{
    public class Voiture
    {
        public int id_voiture { get; set; }
        public string marque_voiture { get; set; }
        public string modele_voiture { get; set; }

        // definition des attributs externe
        Personne proprietaire { get; set; }

        // liste des voiture dans l'application
        static public List<Voiture> voiture = new List<Voiture>();

        public Voiture(int id_voiture, string marque, string modele, Personne proprietaire)
        {
            this.id_voiture = id_voiture;
            this.marque_voiture = marque;
            this.modele_voiture = modele;
            this.proprietaire = proprietaire;

            Voiture.voiture.Add(this);
        }

        static public Voiture recupVoitureById(int id)
        {
            for (int i = 0; i < Voiture.voiture.Count(); i++)
            {
                if (Voiture.voiture[i].id_voiture == id)
                {
                    return Voiture.voiture[i];
                }
            }
            return null;
        }
    }
}
