using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    public class Marque
    {
        private int idMarque;
        private string nomMarque;

        public Marque()
        {
        }

        public Marque(int idMarque, string nomMarque)
        {
            this.idMarque = idMarque;
            this.nomMarque = nomMarque;
        }

        /*
         * Accesseurs et mutateurs
         */
        public int IdMarque { get => idMarque; set => idMarque = value; }
        public string NomMarque { get => nomMarque; set => nomMarque = value; }



    }
}
