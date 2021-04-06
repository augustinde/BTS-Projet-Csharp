using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB7.Component;
using MySql.Data.MySqlClient;

namespace LAB7
{
    public class FicheManager
    {

        //Méthode qui créé la commande pour lire une fiche
        public FicheDeReparation readFiche(int idFiche)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("SELECT * FROM fichedereparation INNER JOIN client ON client.idClt = fichedereparation.idClient INNER JOIN modele ON modele.idModele = fichedereparation.idModele INNER JOIN marque ON marque.idMarque = fichedereparation.idMarque INNER JOIN mainoeuvre ON mainoeuvre.idMainOeuvre = fichedereparation.idMainOeuvre INNER JOIN tva ON tva.idTva = fichedereparation.idTva WHERE fichedereparation.idFiche = @idFiche");

            command.Parameters.AddWithValue("@idFiche", idFiche);

            FicheDeReparation fiche = new FicheDeReparation();

            fiche = baseDonnee.bdReadFiche(command);

            return fiche;
        }

        //Méthode qui créé la commande pour lire toutes les fiches
        public List<FicheDeReparation> readAllFiche()
        {
            List<FicheDeReparation> ficheCollection = new List<FicheDeReparation>();
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("SELECT idFiche, ttc, statut, sousStatut, idClient FROM fichedereparation");

            ficheCollection = baseDonnee.bdReadAllFiche(command);

            return ficheCollection;
        }

        //Méthode qui créé la commande pour ajouter une fiche en BDD
        public long createFiche(DateTime dateAchat, Modele modele, Marque marque, string commentaire, int dureeRep, List<FicheAsPieceDet> ficheAsPieceDets, string statut, Client client, string numSerie)
        {
            double ttc = 0, ht = 0, surplusTVA;
            DateTime date = DateTime.Now;
            
            TvaManager tvaManager = new TvaManager();
            Tva tva = tvaManager.readTvaActif();

            MainOeuvreManager mainOeuvreManager = new MainOeuvreManager();
            MainOeuvre mainOeuvre = mainOeuvreManager.readMainOeuvreActif();

            foreach(FicheAsPieceDet ficheAsPieceDet in ficheAsPieceDets)
            {
                ht += ficheAsPieceDet.PrixTotal;
                Console.WriteLine("Prix item : " + ficheAsPieceDet.PrixTotal);
                Console.WriteLine("HT : " + ht);
            }

            ht = ht + mainOeuvre.MontantMainOeuvre * dureeRep;
            surplusTVA = ht * tva.MontantTva / 100;
            ttc = ht + surplusTVA;
            Console.WriteLine("Surplus :" + surplusTVA);
            Console.WriteLine("TVA :" + tva.MontantTva);
            Console.WriteLine("TTC :" + ttc);

            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fichedereparation(dateAchat, idModele, commentaire, dateDevis, dureeReparation, idTva, ttc, ht, idMainOeuvre, statut, sousStatut, idClient, idMarque, numSerie) " +
                "VALUES(@dateAchat, @idModele, @commentaire, @dateDevis, @dureeReparation, @idTva, @ttc, @ht, @idMainOeuvre, @statut, @sousStatut, @idClient, @idMarque, @numSerie)");

            cmd.Parameters.AddWithValue("@dateAchat", dateAchat);
            cmd.Parameters.AddWithValue("@idModele", modele.IdModele);
            cmd.Parameters.AddWithValue("@commentaire", commentaire);
            cmd.Parameters.AddWithValue("@dateDevis", date);
            cmd.Parameters.AddWithValue("@dureeReparation", dureeRep);
            cmd.Parameters.AddWithValue("@idTva", tva.IdTva);
            cmd.Parameters.AddWithValue("@ttc", ttc);
            cmd.Parameters.AddWithValue("@ht", ht);
            cmd.Parameters.AddWithValue("@idMainOeuvre", mainOeuvre.IdMainOeuvre);
            cmd.Parameters.AddWithValue("@statut", statut);
            cmd.Parameters.AddWithValue("@sousStatut", "En attente d'examen");
            cmd.Parameters.AddWithValue("@idClient", client.IdClt);
            cmd.Parameters.AddWithValue("@idMarque", marque.IdMarque);
            cmd.Parameters.AddWithValue("@numSerie", numSerie);
            long rqTest = baseDonnee.InsertReturnLastId(cmd);
            Console.WriteLine("Dernier id : " + rqTest);

            if (rqTest > -1)
            {

                return rqTest;
            }
            else
            {
                return -99;
            }

        }

        //Méthode qui créé la commande pour ajouter les pièces lié à une fiche en BDD
        public int createListPieceDet(List<FicheAsPieceDet> pieceDeta, long idFiche)
        {
            
            foreach (FicheAsPieceDet ficheAsPieceDet in pieceDeta)
            {
                BaseDonnee baseDonnee = new BaseDonnee();

                int idPieceDet = ficheAsPieceDet.IdPieceDet;
                int quantite = ficheAsPieceDet.Quantite;
                double total = ficheAsPieceDet.PrixTotal;

                Console.WriteLine("Piece :" + idPieceDet + "\nFiche : " + idFiche + "\nQte : " + quantite + "\nPrix : " + total);
                MySqlCommand cmd = new MySqlCommand("INSERT INTO fichehaspiecedet(idFiche, idPieceDet, quantite, prixTotal) VALUES(@idFiche, @idPieceDet, @quantite, @prixTotal)");
                
                cmd.Parameters.AddWithValue("@idFiche", Int32.Parse(idFiche.ToString()));
                cmd.Parameters.AddWithValue("@idPieceDet", idPieceDet);
                cmd.Parameters.AddWithValue("@quantite", quantite);
                cmd.Parameters.AddWithValue("@prixTotal", total);
                baseDonnee.Insert(cmd);

            }

            return 1;
        }

        //Méthode qui créé la commande pour supprime une fiche
        public bool deleteFiche(int idFiche)
        {
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("DELETE FROM fichedereparation WHERE idFiche = @idFiche");
            command.Parameters.AddWithValue("@idFiche", idFiche);
            bool rqTest = baseDonnee.Delete(command);

            if (rqTest)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Méthode qui créé la commande pour compter le nombre de fiche
        public int countFiche()
        {
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM fichedereparation");
            int nbFiche = baseDonnee.Count(command);
            return nbFiche;
        }

        //Méthode qui créé la commande pour modifier le sous statut d'une fiche
        public bool updateFicheSousStatut(int idFiche, string sousStatut)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE fichedereparation SET sousStatut = @sousStatut WHERE idFiche = @idFiche");

            command.Parameters.AddWithValue("@sousStatut", sousStatut);
            command.Parameters.AddWithValue("@idFiche", idFiche);

            bool rqTest = baseDonnee.Update(command);

            if (rqTest)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //Méthode qui créé la commande pour modifier le statut d'une fiche en devis
        public bool updateFicheDevis(int idFiche)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE fichedereparation SET statut = \"Devis\" WHERE idFiche = @idFiche");
           
            command.Parameters.AddWithValue("@idFiche", idFiche);

            bool rqTest = baseDonnee.Update(command);

            if (rqTest)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Méthode qui créé la commande pour modifier le statut d'une fiche en facture
        public bool updateFicheFacture(int idFiche)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE fichedereparation SET statut = \"Facture\" WHERE idFiche = @idFiche");

            command.Parameters.AddWithValue("@idFiche", idFiche);

            bool rqTest = baseDonnee.Update(command);

            if (rqTest)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Méthode qui créé la commande pour lire une fiche en fonction d'un filtre
        public List<FicheDeReparation> readFiltreFiche(string cibleFiltre, string valeurFiltre)
        {
            List<FicheDeReparation> ficheDeReparations = new List<FicheDeReparation>();
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand();
            string rq = "SELECT idFiche, ttc, statut, idClient, dateDevis FROM fichedereparation WHERE";

            if(cibleFiltre == "Numéro de fiche")
            {

                rq = rq + " idFiche = " + Int32.Parse(valeurFiltre);
                command.CommandText = rq;
                ficheDeReparations = baseDonnee.bdReadAllFiche(command);
                return ficheDeReparations;


            }
            else if(cibleFiltre == "Nom")
            {
                MySqlCommand command2 = new MySqlCommand("SELECT * FROM client WHERE nomClt = @valeurFiltre");
                command2.Parameters.AddWithValue("@valeurFiltre", valeurFiltre);

                Client client = baseDonnee.bdReadClient(command2);
                int idClt = client.IdClt;

                rq = rq + " idClient = " + idClt;
                command.CommandText = rq;
                ficheDeReparations = baseDonnee.bdReadAllFiche(command);
                return ficheDeReparations;

            }
            else if(cibleFiltre == "Statut")
            {
                rq = rq + " statut = " + "\"" +valeurFiltre + "\"";
                command.CommandText = rq;
                ficheDeReparations = baseDonnee.bdReadAllFiche(command);
                return ficheDeReparations;

            }
            else if(cibleFiltre == "Date")
            {
                DateTime date = Convert.ToDateTime(valeurFiltre);
                rq = rq + " dateDevis = " + "\"" + date.Year + "-" + date.Month + "-" + date.Day + "\"";
                command.CommandText = rq;
                ficheDeReparations = baseDonnee.bdReadAllFiche(command);
                return ficheDeReparations;

            }
            else
            {
                return null;

            }

           
        }
    }
}
