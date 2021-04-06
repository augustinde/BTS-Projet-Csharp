using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB7
{
    public partial class FmGestionEmploye : Form
    {
        public FmGestionEmploye()
        {
            InitializeComponent();
        }

        private void FmGestionEmploye_Load(object sender, EventArgs e)
        {

            UpdateDataGrid();
           
        }

        private void btnDeleteCurrent_Click(object sender, EventArgs e)
        {
            tbId.Text = "";
            tbMdp.Text = "";
            tbNomUser.Text = "";
            btnSubmit.Enabled = true;
        }

        public void UpdateDataGrid()
        {

            dgvListeEmploye.Rows.Clear();
            EmployeManager employeManager = new EmployeManager();

            List<Employe> employes = new List<Employe>();
            employes = employeManager.readAllEmploye();

            foreach (Employe employe in employes)
            {

                dgvListeEmploye.Rows.Add(employe.IdEmploye, employe.MotDePasse, employe.NomUtilisateur, employe.Fonction, employe.Actif);

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nomUser = tbNomUser.Text;
            string mdp = tbMdp.Text;
            string fonction = cbFonction.Text;

            if (nomUser.Length > 0 && mdp.Length > 0 && fonction.Length > 0)
            {

                //Hashage du mot de passe
                using (SHA256 sha256Hash = SHA256.Create())
                {

                    string hashMdp = GetHash(sha256Hash, mdp);

                    EmployeManager employeManager = new EmployeManager();
                    int test = employeManager.createEmploye(hashMdp, nomUser, fonction);

                    if (test == 1)
                    {
                        lbMessageError.Text = "Employé ajouté !";
                        lbMessageError.ForeColor = System.Drawing.Color.Green;
                        UpdateDataGrid();

                    }
                    else
                    {
                        lbMessageError.Text = "Employé non ajouté !";
                        lbMessageError.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            else
            {
                lbMessageError.Text = "Les champs sont vides !";
                lbMessageError.ForeColor = System.Drawing.Color.Red;
            }
        }


        //Fonction qui créé le hashage du mot de passe
        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            //Convertis le string en tableau de byte
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            //Création d'un nouveau Stringbuilder
            var sBuilder = new StringBuilder();

            //Boucle qui parcours le tableau de byte et le formate en hexa 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            //Retourne le string hexadecimal
            return sBuilder.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbId.Text != null)
            {

                int.TryParse(tbId.Text, out int idEmploye);
                string nomUser = tbNomUser.Text;
                string mdp = tbMdp.Text;
                string fonction = cbFonction.Text;

                //Hashage du mot de passe
                using (SHA256 sha256Hash = SHA256.Create())
                {

                    string hashMdp = GetHash(sha256Hash, mdp);

                    EmployeManager employeManager = new EmployeManager();
                    int test = employeManager.updateEmploye(idEmploye, nomUser, hashMdp, fonction);

                    if (test == 1)
                    {
                        lbMessageError.Text = "Employé modifié !";
                        lbMessageError.ForeColor = System.Drawing.Color.Green;
                        UpdateDataGrid();

                    }
                    else
                    {
                        lbMessageError.Text = "Employé non modifié !";
                        lbMessageError.ForeColor = System.Drawing.Color.Red;
                    }
                }

            }
        }

        private void dgvListeEmploye_SelectionChanged(object sender, EventArgs e)
        {
            tbId.Text = dgvListeEmploye.CurrentRow.Cells[0].Value.ToString();
            tbMdp.Text = dgvListeEmploye.CurrentRow.Cells[1].Value.ToString();
            tbNomUser.Text = dgvListeEmploye.CurrentRow.Cells[2].Value.ToString();
            cbFonction.Text = dgvListeEmploye.CurrentRow.Cells[3].Value.ToString();
            btnSubmit.Enabled = false;
        }

        private void dgvListeEmploye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListeEmploye.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {

                int.TryParse(tbId.Text, out int idEmploye);

                EmployeManager employeManager = new EmployeManager();

                int test = employeManager.deleteEmploye(idEmploye);

                if (test == 1)
                {
                    lbMessageError.Text = "Employé supprimé !";
                    lbMessageError.ForeColor = System.Drawing.Color.Green;
                    tbId.Text = "";
                    tbId.Text = "";
                    tbMdp.Text = "";
                    tbNomUser.Text = "";
                    UpdateDataGrid();


                }
                else
                {
                    lbMessageError.Text = "Employé non supprimé !";
                    lbMessageError.ForeColor = System.Drawing.Color.Red;
                }

            }

            if (e.ColumnIndex == dgvListeEmploye.Columns["btnActiver"].Index && e.RowIndex >= 0)
            {
                int.TryParse(tbId.Text, out int idEmploye);
                EmployeManager employeManager = new EmployeManager();

                int test = employeManager.updateActiverEmploye(idEmploye);
                if (test == 1)
                {
                    lbMessageError.Text = "Accés pour l'employé activer !";
                    lbMessageError.ForeColor = System.Drawing.Color.Green;
                    tbId.Text = "";
                    tbId.Text = "";
                    tbMdp.Text = "";
                    tbNomUser.Text = "";
                    UpdateDataGrid();


                }
                else
                {
                    lbMessageError.Text = "Erreur lors de l'activation de l'accés !";
                    lbMessageError.ForeColor = System.Drawing.Color.Red;
                }
            }

            if (e.ColumnIndex == dgvListeEmploye.Columns["btnDesactiver"].Index && e.RowIndex >= 0)
            {
                int.TryParse(tbId.Text, out int idEmploye);
                EmployeManager employeManager = new EmployeManager();

                int test = employeManager.updateDesactiverEmploye(idEmploye);
                if (test == 1)
                {
                    lbMessageError.Text = "Accés pour l'employé désactiver !";
                    lbMessageError.ForeColor = System.Drawing.Color.Green;
                    tbId.Text = "";
                    tbId.Text = "";
                    tbMdp.Text = "";
                    tbNomUser.Text = "";
                    UpdateDataGrid();


                }
                else
                {
                    lbMessageError.Text = "Erreur lors de la désactivation de l'accés !";
                    lbMessageError.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
