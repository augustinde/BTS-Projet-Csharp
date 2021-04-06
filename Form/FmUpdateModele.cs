using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using LAB7.Manager;

namespace LAB7
{
    public partial class FmUpdateModele : Form
    {
        public FmUpdateModele()
        {
            InitializeComponent();
        }


        private void FmUpdateModele_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            ModeleManager cm = new ModeleManager();
            List<Modele> modeleCollection = new List<Modele>();
            modeleCollection = cm.readAllModele();


            List<Modele> modeles = new List<Modele>();

            for(int i = 0; i<modeleCollection.Count(); i++)
            {
                modeles.Add(new Modele(modeleCollection[i].IdModele, modeleCollection[i].NomModele));
            }

            comboBox1.DisplayMember = "nomModele";
            comboBox1.ValueMember = "idModele";
            comboBox1.DataSource = modeles;

        }





        private void btSubmitNumeroModele_Click(object sender, EventArgs e)
        {
            ModeleManager mm = new ModeleManager();
            Modele modele = mm.readModele(Int32.Parse(lbIdModele.Text));

            if (modele != null)
            {
                lbIdModele.Text = modele.IdModele.ToString();
                tbNomModele.Text = modele.NomModele;
                lbMessageErreur.Text = "Modèle récupéré !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbMessageErreur.Text = "Le modèle n'existe pas ou la requête n'a pas abouti !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btSupprimerModele_Click(object sender, EventArgs e)
        {
            ModeleManager modeleManager = new ModeleManager();
            int test = modeleManager.deleteModele(Int32.Parse(lbIdModele.Text.ToString()));

            if (test == 1)
            {
                lbMessageErreur.Text = "Modèle supprimé !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
                tbNomModele.Text = "";
            }
            else
            {
                lbMessageErreur.Text = "Modèle non supprimé !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btUpdateModele_Click(object sender, EventArgs e)
        {
            string nomModele = tbNomModele.Text;
            int idModele = Int32.Parse(lbIdModele.Text);

            ModeleManager modeleManager = new ModeleManager();
            int test = modeleManager.updateModele(idModele, nomModele);

            if (test == 1)
            {
                lbMessageErreur.Text = "Modèle modifié !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
                FmUpdateModele_Load(sender, e);
            }
            else
            {
                lbMessageErreur.Text = "Modèle non modifié !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbIdModele.Text = ((Modele)comboBox1.SelectedItem).IdModele.ToString();
        }
    }
}
