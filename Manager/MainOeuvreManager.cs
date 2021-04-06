using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LAB7.Component;

namespace LAB7
{
    public class MainOeuvreManager
    {

        //Méthode qui créé la commande pour ajouter une valeur de main oeuvre en BDD
        public int createMainOeuvre(double montant)
        {

            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("INSERT INTO mainoeuvre(montantMainOeuvre, actif) VALUES(@montantMainOeuvre, @actif)");
            command.Parameters.AddWithValue("@montantMainOeuvre", montant);
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

        //Méthode qui créé la commande pour lire la valeur de main d'oeuvre actif
        public MainOeuvre readMainOeuvreActif()
        {
            BaseDonnee baseDonnee = new BaseDonnee();
            MainOeuvre mainOeuvre = new MainOeuvre();
            MySqlCommand command = new MySqlCommand("SELECT * FROM mainoeuvre WHERE actif = 1");
            mainOeuvre = baseDonnee.bdReadMainOeuvre(command);

            return mainOeuvre;
        }


        //Méthode qui créé la commande pour lire toutes les valeurs de mains d'oeuvre
        public List<MainOeuvre> readAllMontant()
        {
            List<MainOeuvre> mainOeuvreCollection = new List<MainOeuvre>();
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("SELECT * FROM mainoeuvre");

            mainOeuvreCollection = baseDonnee.bdReadAllMainOeuvre(command);

            return mainOeuvreCollection;

        }

        //Méthode qui créé la commande pour activer une valeur de main d'oeuvre
        public int activeMontant(int idMontant)
        {
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("UPDATE mainoeuvre SET actif = 0");
            MySqlCommand command1 = new MySqlCommand("UPDATE mainoeuvre SET actif = 1 WHERE idMainOeuvre = @idMainOeuvre");
            command1.Parameters.AddWithValue("@idMainOeuvre", idMontant);

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
