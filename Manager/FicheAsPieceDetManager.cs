using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB7.Component;
using MySql.Data.MySqlClient;

namespace LAB7
{
    public class FicheAsPieceDetManager
    {

        //Méthode qui créé la commande pour lire toutes les pièces reliés à toutes les fiches
        public List<FicheAsPieceDet> readAllPieceInFiche(int idFiche)
        {

            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("SELECT * FROM fichehaspiecedet WHERE idFiche = @idFiche");

            command.Parameters.AddWithValue("@idFiche", idFiche);

            List<FicheAsPieceDet> ficheCollection = baseDonnee.bdReadAllFicheHasPieceDet(command);

            return ficheCollection;


        }

        //Méthode qui créé la commande pour lire une pièce relié à une fiche
        public int readFiltreFicheHasPieceDet(int idFiche, int idPiece, int quantite, double prixTotal)
        {

            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("SELECT * FROM fichehaspiecedet WHERE idFiche = @idFiche AND idPieceDet = @idPiece");

            command.Parameters.AddWithValue("@idFiche", idFiche);
            command.Parameters.AddWithValue("@idPiece", idPiece);

            List<FicheAsPieceDet> ficheCollection = baseDonnee.bdReadAllFicheHasPieceDet(command);
            for (int i=0; i<ficheCollection.Count(); i++)
            {
                Console.WriteLine(ficheCollection[i]);
            }

            if (ficheCollection.Count() != 0)
            {
                int idFicheHasPieceDet = ficheCollection[0].IdFicheHasPieceDet;
                int quantiteExist = ficheCollection[0].Quantite;
                double prixTotalExist = ficheCollection[0].PrixTotal;

                int quantiteFinal = quantite + quantiteExist;
                double prixTotalFinal = prixTotal + prixTotalExist;

                int test = updateFicheHasPieceDetExist(idFicheHasPieceDet, quantiteFinal, prixTotalFinal);

                if (test == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 2;
            }


        }

        //Méthode qui créé la commande pour modifier une pièce relié à une fiche
        public int updateFicheHasPieceDetExist(int idFicheHasPieceDet, int quantite, double prixTotal)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE fichehaspiecedet SET quantite = @quantite, prixTotal = @prixTotal WHERE idFicheHasPieceDet = @idFicheHasPieceDet");


            command.Parameters.AddWithValue("@quantite", quantite);
            command.Parameters.AddWithValue("@prixTotal", prixTotal);
            command.Parameters.AddWithValue("@idFicheHasPieceDet", idFicheHasPieceDet);


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


        //Méthode qui créé la commande pour ajouter une pièce relié à une fiche en BDD
        public int createFicheHasPieceDet(int idFiche, int idPieceDet, int quantite, double prixTotal)
        {

            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fichehaspiecedet(idFiche, idPieceDet, quantite, prixTotal) VALUES(@idFiche, @idPieceDet, @quantite, @prixTotal)");

            cmd.Parameters.AddWithValue("@idFiche", idFiche);
            cmd.Parameters.AddWithValue("@idPieceDet", idPieceDet);
            cmd.Parameters.AddWithValue("@quantite", quantite);
            cmd.Parameters.AddWithValue("@prixTotal", prixTotal);

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


        //Méthode qui créé la commande pour supprimer les pièces relié à une fiche
        public bool deleteFicheHasPieceDet(int idFiche)
        {
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("DELETE FROM fichehaspiecedet WHERE idFiche = @idFiche");
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


    }
}
