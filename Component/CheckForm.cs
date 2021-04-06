using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB7.Component
{
    public class CheckForm
    {
        /*
         * Méthode qui vérifie si le Form passer en paramètre est instancié
         */
        public Form VerifOpenFormTest(string nomForm)
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name == nomForm)
                {
                    return fm;
                }
            }
            return null;
        }


    }
}
