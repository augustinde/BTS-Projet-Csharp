using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    public class PieceDetachee
    {
        /*
         * Propriété de l'objet PieceDetachee
         */
        private int idPieceDet;
        private string nomPieceDet;
        private double prixUnitairePieceDet;
        private int stockPieceDet;

        /*
         * Constructeurs de l'objet PieceDetachee
         */
        public PieceDetachee()
        {

        }

        public PieceDetachee(int idPieceDet, string nomPieceDet)
        {
            this.idPieceDet = idPieceDet;
            this.nomPieceDet = nomPieceDet;
        }

        public PieceDetachee(string nomPieceDet, double prixUnitairePieceDet, int stockPieceDet)
        {
            this.nomPieceDet = nomPieceDet;
            this.prixUnitairePieceDet = prixUnitairePieceDet;
            this.stockPieceDet = stockPieceDet;
        }

        public PieceDetachee(int idPieceDet, string nomPieceDet, double prixUnitairePieceDet, int stockPieceDet)
        {
            this.idPieceDet = idPieceDet;
            this.nomPieceDet = nomPieceDet;
            this.prixUnitairePieceDet = prixUnitairePieceDet;
            this.stockPieceDet = stockPieceDet;
        }

        /*
         * Accesseurs et mutateurs
         */
        public int IdPieceDet { get => idPieceDet; set => idPieceDet = value; }
        public string NomPieceDet { get => nomPieceDet; set => nomPieceDet = value; }
        public double PrixUnitairePieceDet { get => prixUnitairePieceDet; set => prixUnitairePieceDet = value; }
        public int StockPieceDet { get => stockPieceDet; set => stockPieceDet = value; }
    }
}
