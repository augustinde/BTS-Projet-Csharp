using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB7;
using System.Globalization;

namespace LAB7.Component
{
    public class BaseDonnee
    {
        /*
         * Propriété de l'objet BaseDonnee
         */
        private string bdd = "server=localhost;port=3306;database=testlab7;uid=root";
        private MySqlConnection connexion;

        /*
         * Accesseurs et mutateurs
         */
        public string Bdd { get => bdd; set => bdd = value; }
        
        /*
         * Constructeur de l'objet BaseDonnee
         */
        public BaseDonnee()
        {

            connexion = new MySqlConnection(bdd);

        }

        /*
         * Ouvrir la connexion à la BDD
         */
        private bool OpenConnexion()
        {
            try
            {
                connexion.Open();
                return true;
            }
            catch (MySqlException e)
            {

                return false;

            }
        }

        /*
         * Fermer la connexion à la BDD
         */
        private bool CloseConnexion()
        {
            try
            {
                connexion.Close();
                return true;
            }
            catch (MySqlException e)
            { 
                return false;
            }
        }

        /*
        * Fonction SQL COUNT()
        */
        public int Count(MySqlCommand command)
        {
            int count = 0;
            if (this.OpenConnexion())
            {
                
                command.Connection = connexion;

                try
                {
                    count = Int32.Parse(command.ExecuteScalar().ToString());
                    this.CloseConnexion();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    count = 0;
                }

            }
            else
            {
                count = 0;
            }

            return count;
        }

        /*
         * Fonction d'ajout d'objet
         */
        public bool Insert(MySqlCommand command)
        {
            bool insertIsOk = false;   
            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    command.ExecuteNonQuery();
                    insertIsOk = true;
                    this.CloseConnexion();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    insertIsOk = false;
                }

            }
            else
            {
                insertIsOk = false;
            }

            return insertIsOk;
        }

        /*
         * Fonction de récupération de la dernière instance ajouté à la BDD
         */
        public long InsertReturnLastId(MySqlCommand command)
        {
            long lastId = -99;
            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    command.ExecuteNonQuery();
                    lastId = command.LastInsertedId;
                    this.CloseConnexion();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    lastId = -99;
                }

            }
            else
            {
                lastId = -99;
            }

            return lastId;
        }

        /*
         * Fonction de suppression
         */
        public bool Delete(MySqlCommand command)
        {

            bool deleteIsOk = false;

            if (this.OpenConnexion() == true)
            {
                command.Connection = connexion;

                try
                {
                    command.ExecuteNonQuery();
                    deleteIsOk = true;
                    this.CloseConnexion();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message);
                    deleteIsOk = false;

                }

            }
            else
            {
                deleteIsOk = false;
            }

            return deleteIsOk;

        }

        /*
         * Fonction de mise à jour
         */
        public bool Update(MySqlCommand command)
        {

            bool updateIsOk = false;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;


                try
                {
                    command.ExecuteNonQuery();
                    updateIsOk = true;
                    this.CloseConnexion();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    updateIsOk = false;
                }

            }
            else
            {
                updateIsOk = false;
            }

            return updateIsOk;

        }

        /*
         * Fonction de double mise à jour
         */
        public bool DoubleUpdate(MySqlCommand command, MySqlCommand command1)
        {

            bool updateIsOk = false;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;


                try
                {
                    command.ExecuteNonQuery();
                    updateIsOk = true;
                    this.CloseConnexion();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    updateIsOk = false;
                }

            }
            else
            {
                updateIsOk = false;
            }



            if (this.OpenConnexion())
            {
                command1.Connection = connexion;


                try
                {
                    command1.ExecuteNonQuery();
                    updateIsOk = true;
                    this.CloseConnexion();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command1.CommandText);
                    updateIsOk = false;
                }

            }
            else
            {
                updateIsOk = false;
            }

            return updateIsOk;

        }


        /*
         * Méthode de lecture de tous les clients
         */
        public List<Client> bdReadAllClient(MySqlCommand command)
        {
            List<Client> clientCollection = new List<Client>();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if(lecteur != null)
                    {
                        while (lecteur.Read())
                        {
                            Client clt = new Client((int)lecteur[0], lecteur[1].ToString(), lecteur[2].ToString(), lecteur[3].ToString(), lecteur[4].ToString(), lecteur[5].ToString(), lecteur[6].ToString(), lecteur[7].ToString());
                            clientCollection.Add(clt);
                        }

                        this.CloseConnexion();

                        return clientCollection;
                    }
                    else
                    {
                        return null;
                    }


                }
                catch (Exception e)
                {

                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;

                }


            }
            else
            {
                return null;
            }
           
        }

        /*
         * Méthode de lecture d'un client
         */
        public Client bdReadClient(MySqlCommand command)
        {
            Client client = new Client();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();
                    
                    if(lecteur != null)
                    {

                        while (lecteur.Read())
                        {
                            client.IdClt = (int)lecteur[0];
                            client.NomClt = lecteur[1].ToString();
                            client.PrenomClt = lecteur[2].ToString();
                            client.AdresseClt = lecteur[3].ToString();
                            client.CpClt = lecteur[4].ToString();
                            client.VilleClt = lecteur[5].ToString();
                            client.AdresseMailClt = lecteur[6].ToString();
                            client.TelClt = lecteur[7].ToString();
                        }
                        this.CloseConnexion();
                        return client;

                    }
                    else
                    {
                        return null;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;
                }

            }
            else
            {
                return null;
            }

        }


        /*
         * Méthode de lecture d'une marque
         */
        public Marque bdReadMarque(MySqlCommand command)
        {
            Marque marque = new Marque();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {

                        while (lecteur.Read())
                        {
                            marque.IdMarque = (int)lecteur[0];
                            marque.NomMarque = lecteur[1].ToString();
                          
                        }
                        this.CloseConnexion();
                        return marque;

                    }
                    else
                    {
                        return null;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;
                }

            }
            else
            {
                return null;
            }

        }


        /*
         * Méthode de lecture de toutes les marques
         */
        public List<Marque> bdReadAllMarque(MySqlCommand command)
        {
            List<Marque> marqueCollection = new List<Marque>();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {
                        while (lecteur.Read())
                        {
                            Marque marque = new Marque((int)lecteur[0], lecteur[1].ToString());
                            marqueCollection.Add(marque);
                        }

                        this.CloseConnexion();

                        return marqueCollection;
                    }
                    else
                    {
                        return null;
                    }


                }
                catch (Exception e)
                {

                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;

                }


            }
            else
            {
                return null;
            }

        }



        /*
         * Méthode de lecture d'un modèle
         */
        public Modele bdReadModele(MySqlCommand command)
        {
            Modele modele = new Modele();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {
                        
                        while (lecteur.Read())
                        {
                            modele.IdModele = (int)lecteur[0];
                            modele.NomModele = lecteur[1].ToString();
                        }
                        this.CloseConnexion();
                        return modele;

                    }
                    else
                    {
                        return null;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;
                }

            }
            else
            {
                return null;
            }

        }

        /*
        * Méthode de lecture de tous les modèles
        */
        public List<Modele> bdReadAllModele(MySqlCommand command)
        {
            List<Modele> modeleCollection = new List<Modele>();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {
                        while (lecteur.Read())
                        {
                            Modele marque = new Modele((int)lecteur[0], lecteur[1].ToString(), (int)lecteur[2]);
                            modeleCollection.Add(marque);
                        }

                        this.CloseConnexion();

                        return modeleCollection;
                    }
                    else
                    {
                        return null;
                    }


                }
                catch (Exception e)
                {

                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;

                }


            }
            else
            {
                return null;
            }

        }

        /*
         * Méthode de lecture de toutes les tva
         */
        public List<Tva> bdReadAllTva(MySqlCommand command)
        {
            List<Tva> tvaCollection = new List<Tva>();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {
                        while (lecteur.Read())
                        {
                            Tva tva = new Tva((int)lecteur[0], (double)lecteur[1], (bool)lecteur[2]);
                            tvaCollection.Add(tva);
                        }

                        this.CloseConnexion();

                        return tvaCollection;
                    }
                    else
                    {
                        return null;
                    }


                }
                catch (Exception e)
                {

                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        /*
         * Méthode de lecture d'une tva
         */
        public Tva bdReadTva(MySqlCommand command)
        {
            Tva tva = new Tva();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {

                        while (lecteur.Read())
                        {
                            tva.IdTva = (int)lecteur[0];
                            tva.MontantTva = (double)lecteur[1];
                        }
                        this.CloseConnexion();
                        return tva;

                    }
                    else
                    {
                        return null;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;
                }

            }
            else
            {
                return null;
            }

        }

        /*
         * Méthode de lecture de toutes les mains d'oeuvres
         */
        public List<MainOeuvre> bdReadAllMainOeuvre(MySqlCommand command)
        {
            List<MainOeuvre> mainOeuvreCollection = new List<MainOeuvre>();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {
                        while (lecteur.Read())
                        {
                            MainOeuvre mainOeuvre = new MainOeuvre((int)lecteur[0], (double)lecteur[1], (bool)lecteur[2]);
                            mainOeuvreCollection.Add(mainOeuvre);
                        }

                        this.CloseConnexion();

                        return mainOeuvreCollection;
                    }
                    else
                    {
                        return null;
                    }


                }
                catch (Exception e)
                {

                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        /*
         * Méthode de lecture d'une main oeuvre
         */
        public MainOeuvre bdReadMainOeuvre(MySqlCommand command)
        {
            MainOeuvre mainOeuvre = new MainOeuvre();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {

                        while (lecteur.Read())
                        {
                            mainOeuvre.IdMainOeuvre = (int)lecteur[0];
                            mainOeuvre.MontantMainOeuvre = (double)lecteur[1];
                        }
                        this.CloseConnexion();
                        return mainOeuvre;

                    }
                    else
                    {
                        return null;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;
                }

            }
            else
            {
                return null;
            }

        }

        /*
         * Méthode de lecture de toutes les pièces détachées
         */
        public List<PieceDetachee> bdReadAllPieceDeta(MySqlCommand command)
        {
            List<PieceDetachee> pieceDetacheeCollection = new List<PieceDetachee>();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {
                        while (lecteur.Read())
                        {
                            PieceDetachee piece = new PieceDetachee((int)lecteur[0], lecteur[1].ToString(), (double)lecteur[2], (int)lecteur[3]);
                            pieceDetacheeCollection.Add(piece);
                        }

                        this.CloseConnexion();

                        return pieceDetacheeCollection;
                    }
                    else
                    {
                        return null;
                    }


                }
                catch (Exception e)
                {

                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;

                }


            }
            else
            {
                return null;
            }



        }

        /*
         * Méthode de lecture d'une pièce détachée
         */
        public PieceDetachee bdReadPiece(MySqlCommand command)
        {
            PieceDetachee piece = new PieceDetachee();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {

                        while (lecteur.Read())
                        {
                            piece.IdPieceDet = (int)lecteur[0];
                            piece.NomPieceDet = lecteur[1].ToString();
                            piece.PrixUnitairePieceDet = (double)lecteur[2];
                            piece.StockPieceDet = (int)lecteur[3];
                        }
                        this.CloseConnexion();
                        return piece;

                    }
                    else
                    {
                        return null;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;
                }

            }
            else
            {
                return null;
            }

        }

        /*
         * Méthode de lecture de toutes les pièces liées aux fiches de réparation
         */
        public List<FicheAsPieceDet> bdReadAllFicheHasPieceDet(MySqlCommand command)
        {
            List<FicheAsPieceDet> ficheAsPieceDetCollection = new List<FicheAsPieceDet>();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {
                        while (lecteur.Read())
                        {
                            FicheAsPieceDet ficheAsPieceDet = new FicheAsPieceDet((int)lecteur[0], (int)lecteur[1], (int)lecteur[2], (int)lecteur[3], (double)lecteur[4]);
                            ficheAsPieceDetCollection.Add(ficheAsPieceDet);
                        }

                        this.CloseConnexion();

                        return ficheAsPieceDetCollection;
                    }
                    else
                    {
                        return null;
                    }


                }
                catch (Exception e)
                {

                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;

                }


            }
            else
            {
                return null;
            }



        }

        /*
         * Méthode de lecture de toutes les fiches de réparation
         */
        public List<FicheDeReparation> bdReadAllFiche(MySqlCommand command)
        {
            List<FicheDeReparation> ficheCollection = new List<FicheDeReparation>();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {
                        while (lecteur.Read())
                        {
                            FicheDeReparation fiche = new FicheDeReparation((int)lecteur[0], (double)lecteur[1], lecteur[2].ToString(), new Client((int)lecteur[3]));
                            ficheCollection.Add(fiche);
                        }

                        this.CloseConnexion();

                        return ficheCollection;
                    }
                    else
                    {
                        return null;
                    }


                }
                catch (Exception e)
                {

                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;

                }


            }
            else
            {
                return null;
            }


        }

        /*
         * Méthode de lecture d'une fiche de réparation
         */
        public FicheDeReparation bdReadFiche(MySqlCommand command)
        {
            FicheDeReparation fiche = new FicheDeReparation();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {

                        while (lecteur.Read())
                        {

                            fiche.IdFiche = Int32.Parse(lecteur[0].ToString());
                            fiche.DateAchat = DateTime.Parse(lecteur[1].ToString());

                            Modele modele = new Modele(Int32.Parse(lecteur[2].ToString()), lecteur[24].ToString());
                            fiche.Modele = modele; 
                            fiche.Commentaire = lecteur[3].ToString();

                            fiche.DateDevis = DateTime.Parse(lecteur[4].ToString());
                            fiche.DureeReparation = Int32.Parse(lecteur[5].ToString());

                            Tva tva = new Tva(Int32.Parse(lecteur[6].ToString()), Double.Parse(lecteur[32].ToString()));
                            fiche.TVA1 = tva;
                            fiche.TTC1 = Double.Parse(lecteur[7].ToString());
                            fiche.HT1 = Double.Parse(lecteur[8].ToString());

                            MainOeuvre mainOeuvre = new MainOeuvre(Int32.Parse(lecteur[9].ToString()), Double.Parse(lecteur[29].ToString()));
                            fiche.MainOeuvre = mainOeuvre;
                            fiche.Statut = lecteur[10].ToString();
                            fiche.SousStatut = lecteur[11].ToString();

                            Client client = new Client(Int32.Parse(lecteur[12].ToString()), lecteur[16].ToString(), lecteur[17].ToString(), lecteur[18].ToString(), lecteur[19].ToString(), lecteur[20].ToString(), lecteur[21].ToString(), lecteur[22].ToString());
                            fiche.Client = client;

                            Marque marque = new Marque(Int32.Parse(lecteur[26].ToString()), lecteur[27].ToString());
                            fiche.Marque = marque;

                            fiche.NumSerie = lecteur[14].ToString();

                        }
                        this.CloseConnexion();
                        return fiche;

                    }
                    else
                    {
                        return null;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;
                }

            }
            else
            {
                return null;
            }

        }

        /*
         * Méthode de lecture de tous les employés
         */
        public List<Employe> bdReadAllEmploye(MySqlCommand command)
        {
            List<Employe> employes = new List<Employe>();

            MySqlDataReader lecteur;

            if (this.OpenConnexion())
            {
                command.Connection = connexion;

                try
                {
                    lecteur = command.ExecuteReader();

                    if (lecteur != null)
                    {
                        while (lecteur.Read())
                        {
                            Employe employe = new Employe(Int32.Parse(lecteur[0].ToString()), lecteur[1].ToString(), lecteur[2].ToString(), lecteur[3].ToString(), lecteur[4].ToString());
                            employes.Add(employe);
                        }

                        this.CloseConnexion();

                        return employes;
                    }
                    else
                    {
                        return null;
                    }


                }
                catch (Exception e)
                {

                    MessageBox.Show("Erreur : " + e.Message + "\nRequete : " + command.CommandText);
                    return null;

                }


            }
            else
            {
                return null;
            }

        }


    }
}
