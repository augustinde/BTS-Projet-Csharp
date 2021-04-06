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
    public partial class FmPieceDeta : Form
    {
        public FmPieceDeta()
        {
            InitializeComponent();
        }

        private void FmPieceDeta_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
            cbBoxCritereFiltre.Items.Add("Identifiant");
            cbBoxCritereFiltre.Items.Add("Libelle");
            cbBoxCritereFiltre.Items.Add("Prix unitaire");
            cbBoxCritereFiltre.Items.Add("Stock");
            cbBoxCritereFiltre.SelectedIndex = 0;

        }

           
        public void UpdateDataGrid()
        {
            PieceDetacheeManager pieceManager = new PieceDetacheeManager();
            List<PieceDetachee> pieceDetachees = new List<PieceDetachee>();
            pieceDetachees = pieceManager.readAllPieceDetachee();

            dataGridViewPieceDeta.DataSource = pieceDetachees;
        }


        private void btnDeleteCurrent_Click(object sender, EventArgs e)
        {
            tbId.Text = "";
            tbLibellePiece.Text = "";
            tbPrixUnitaire.Text = "";
            tbStock.Text = "";
            btnSubmitAddPiece.Enabled = true;
            lbMessageError.Text = "";

        }

        private void btnSubmitAddPiece_Click(object sender, EventArgs e)
        {
            string nomPiece = tbLibellePiece.Text;
            double.TryParse(tbPrixUnitaire.Text, out double prixUnitaire);
            int.TryParse(tbStock.Text, out int stock);

            if (nomPiece.Length > 0 && prixUnitaire.ToString().Length > 0 && stock.ToString().Length > 0)
            {
                PieceDetacheeManager pieceDetacheeManager = new PieceDetacheeManager();
                int test = pieceDetacheeManager.createPieceDetachee(nomPiece, prixUnitaire, stock);

                if(test == 1)
                {
                    lbMessageError.Text = "Pièce détachée ajouté !";
                    lbMessageError.ForeColor = System.Drawing.Color.Green;
                    UpdateDataGrid();

                }
                else
                {
                    lbMessageError.Text = "Pièce détachée non ajouté !";
                    lbMessageError.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lbMessageError.Text = "Les champs sont vides !";
                lbMessageError.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void btnUpdatePiece_Click(object sender, EventArgs e)
        {
            if (tbId.Text != null)
            {

                int.TryParse(tbId.Text, out int idPiece);
                string nomPiece = tbLibellePiece.Text;
                double prixUnitaire = Double.Parse(tbPrixUnitaire.Text);
                int.TryParse(tbStock.Text, out int stock);

                PieceDetacheeManager pieceDetacheeManager = new PieceDetacheeManager();

                int test = pieceDetacheeManager.updatePieceDetachee(idPiece, nomPiece, prixUnitaire, stock);

                if (test == 1)
                {
                    lbMessageError.Text = "Pièce détachée modifié !";
                    lbMessageError.ForeColor = System.Drawing.Color.Green;
                    UpdateDataGrid();

                }
                else
                {
                    lbMessageError.Text = "Pièce détachée non modifié !";
                    lbMessageError.ForeColor = System.Drawing.Color.Red;
                }

            }
        }

        private void btnDeletePiece_Click(object sender, EventArgs e)
        {
            int.TryParse(tbId.Text, out int idPiece);

            PieceDetacheeManager pieceDetacheeManager = new PieceDetacheeManager();

            int test = pieceDetacheeManager.deletePieceDetachee(idPiece);

            if (test == 1)
            {
                lbMessageError.Text = "Pièce détachée supprimé !";
                lbMessageError.ForeColor = System.Drawing.Color.Green;
                tbId.Text = "";
                tbLibellePiece.Text = "";
                tbPrixUnitaire.Text = "";
                tbStock.Text = "";
                UpdateDataGrid();


            }
            else
            {
                lbMessageError.Text = "Pièce détachée non supprimé !";
                lbMessageError.ForeColor = System.Drawing.Color.Red;
            }


        }

        private void dataGridViewPieceDeta_SelectionChanged(object sender, EventArgs e)
        {
            tbId.Text = dataGridViewPieceDeta.CurrentRow.Cells[0].Value.ToString();
            tbLibellePiece.Text = dataGridViewPieceDeta.CurrentRow.Cells[1].Value.ToString();
            tbPrixUnitaire.Text = dataGridViewPieceDeta.CurrentRow.Cells[2].Value.ToString();
            tbStock.Text = dataGridViewPieceDeta.CurrentRow.Cells[3].Value.ToString();
            btnSubmitAddPiece.Enabled = false;
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            string cibleFiltre = (cbBoxCritereFiltre.SelectedItem).ToString();
            string valeurFiltre = tbSearch.Text.ToString();
            lbMessageFiltre.Text = cibleFiltre + " " + valeurFiltre;
            PieceDetacheeManager pieceDetacheeManager = new PieceDetacheeManager();
            List<PieceDetachee> pieceDetachees = new List<PieceDetachee>();

            pieceDetachees = pieceDetacheeManager.readFiltrePiece(cibleFiltre, valeurFiltre);

            if (pieceDetachees.Count() > 0)
            {
                dataGridViewPieceDeta.DataSource = pieceDetachees;
                lbMessageFiltre.Text = pieceDetachees.Count() + " résultat(s)";
                lbMessageFiltre.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbMessageFiltre.Text = "Aucun résultat";
                lbMessageFiltre.ForeColor = System.Drawing.Color.Red;
                UpdateDataGrid();
            }


        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void tbPrixUnitaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }
    }
}
