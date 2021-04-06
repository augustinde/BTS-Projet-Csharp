using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LAB7.Component;
using System.Windows.Forms;

namespace LAB7.Manager
{
    public class ClientManager
    {
        //Méthode qui créé la commande pour lire tous les clients
        public List<Client> readAllClient()
        {
            List<Client> clientCollection = new List<Client>();
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("SELECT * FROM client");

            clientCollection = baseDonnee.bdReadAllClient(command);
          
            return clientCollection;
        }

        //Méthode qui créé la commande pour lire un client
        public Client readClient(int idClt)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("SELECT * FROM client WHERE idClt = @idClt");

            command.Parameters.AddWithValue("@idClt", idClt);
            
            Client client = new Client();

            client = baseDonnee.bdReadClient(command);

            return client;
        }

        //Méthode qui créé la commande pour créé un client en BDD
        public int createClient(string nomClt, string prenomClt, string adresseClt, string cpClt, string villeClt, string emailClt, string telClt)
        {

            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO client(nomClt, prenomClt, adresseClt, cpClt, villeClt, adresseMailClt, telClt) VALUES(@nomClt, @prenomClt, @adresseClt, @cpClt, @villeClt, @emailClt, @telClt)");
            
            cmd.Parameters.AddWithValue("@nomClt", nomClt);
            cmd.Parameters.AddWithValue("@prenomClt", prenomClt);
            cmd.Parameters.AddWithValue("@adresseClt", adresseClt);
            cmd.Parameters.AddWithValue("@cpClt", cpClt);
            cmd.Parameters.AddWithValue("@villeClt", villeClt);
            cmd.Parameters.AddWithValue("@emailClt", emailClt);
            cmd.Parameters.AddWithValue("@telClt", telClt);
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

        //Méthode qui créé la commande pour supprimer un client
        public int deleteClient(int idClt)
        {
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("DELETE FROM client WHERE idClt = @idClt");
            command.Parameters.AddWithValue("@idClt", idClt);
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

        //Méthode qui créé la commande pour modifier un client
        public int updateClient(int idClt, string nomClt, string prenomClt, string adresseClt, string cpClt, string villeClt, string emailClt, string telClt)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE client SET nomClt = @nomClt, prenomClt = @prenomClt, adresseClt = @adresseClt, cpClt = @cpClt, villeClt = @villeClt, adresseMailClt = @emailClt, telClt = @telClt WHERE idClt = @idClt");
            
            command.Parameters.AddWithValue("@nomClt", nomClt);
            command.Parameters.AddWithValue("@prenomClt", prenomClt);
            command.Parameters.AddWithValue("@adresseClt", adresseClt);
            command.Parameters.AddWithValue("@cpClt", cpClt);
            command.Parameters.AddWithValue("@villeClt", villeClt);
            command.Parameters.AddWithValue("@emailClt", emailClt);
            command.Parameters.AddWithValue("@telClt", telClt);
            command.Parameters.AddWithValue("@idClt", idClt);

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
