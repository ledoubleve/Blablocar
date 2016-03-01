using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blabloCar
{
    public class Personne
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string password { get; set; }
        public int tauxsatisfaction { get; set; }

        // definition des attributs static 
        static public List<Personne> personne = new List<Personne>();

        public Personne(string nom, string prenom, string email, string telephone, string password)
        {

            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.telephone = telephone;
            this.password = password;
        }

        public Personne(int id, string nom, string prenom, string email, string telephone, string password)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.telephone = telephone;
            this.password = password;

            Personne.personne.Add(this);
        }

        public Personne(int id, string nom, string prenom, string email, string telephone)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.telephone = telephone;
        }
            // appel de la méthode d'ajout d'utilisateur dans la base de donnée

        static public Personne recupPersonneById(int id)
        {
            for (int i = 0; i < Personne.personne.Count(); i++)
            {
                if ( Personne.personne[i].id == id)
                {
                    return Personne.personne[i];
                }
            }
            return null;
        }
    }
}
