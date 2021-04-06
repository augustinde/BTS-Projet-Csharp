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
    public class MarqueManager
    {

        //Méthode qui créé la commande pour lire toutes les marques
        public List<Marque> readAllMarque()
        {
            List<Marque> marqueCollection = new List<Marque>();
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("SELECT * FROM marque");

            marqueCollection = baseDonnee.bdReadAllMarque(command);

            return marqueCollection;
        }

        //Méthode qui créé la commande pour lire une marque
        public Marque readMarque(int idMarque)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("SELECT * FROM marque WHERE idMarque = @idMarque");

            command.Parameters.AddWithValue("@idMarque", idMarque);

            Marque marque = new Marque();

            marque = baseDonnee.bdReadMarque(command);

            return marque;
        }

        //Méthode qui créé la commande pour ajouter une marque en BDD
        public int createMarque(string nomMarque)
        {
            BaseDonnee bd = new BaseDonnee();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO marque(nomMarque) VALUES(@nomMarque)");

            cmd.Parameters.AddWithValue("@nomMarque", nomMarque);

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

        //Méthode qui créé la commande pour modifier une marque
        public int updateMarque(int idMarque, string nomMarque)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE marque SET nomMarque = @nomMarque WHERE idMarque = @idMarque");

            command.Parameters.AddWithValue("@nomMarque", nomMarque);
            command.Parameters.AddWithValue("@idMarque", idMarque);

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

        //Méthode qui créé la commande pour supprimer une marque
        public int deleteMarque(int idMarque)
        {
            BaseDonnee bd = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("DELETE FROM marque WHERE idMarque = @idMarque");
            command.Parameters.AddWithValue("@idMarque", idMarque);
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


    }
}
