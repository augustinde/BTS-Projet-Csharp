using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    public class FicheAsPieceDet
    {
        /*
         * Propriété de l'objet FicheAsPieceDet
         */
        private int idFicheHasPieceDet;
        private int idFiche;
        private int idPieceDet;
        private int quantite;
        private double prixTotal;
        private string nomPiece;

        /*
         * Constructeurs de l'objet FicheAsPieceDet
         */
        public FicheAsPieceDet()
        {

        }

        public FicheAsPieceDet(int idPiece, string nomPiece, int quantite)
        {
            this.idPieceDet = idPiece;
            this.nomPiece = nomPiece;
            this.quantite = quantite;
        }

        public FicheAsPieceDet(int idFicheHasPiecDet, int idFiche, int idPieceDet, int quantite, double prixTotal)
        {
            this.idFicheHasPieceDet = idFicheHasPiecDet;
            this.idFiche = idFiche;
            this.idPieceDet = idPieceDet;
            this.quantite = quantite;
            this.prixTotal = prixTotal;
        }

        /*
         * Accesseurs et mutateurs
         */
        public int IdFiche { get => idFiche; set => idFiche = value; }
        public int IdPieceDet { get => idPieceDet; set => idPieceDet = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public double PrixTotal { get => prixTotal; set => prixTotal = value; }
        public int IdFicheHasPieceDet { get => idFicheHasPieceDet; set => idFicheHasPieceDet = value; }
        public string NomPiece { get => nomPiece; set => nomPiece = value; }
    }
}
