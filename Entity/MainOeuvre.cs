using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    public class MainOeuvre
    {
        /*
         * Propriété de l'objet MainOeuvre
         */
        private int idMainOeuvre;
        private double montantMainOeuvre;
        private bool actif;

        /*
         * Constructeurs de l'objet MainOeuvre
         */
        public MainOeuvre()
        {
        }

        public MainOeuvre(int idMainOeuvre, double montantMainOeuvre, bool actif)
        {
            this.idMainOeuvre = idMainOeuvre;
            this.montantMainOeuvre = montantMainOeuvre;
            this.actif = actif;
        }
        public MainOeuvre(int idMainOeuvre, double montantMainOeuvre)
        {
            this.idMainOeuvre = idMainOeuvre;
            this.montantMainOeuvre = montantMainOeuvre;
        }

        /*
         * Accesseurs et mutateurs
         */
        public int IdMainOeuvre { get => idMainOeuvre; set => idMainOeuvre = value; }
        public bool Actif { get => actif; set => actif = value; }
        public double MontantMainOeuvre { get => montantMainOeuvre; set => montantMainOeuvre = value; }
    }
}
