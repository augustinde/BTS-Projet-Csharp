using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB7.Manager;

namespace LAB7
{
    public partial class FmInfoLab : Form
    {
        public FmInfoLab()
        {
            InitializeComponent();
        }

        private void FmInfoLab_Load(object sender, EventArgs e)
        {
            InfoLabSept info = new InfoLabSept();
            InfoManager infoManager = new InfoManager();
            info = infoManager.readInfo();

            lbInfoLab.Text = lbInfoLab.Text + " " + info.NomLab;
            tbNom.Text = info.NomLab;
            tbAdresse.Text = info.AdresseLab;
            tbCp.Text = info.CpLab;
            tbVille.Text = info.VilleLab;
            tbTel.Text = info.TelLab;
            tbFax.Text = info.FaxLab;
            tbType.Text = info.TypeSocieteLab;
            tbRcs.Text = info.RCSLab1;
            tbSiret.Text = info.SiretLab1;
            tbApe.Text = info.APELab1;

        }

        private void btnSubmitInfoLab_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text;
            string adresse = tbAdresse.Text;
            string cp = tbCp.Text;
            string ville = tbVille.Text;
            string tel = tbTel.Text;
            string fax = tbFax.Text;
            string type = tbType.Text;
            string rcs = tbRcs.Text;
            string siret = tbSiret.Text;
            string ape = tbApe.Text;

            InfoManager infoManager = new InfoManager();
            int test = infoManager.updateInfo(nom, adresse, cp, ville, tel, fax, type, rcs, siret, ape);

            if(test == 1)
            {
                lbMessageErreur.Text = "Info modifié !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbMessageErreur.Text = "Info non modifié !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
