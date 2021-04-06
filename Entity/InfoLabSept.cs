using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    public class InfoLabSept
    {
        /*
         * Propriété de l'objet InfoLabSept
         */
        private int idInfoLab;
        private string nomLab;
        private string adresseLab;
        private string cpLab;
        private string villeLab;
        private string telLab;
        private string faxLab;
        private string typeSocieteLab;
        private string RCSLab;
        private string SiretLab;
        private string APELab;

        /*
         * Constructeurs de l'objet InfoLabSept
         */
        public InfoLabSept()
        {

        }

        public InfoLabSept(string nomLab, string adresseLab, string cpLab, string villeLab, string telLab, string faxLab, string typeSocieteLab, string rCSLab, string siretLab, string aPELab)
        {
            this.nomLab = nomLab;
            this.adresseLab = adresseLab;
            this.cpLab = cpLab;
            this.villeLab = villeLab;
            this.telLab = telLab;
            this.faxLab = faxLab;
            this.typeSocieteLab = typeSocieteLab;
            RCSLab = rCSLab;
            SiretLab = siretLab;
            APELab = aPELab;
        }

        /*
         * Accesseurs et mutateurs
         */
        public int IdInfoLab { get => idInfoLab; set => idInfoLab = value; }
        public string NomLab { get => nomLab; set => nomLab = value; }
        public string AdresseLab { get => adresseLab; set => adresseLab = value; }
        public string CpLab { get => cpLab; set => cpLab = value; }
        public string VilleLab { get => villeLab; set => villeLab = value; }
        public string TelLab { get => telLab; set => telLab = value; }
        public string FaxLab { get => faxLab; set => faxLab = value; }
        public string TypeSocieteLab { get => typeSocieteLab; set => typeSocieteLab = value; }
        public string RCSLab1 { get => RCSLab; set => RCSLab = value; }
        public string SiretLab1 { get => SiretLab; set => SiretLab = value; }
        public string APELab1 { get => APELab; set => APELab = value; }
    }
}
