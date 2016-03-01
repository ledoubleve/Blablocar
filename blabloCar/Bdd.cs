using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace blabloCar
{
    public class Bdd
    {

        private MySqlConnection connection;

        // Constructeur
        public Bdd()
        {
            this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=blablocar; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }

        public void recupVilleInList()
        {

            this.connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM ville ";

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr != null)
            {
                List<Ville> ville = new List<Ville>();
                while (rdr.Read())
                {
                    Ville BddVille = new Ville(Convert.ToInt32(rdr["id_ville"]), rdr["nom_ville"].ToString());
                }
            }
            this.connection.Close();
        }

        public void recupVoitureInList()
        {

            this.connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM voiture";

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr != null)
            {
                while (rdr.Read()) {
                    Personne proprietaire = Personne.recupPersonneById(Convert.ToInt32(rdr["id_personne"]));
                    Voiture voiture = new Voiture(Convert.ToInt32(rdr["id_voiture"]), rdr["marque"].ToString(), rdr["modele"].ToString(), proprietaire);
                }
            }
            this.connection.Close();
        }

        public void recupTrajetInList(Ville villedepart, Ville villearrivee)
        {

            this.connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM trajet WHERE id_ville_depart = @ville_depart AND id_ville_arrivee = @ville_arrivee";
            cmd.Parameters.AddWithValue("@ville_depart",villedepart.id_Ville);
            cmd.Parameters.AddWithValue("@ville_arrivee", villearrivee.id_Ville);

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr != null)
            {
                while (rdr.Read())
                {

                    Voiture voiture = Voiture.recupVoitureById(Convert.ToInt32(rdr["id_voiture"]));
                    Trajet trajet = new Trajet(Convert.ToInt32(rdr["placesDispo"]), rdr["heureDepart"].ToString(), villedepart, villearrivee, voiture);
                }
            }
            this.connection.Close();
        }


        public bool VerifLogin(string email, string motdepasse)
        {

            this.connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT motdepasse_personne FROM personne WHERE email_personne='" + email + "';";

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr != null)
            {
                while (rdr.Read())
                {
                    string stringmdp = rdr["motdepasse_personne"].ToString();
                    this.connection.Close();
                    if (motdepasse == stringmdp)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }


        public void AjouterLogin(Personne personne)
        {
            try
            {
                //open sql connection
                this.connection.Open();

                string sprenom = personne.prenom;
                string snom = personne.nom;
                string semail = personne.email;
                string smotdepasse = personne.password;
                string stelephone = personne.telephone;

                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO `personne`(`nom_personne`, `prenom_personne`, `email_personne`, `telephone_personne`, `motdepasse_personne`) VALUES (@prenom,@nom,@email,@telephone,@motdepasse)";

                cmd.Parameters.AddWithValue("@prenom", sprenom);
                cmd.Parameters.AddWithValue("@nom", snom);
                cmd.Parameters.AddWithValue("@email", semail);
                cmd.Parameters.AddWithValue("@motdepasse", smotdepasse);
                cmd.Parameters.AddWithValue("@telephone", stelephone);


                cmd.ExecuteNonQuery();

                //fermeture de la connexion
                this.connection.Close();
            }
            catch
            {
            }
        }

        public void recupPersonneInList()
        {

            this.connection.Open();

            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM personne";

            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr != null)
            {
                while (rdr.Read())
                {
                    Personne personne = new Personne(Convert.ToInt32(rdr["id_personne"]), rdr["nom_personne"].ToString(), rdr["prenom_personne"].ToString(), rdr["email_personne"].ToString(), rdr["telephone_personne"].ToString(), rdr["motdepasse_personne"].ToString());
                }
            }
            this.connection.Close();
        }
    }
}
