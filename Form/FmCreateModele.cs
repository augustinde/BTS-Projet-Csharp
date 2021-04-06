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
    public partial class FmCreateModele : Form
    {
        public FmCreateModele()
        {
            InitializeComponent();
        }

        private void FmCreateModele_Load(object sender, EventArgs e)
        {

            MarqueManager marqueManager = new MarqueManager();
            List<Marque> marques = new List<Marque>();

            marques = marqueManager.readAllMarque();

            foreach(Marque marque in marques)
            {
                string infoMarque = marque.IdMarque + " - " + marque.NomMarque;
                comboxBoxMarque.Items.Add(infoMarque);
            }

        }

        private void btnSubmitModele_Click(object sender, EventArgs e)
        {
            string nomModele = tbNomModele.Text;
            int idMarque = Int32.Parse(comboxBoxMarque.Text[0].ToString());

            ModeleManager modeleManager = new ModeleManager();
            int test = modeleManager.createModele(nomModele, idMarque);
            if (test == 1)
            {
                lbModeleAjoute.Text = "Modèle ajouté !";
                lbModeleAjoute.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbModeleAjoute.Text = "Modèle non ajouté !";
                lbModeleAjoute.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
