using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB7.Component;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LAB7.Manager
{
    public class ModeleManager
    {

        //Méthode qui créé la commande pour lire les modèles d'une marque
        public List<Modele> readModeleHasMarque(int marque)
        {
            List<Modele> modeleCollection = new List<Modele>();
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("SELECT * FROM modele WHERE marque =  @marque");
            command.Parameters.AddWithValue("@marque", marque);
            modeleCollection = baseDonnee.bdReadAllModele(command);

            return modeleCollection;
        }

        //Méthode qui créé la commande pour lire tout les modèles
        public List<Modele> readAllModele()
        {
            List<Modele> modeleCollection = new List<Modele>();
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("SELECT * FROM modele");

            modeleCollection = baseDonnee.bdReadAllModele(command);

            return modeleCollection;
        }

        //Méthode qui créé la commande pour lire un modèle
        public Modele readModele(int idModele)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("SELECT * FROM modele WHERE idModele = @idModele");

            command.Parameters.AddWithValue("@idModele", idModele);

            Modele modele = new Modele();

            modele = baseDonnee.bdReadModele(command);

            return modele;
        }

        //Méthode qui créé la commande pour créé un modèle
        public int createModele(string nomModele, int marque)
        {
            BaseDonnee bd = new BaseDonnee();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO modele(nomModele, marque) VALUES(@nomModele, @marque)");

            cmd.Parameters.AddWithValue("@nomModele", nomModele);
            cmd.Parameters.AddWithValue("@marque", marque);

            bool rqTest = bd.Insert(cmd);

            if (rqTest)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        //Méthode qui créé la commande pour supprimer une modèle
        public int deleteModele(int idModele)
        {
            BaseDonnee bd = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("DELETE FROM modele WHERE idModele = @idModele");
            command.Parameters.AddWithValue("@idModele", idModele);
            bool rqTest = bd.Delete(command);

            if (rqTest)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Méthode qui créé la commande pour modifier un modèle
        public int updateModele(int idModele, string nomModele)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE modele SET nomModele = @nomModele WHERE idModele = @idModele");

            command.Parameters.AddWithValue("@nomModele", nomModele);
            command.Parameters.AddWithValue("@idModele", idModele);

            bool rqTest = baseDonnee.Update(command);

            if (rqTest)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


    }
}
