using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    public class Employe
    {
        /*
         * Propriété de l'objet Employe
         */
        private int idEmploye;
        private string nomUtilisateur;
        private string motDePasse;
        private string fonction;
        private string actif;
        /*
         * Constructeurs de l'objet Employe
         */
        public Employe()
        {
        }

        public Employe(int idEmploye, string nomUtilisateur, string fonction)
        {
            this.idEmploye = idEmploye;
            this.nomUtilisateur = nomUtilisateur;
            this.fonction = fonction;
        }

        public Employe(string nomUtilisateur, string motDePasse, string fonction)
        {
            this.nomUtilisateur = nomUtilisateur;
            this.motDePasse = motDePasse;
            this.fonction = fonction;
        }

        public Employe(int idEmploye, string nomUtilisateur, string motDePasse, string fonction)
        {
            this.idEmploye = idEmploye;
            this.nomUtilisateur = nomUtilisateur;
            this.motDePasse = motDePasse;
            this.fonction = fonction;
        }

        public Employe(int idEmploye, string nomUtilisateur, string motDePasse, string fonction, string actif)
        {
            this.idEmploye = idEmploye;
            this.nomUtilisateur = nomUtilisateur;
            this.motDePasse = motDePasse;
            this.fonction = fonction;
            this.actif = actif;
        }

        /*
         * Accesseurs et mutateurs
         */
        public int IdEmploye { get => idEmploye; set => idEmploye = value; }
        public string NomUtilisateur { get => nomUtilisateur; set => nomUtilisateur = value; }
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }
        public string Fonction { get => fonction; set => fonction = value; }
        public string Actif { get => actif; set => actif = value; }
    }
}
