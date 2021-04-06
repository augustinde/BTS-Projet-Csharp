using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB7
{
    public partial class FmTva : Form
    {
        public FmTva()
        {
            InitializeComponent();
        }

        private void FmTva_Load(object sender, EventArgs e)
        {

            TvaManager tvaManager = new TvaManager();
            List<Tva> tvaCollection = new List<Tva>();
            tvaCollection = tvaManager.readAllTva();

            List<Tva> tvas = new List<Tva>();

            for(int i = 0; i<tvaCollection.Count(); i++)
            {
                tvas.Add(new Tva(tvaCollection[i].IdTva, tvaCollection[i].MontantTva, tvaCollection[i].Actif));
            }

            cbListTva.DisplayMember = "montantTva";
            cbListTva.ValueMember = "idTva";
            cbListTva.DataSource = tvas;

            Tva tvaActif = new Tva();
            tvaActif = tvaManager.readTvaActif();
            lbTvaActif.Text = tvaActif.MontantTva.ToString();


        }

        private void btnSubmitCreateTva_Click(object sender, EventArgs e)
        {
            TvaManager tvaManager = new TvaManager();
            double montantTva = double.Parse(tbCreateTva.Text);

            int test = tvaManager.createTva(montantTva);
            if (test == 1)
            {
                lbMessageErreur.Text = "Tva ajouté !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
                FmTva_Load(sender, e);
            }
            else
            {
                lbMessageErreur.Text = "Tva non ajouté !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void btnActiverTaux_Click(object sender, EventArgs e)
        {
            double taux = ((Tva)cbListTva.SelectedItem).MontantTva;
            int idTaux = ((Tva)cbListTva.SelectedItem).IdTva;

            TvaManager tvaManager = new TvaManager();

            int test = tvaManager.activeTaux(idTaux);

            if (test == 1)
            {
                lbMessageErreur.Text = "Taux actif modifié !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
                lbTvaActif.Text = taux.ToString();
            }
            else
            {
                lbMessageErreur.Text = "Taux actif non modifié !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }


        }
    }
}
