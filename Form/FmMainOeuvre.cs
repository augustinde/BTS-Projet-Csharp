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
    public partial class FmMainOeuvre : Form
    {
        public FmMainOeuvre()
        {
            InitializeComponent();
        }

        private void FmMainOeuvre_Load(object sender, EventArgs e)
        {


            MainOeuvreManager mainOeuvreManager = new MainOeuvreManager();
            List<MainOeuvre> mainOeuvreCollection = new List<MainOeuvre>();
            mainOeuvreCollection = mainOeuvreManager.readAllMontant();

            List<MainOeuvre> mainOeuvres = new List<MainOeuvre>();

            for (int i = 0; i < mainOeuvreCollection.Count(); i++)
            {
                mainOeuvres.Add(new MainOeuvre(mainOeuvreCollection[i].IdMainOeuvre, mainOeuvreCollection[i].MontantMainOeuvre, mainOeuvreCollection[i].Actif));
            }

            cbListMontantMO.DisplayMember = "montantMainOeuvre";
            cbListMontantMO.ValueMember = "idMainOeuvre";
            cbListMontantMO.DataSource = mainOeuvres;

            MainOeuvre mainOeuvreActif = new MainOeuvre();
            mainOeuvreActif = mainOeuvreManager.readMainOeuvreActif();
            lbMontantMOActif.Text = mainOeuvreActif.MontantMainOeuvre.ToString();


            
        }

        private void btnActiverTaux_Click(object sender, EventArgs e)
        {
            double taux = ((MainOeuvre)cbListMontantMO.SelectedItem).MontantMainOeuvre;
            int idMontant = ((MainOeuvre)cbListMontantMO.SelectedItem).IdMainOeuvre;

            MainOeuvreManager mainOeuvreManager = new MainOeuvreManager();

            int test = mainOeuvreManager.activeMontant(idMontant);

            if (test == 1)
            {
                lbMessageErreur.Text = "Montant actif modifié !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
                lbMontantMOActif.Text = taux.ToString();
            }
            else
            {
                lbMessageErreur.Text = "Montant actif non modifié !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }


        }

        private void btnSubmitCreateMontantMO_Click(object sender, EventArgs e)
        {
            MainOeuvreManager mainOeuvreManager = new MainOeuvreManager();
            double montantMainOeuvre = double.Parse(tbCreateMontantMO.Text);

            int test = mainOeuvreManager.createMainOeuvre(montantMainOeuvre);
            if (test == 1)
            {
                lbMessageErreur.Text = "Montant ajouté !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
                FmMainOeuvre_Load(sender, e);
            }
            else
            {
                lbMessageErreur.Text = "Montant non ajouté !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}
