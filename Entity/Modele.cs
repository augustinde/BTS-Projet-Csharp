using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    public class Modele
    {
        /*
         * Propriété de l'objet Modele
         */
        private int idModele;
        private string nomModele;
        private int marque;

        /*
         * Constructeurs de l'objet Modele
         */
        public string ToString()
        {
            return this.idModele + " " + this.nomModele + " " + this.Marque;
        }

        public Modele()
        {

        }

        public Modele(int idModele, string nomModele, int marque)
        {
            this.idModele = idModele;
            this.nomModele = nomModele;
            this.Marque = marque;
        }
        public Modele(int idModele, string nomModele)
        {
            this.idModele = idModele;
            this.nomModele = nomModele;
        }


        public Modele(string nomModele, int marque)
        {
            this.nomModele = nomModele;
            this.Marque = marque;
        }

        /*
         * Accesseurs et mutateurs
         */
        public int IdModele { get => idModele; set => idModele = value; }
        public string NomModele { get => nomModele; set => nomModele = value; }
        public int Marque { get => marque; set => marque = value; }
    }
}
