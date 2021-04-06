using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LAB7.Component;

namespace LAB7
{
    public class TvaManager
    {

        //Méthode qui créé la commande pour ajouter un taux de tva en BDD
        public int createTva(double montantTva)
        {

            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("INSERT INTO tva(montantTva, actif) VALUES(@montantTva, @actif)");
            command.Parameters.AddWithValue("@montantTva", montantTva);
            command.Parameters.AddWithValue("@actif", 0);

            bool rqTest = baseDonnee.Insert(command);

            if (rqTest)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        //Méthode qui créé la commande pour lire le taux de tva actif
        public Tva readTvaActif()
        {
            BaseDonnee baseDonnee = new BaseDonnee();
            Tva tva = new Tva();
            MySqlCommand command = new MySqlCommand("SELECT * FROM tva WHERE actif = 1");
            tva = baseDonnee.bdReadTva(command);

            return tva;
        }


        //Méthode qui créé la commande pour lire tout les taux de tva
        public List<Tva> readAllTva()
        {
            List<Tva> tvaCollection = new List<Tva>();
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("SELECT * FROM tva");

            tvaCollection = baseDonnee.bdReadAllTva(command);

            return tvaCollection;

        }

        //Méthode qui créé la commande pour activer un taux de tva
        public int activeTaux(int idTaux)
        {
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("UPDATE tva SET actif = 0");
            MySqlCommand command1 = new MySqlCommand("UPDATE tva SET actif = 1 WHERE idTva = @idTva");
            command1.Parameters.AddWithValue("@idTva", idTaux);

            bool rqTest = baseDonnee.DoubleUpdate(command, command1);

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
