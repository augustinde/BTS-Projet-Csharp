using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
   
    public class Client
    {
        /*
         * Propriété de l'objet Client
         */
        private int idClt;
        private string nomClt;
        private string prenomClt;
        private string adresseClt;
        private string cpClt;
        private string villeClt;
        private string adresseMailClt;
        private string telClt;

        /*
         * Constucteurs de l'objet Client
         */
        public Client(int idClt)
        {
            this.idClt = idClt;
        }

        public Client(int idClt, string nomClt, string prenomClt)
        {
            this.idClt = idClt;
            this.nomClt = nomClt;
            this.prenomClt = prenomClt; 
        }

        public Client()
        {

        }

        public Client(int idClt, string nomClt, string prenomClt, string adresseClt, string cpClt, string villeClt, string adresseMailClt, string telClt)
        {
            this.idClt = idClt;
            this.nomClt = nomClt;
            this.prenomClt = prenomClt;
            this.adresseClt = adresseClt;
            this.cpClt = cpClt;
            this.villeClt = villeClt;
            this.adresseMailClt = adresseMailClt;
            this.telClt = telClt;
        }
        

        /*
         * Accesseurs et mutateurs
         */
        public string fullNameClt
        {
            get
            {
                return nomClt + " " + prenomClt;
            }
        }
        public int IdClt { get => idClt; set => idClt = value; }
        public string NomClt { get => nomClt; set => nomClt = value; }
        public string PrenomClt { get => prenomClt; set => prenomClt = value; }
        public string AdresseClt { get => adresseClt; set => adresseClt = value; }
        public string CpClt { get => cpClt; set => cpClt = value; }
        public string VilleClt { get => villeClt; set => villeClt = value; }
        public string AdresseMailClt { get => adresseMailClt; set => adresseMailClt = value; }
        public string TelClt { get => telClt; set => telClt = value; }
    }


}
