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
    public partial class FmUpdateMarque : Form
    {
        public FmUpdateMarque()
        {
            InitializeComponent();
        }

        private void btSubmitNumeroMarque_Click(object sender, EventArgs e)
        {
            MarqueManager mm = new MarqueManager();
            Marque marque = mm.readMarque(Int32.Parse(lbIdMarque.Text));

            if (marque != null)
            {
                lbIdMarque.Text = marque.IdMarque.ToString();
                tbNomMarque.Text = marque.NomMarque;
                lbMessageErreur.Text = "Marque récupéré !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbMessageErreur.Text = "La marque n'existe pas ou la requête n'a pas abouti !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btUpdateMarque_Click(object sender, EventArgs e)
        {
            string nomMarque = tbNomMarque.Text;
            int idMarque = Int32.Parse(lbIdMarque.Text);

            MarqueManager marqueManager = new MarqueManager();
            int test = marqueManager.updateMarque(idMarque, nomMarque);

            if (test == 1)
            {
                lbMessageErreur.Text = "Marque modifié !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
                FmUpdateMarque_Load(sender, e);
            }
            else
            {
                lbMessageErreur.Text = "Marque non modifié !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void btSupprimerMarque_Click(object sender, EventArgs e)
        {
            MarqueManager marqueManager = new MarqueManager();
            int test = marqueManager.deleteMarque(Int32.Parse(lbIdMarque.Text.ToString()));

            if(test == 1)
            {
                lbMessageErreur.Text = "Marque supprimé !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
                tbNomMarque.Text = "";
            }
            else
            {
                lbMessageErreur.Text = "Marque non supprimé !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void FmUpdateMarque_Load(object sender, EventArgs e)
        {
            MarqueManager marqueManager = new MarqueManager();
            List<Marque> marqueCollection = new List<Marque>();
            marqueCollection = marqueManager.readAllMarque();

            List<Marque> marques = new List<Marque>();

            for(int i = 0; i<marqueCollection.Count(); i++)
            {
                marques.Add(new Marque(marqueCollection[i].IdMarque, marqueCollection[i].NomMarque));
            }

            comboBox1.DisplayMember = "nomMarque";
            comboBox1.ValueMember = "idMarque";
            comboBox1.DataSource = marques;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbIdMarque.Text = ((Marque)comboBox1.SelectedItem).IdMarque.ToString();
        }
    }
}
