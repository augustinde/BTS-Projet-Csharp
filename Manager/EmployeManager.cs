using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB7.Component;
using MySql.Data.MySqlClient;

namespace LAB7
{
    public class EmployeManager
    {

        //Méthode qui créé la commande pour lire tous les employés
        public List<Employe> readAllEmploye()
        {
            List<Employe> employes = new List<Employe>();
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("SELECT * FROM employe");

            employes = baseDonnee.bdReadAllEmploye(command);

            return employes;
        }

        //Méthode qui créé la commande pour créé un employé en BDD
        public int createEmploye(string mdp, string nomUser, string fonction)
        {

            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO employe(nomUtilisateur, motDePasse, fonction, actif) VALUES(@nomUser, @mdp, @fonction, @actif)");

            cmd.Parameters.AddWithValue("@nomUser", nomUser);
            cmd.Parameters.AddWithValue("@mdp", mdp);
            cmd.Parameters.AddWithValue("@fonction", fonction);
            cmd.Parameters.AddWithValue("@actif", "oui");
            bool rqTest = baseDonnee.Insert(cmd);


            if (rqTest)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }

        //Méthode qui créé la commande pour supprimer un employé
        public int deleteEmploye(int idEmploye)
        {
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("DELETE FROM employe WHERE idEmploye = @idEmploye");
            command.Parameters.AddWithValue("@idEmploye", idEmploye);
            bool rqTest = baseDonnee.Delete(command);

            if (rqTest)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Méthode qui créé la commande pour modifier un employé
        public int updateEmploye(int idEmploye, string nomUser, string mdp, string fonction)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE employe SET nomUtilisateur = @nomUser, motDePasse = @mdp, fonction = @fonction WHERE idEmploye = @idEmploye");

            command.Parameters.AddWithValue("@nomUser", nomUser);
            command.Parameters.AddWithValue("@mdp", mdp);
            command.Parameters.AddWithValue("@fonction", fonction);
            command.Parameters.AddWithValue("@idEmploye", idEmploye);

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

        //Méthode qui créé la commande pour désactiver l'accés au logiciel à un employé
        public int updateDesactiverEmploye(int idEmploye)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE employe SET actif = @actif WHERE idEmploye = @idEmploye");

            command.Parameters.AddWithValue("@actif", "non");
            command.Parameters.AddWithValue("@idEmploye", idEmploye);

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

        //Méthode qui créé la commande pour activer l'accés au logiciel à un employé
        public int updateActiverEmploye(int idEmploye)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE employe SET actif = @actif WHERE idEmploye = @idEmploye");

            command.Parameters.AddWithValue("@actif", "oui");
            command.Parameters.AddWithValue("@idEmploye", idEmploye);

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
