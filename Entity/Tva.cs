using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    public class Tva
    {
        /*
         * Propritété de l'objet Tva
         */
        private int idTva;
        private double montantTva;
        private bool actif;

        /*
         * Constructeurs de l'objet Tva
         */
        public Tva(int idTva, double montantTva, bool actif)
        {
            this.idTva = idTva;
            this.montantTva = montantTva;
            this.actif = actif;
        }
        public Tva(int idTva, double montantTva)
        {
            this.idTva = idTva;
            this.montantTva = montantTva;
        }

        public Tva() { 
        }

        /*
         * Accesseurs et mutateurs
         */
        public int IdTva { get => idTva; set => idTva = value; }
        public double MontantTva { get => montantTva; set => montantTva = value; }
        public bool Actif { get => actif; set => actif = value; }
    }
}
