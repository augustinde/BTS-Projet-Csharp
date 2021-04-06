using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB7.Component;
using MySql.Data.MySqlClient;

namespace LAB7
{
    public class PieceDetacheeManager
    {

        //Méthode qui créé la commande pour lire toutes les pièces détachées
        public List<PieceDetachee> readAllPieceDetachee()
        {
            List<PieceDetachee> pieceDetacheeCollection = new List<PieceDetachee>();
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("SELECT * FROM piecedetachee");
            pieceDetacheeCollection = baseDonnee.bdReadAllPieceDeta(command);

            return pieceDetacheeCollection;
        }

        //Méthode qui créé la commande pour ajouter une pièce détachées en BDD
        public int createPieceDetachee(string nomPiece, double prixUnitaire, int stock)
        {

            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO piecedetachee(nomPieceDet, prixUnitairePieceDet, stockPieceDet) VALUES(@nomPiece, @prixUnitaire, @stock)");

            cmd.Parameters.AddWithValue("@nomPiece", nomPiece);
            cmd.Parameters.AddWithValue("@prixUnitaire", prixUnitaire);
            cmd.Parameters.AddWithValue("@stock", stock);

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

        //Méthode qui créé la commande pour lire une pièce d'étachée
        public PieceDetachee readPiece(int idPiece)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("SELECT * FROM piecedetachee WHERE idPieceDet = @idPiece");

            command.Parameters.AddWithValue("@idPiece", idPiece);

            PieceDetachee piece = new PieceDetachee();

            piece = baseDonnee.bdReadPiece(command);

            return piece;
        }

        //Méthode qui créé la commande pour supprimer une pièce détachée
        public int deletePieceDetachee(int idPiece)
        {
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("DELETE FROM piecedetachee WHERE idPieceDet = @idPiece");
            command.Parameters.AddWithValue("@idPiece", idPiece);
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

        //Méthode qui créé la commande pour modifier une pièce détachée
        public int updatePieceDetachee(int id, string nomPiece, double prixUnitaire, int stock)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE piecedetachee SET nomPieceDet = @nomPiece, prixUnitairePieceDet = @prixUnitaire, stockPieceDet = @stock WHERE idPieceDet = @id");
        
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nomPiece", nomPiece);
            command.Parameters.AddWithValue("@prixUnitaire", prixUnitaire);
            command.Parameters.AddWithValue("@stock", stock);


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

        //Méthode qui créé la commande pour modifier le stock d'une pièce détachée
        public int updateStockPieceDetachee(int id, int stock)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE piecedetachee SET stockPieceDet = @stock WHERE idPieceDet = @id");

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@stock", stock);


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

        //Méthode qui créé la commande pour modifier le stock d'une pièce détachée après la création d'une fiche de réparation
        public int updateStockAfterSaveFiche(int id, int quantite)
        {
            BaseDonnee baseDonnee = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE piecedetachee SET stockPieceDet = stockPieceDet - @quantite WHERE idPieceDet = @id");

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@quantite", quantite);


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

        //Méthode qui créé la commande pour lire une pièce en fonction d'un filtre
        public List<PieceDetachee> readFiltrePiece(string cibleFiltre, string valeurFiltre)
        {

            switch (cibleFiltre)
            {
                case "Identifiant":
                    cibleFiltre = "idPieceDet";
                    break;

                case "Libelle":
                    cibleFiltre = "nomPieceDet";
                    break;

                case "Prix unitaire":
                    cibleFiltre = "prixUnitairePieceDet";
                    break;

                case "Stock":
                    cibleFiltre = "stockPieceDet";
                    break;
            }
           

            List<PieceDetachee> pieceDetacheeCollection = new List<PieceDetachee>();
            BaseDonnee baseDonnee = new BaseDonnee();
            MySqlCommand command = new MySqlCommand("SELECT * FROM piecedetachee WHERE " + cibleFiltre + " = @valeurFiltre");
            command.Parameters.AddWithValue("@valeurFiltre", valeurFiltre);
            pieceDetacheeCollection = baseDonnee.bdReadAllPieceDeta(command);

            return pieceDetacheeCollection;
        }


    }
}
