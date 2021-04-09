using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB7.Component;
using LAB7.Manager;

namespace LAB7
{
    public partial class FmAcceuil : Form
    {
        //Initialisation du Form
        public FmAcceuil()
        {
            InitializeComponent();
        }

        //Méthode pour vérifier si un Form est instancié
        public Form VerifOpenForm(string nomForm)
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


        //Au chargement du formulaire ajoute les valeurs dans le combobox de filtre
        private void FmAcceuil_Load(object sender, EventArgs e)
        {
            cbBoxFiltreCritere.Items.Add("Numéro de fiche");
            cbBoxFiltreCritere.Items.Add("Nom");
            cbBoxFiltreCritere.Items.Add("Statut");
            cbBoxFiltreCritere.Items.Add("Date");
            cbBoxFiltreCritere.SelectedIndex = 0;
            DisplayData();


        }

        //Méthode se déclenchent au click d'un boutton dans le datagridview
        private void dgvListeFiche_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListeFiche.Columns["btnVisualise"].Index && e.RowIndex >= 0)
            {
                Console.WriteLine("affichage");

                Form fmVerif = VerifOpenForm("FmPreviewFiche");

                if (fmVerif != null)
                {
                    fmVerif.Close();
                    FmPreviewFiche fLc = new FmPreviewFiche(Int32.Parse(dgvListeFiche.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    fLc.Dock = DockStyle.Fill;
                    fmVerif.Text = "Prévisualisation de la fiche n°" + dgvListeFiche.Rows[e.RowIndex].Cells[0].Value.ToString();
                    fLc.Show();

                }
                else
                {
                    FmPreviewFiche fLc = new FmPreviewFiche(Int32.Parse(dgvListeFiche.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    fLc.Dock = DockStyle.Fill;
                    fLc.Text = "Prévisualisation de la fiche n°" + dgvListeFiche.Rows[e.RowIndex].Cells[0].Value.ToString();
                    fLc.Show();
                }

            }

            if (e.ColumnIndex == dgvListeFiche.Columns["btnDownload"].Index && e.RowIndex >= 0)
            {
                Console.WriteLine("download");
                CreatePDF createPDF = new CreatePDF();
                if (createPDF.constructPDF(Int32.Parse(dgvListeFiche.Rows[e.RowIndex].Cells[0].Value.ToString())))
                {
                    MessageBox.Show("Le PDF à été téléchargé !");
                }
                else
                {
                    MessageBox.Show("Le PDF n'a pas été téléchargé !");

                }
            }

            if (e.ColumnIndex == dgvListeFiche.Columns["btnTransformDevis"].Index && e.RowIndex >= 0)
            {
                Console.WriteLine("devis");
                FicheManager ficheManager = new FicheManager();

                if (dgvListeFiche.Rows[e.RowIndex].Cells[3].Value.ToString() == "Fiche de réparation")
                {
                    if (ficheManager.updateFicheDevis(Int32.Parse(dgvListeFiche.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Fiche transformé en devis !");
                        DisplayData();

                    }
                    else
                    {
                        MessageBox.Show("Fiche non transformé en devis !");

                    }
                }
                else
                {
                    MessageBox.Show("Impossible, le statut doit être 'Fiche de réparation' !");
                }



            }

            if (e.ColumnIndex == dgvListeFiche.Columns["btnTransformFacture"].Index && e.RowIndex >= 0)
            {

                Console.WriteLine("facture");
                FicheManager ficheManager = new FicheManager();

                if (dgvListeFiche.Rows[e.RowIndex].Cells[3].Value.ToString() == "Devis")
                {

                    if (ficheManager.updateFicheFacture(Int32.Parse(dgvListeFiche.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Fiche transformé en facture !");
                        DisplayData();

                    }
                    else
                    {
                        MessageBox.Show("Fiche non transformé en facture !");

                    }
                }
                else
                {
                    MessageBox.Show("Impossible, le statut doit être 'Devis' !");
                }
            }

            if (e.ColumnIndex == dgvListeFiche.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                Console.WriteLine("delete");

                FicheManager ficheManager = new FicheManager();
                if (ficheManager.deleteFiche(Int32.Parse(dgvListeFiche.Rows[e.RowIndex].Cells[0].Value.ToString())))
                {

                    FicheAsPieceDetManager ficheAsPieceDetManager = new FicheAsPieceDetManager();

                    if (ficheAsPieceDetManager.deleteFicheHasPieceDet(Int32.Parse(dgvListeFiche.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Fiche supprimé avec succés !");
                        DisplayData();
                        
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la suppression de la fiche !");
                    }

                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression de la fiche !");

                }

            }

            if (e.ColumnIndex == dgvListeFiche.Columns["btnRefus"].Index && e.RowIndex >= 0)
            {

                Console.WriteLine("refus");

                FicheManager ficheManager = new FicheManager();

                if (dgvListeFiche.Rows[e.RowIndex].Cells[3].Value.ToString() == "Devis")
                {

                    if (ficheManager.updateFicheFacture(Int32.Parse(dgvListeFiche.Rows[e.RowIndex].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Fiche transformé en facture !");
                        DisplayData();

                    }
                    else
                    {
                        MessageBox.Show("Fiche non transformé en facture !");

                    }
                }
                else
                {
                    MessageBox.Show("Impossible, le statut doit être 'Devis' !");
                }

            }

            if (e.ColumnIndex == dgvListeFiche.Columns["btnAccepter"].Index && e.RowIndex >= 0)
            {

                Console.WriteLine("accepter");

            }
        }

        //Méthode qui va afficher toutes les fiches de réparation dans le datagridview
        public void DisplayData()
        {
            dgvListeFiche.Rows.Clear();
            //On récupère le nombre de fiche à l'aide d'un COUNT dans la base de donnée
            FicheManager ficheManager = new FicheManager();

            int nbFiche = ficheManager.countFiche();

            lbTitleAccueil.Text = nbFiche.ToString();

            //Si il y a des fiches on les listes
            if (nbFiche > 0)
            {
                lbTitleAccueil.Text = "Il existe " + nbFiche + " fiche(s) de réparation !";
                dgvListeFiche.Visible = true;

                List<FicheDeReparation> ficheDeReparations = new List<FicheDeReparation>();
                ficheDeReparations = ficheManager.readAllFiche();

                foreach (FicheDeReparation ficheDeReparation in ficheDeReparations)
                {
                    ClientManager clientManager = new ClientManager();
                    Client clt = clientManager.readClient(ficheDeReparation.Client.IdClt);
                    string nomClt = clt.fullNameClt;

                    dgvListeFiche.Rows.Add(ficheDeReparation.IdFiche, nomClt, ficheDeReparation.TTC1 + " €", ficheDeReparation.SousStatut);

                }

                foreach (DataGridViewRow row in dgvListeFiche.Rows)
                {
                    DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)row.Cells[7];


                    if ((string)row.Cells[3].Value == "En attente d'examen")
                    {

                        cbCell.Items.Add("En attente d'accord client");

                    }

                    if ((string)row.Cells[3].Value == "En attente d'accord client")
                    {

                        cbCell.Items.Add("En attente de traitement");
                        cbCell.Items.Add("Refusé");

                    }

                    if ((string)row.Cells[3].Value == "En attente de traitement")
                    {

                        cbCell.Items.Add("En attente de règlement");

                    }

                    if ((string)row.Cells[3].Value == "En attente de règlement")
                    {

                        cbCell.Items.Add("Réglée");

                    }

                    if ((string)row.Cells[3].Value == "Réglée")
                    {
                        cbCell.Items.Add("Archivée");
                    }

                    if ((string)row.Cells[3].Value == "Archivée")
                    {
                        cbCell.Items.Add("Aucune action n'est disponible");
                    }

                    if ((string)row.Cells[3].Value == "Refusé")
                    {
                        cbCell.Items.Add("Archivée");
                    }

                }

            }
            else
            {
                lbTitleAccueil.Text = "Il n'y a aucune fiche de réparation !";
                dgvListeFiche.Visible = false;
            }
        }

        //Changement de valeur de la combobox qui mets visible ou non un datapicker
        private void cbBoxFiltreCritere_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string choix = (cbBoxFiltreCritere.SelectedItem).ToString();

            if(choix == "Date")
            {
                dtpDate.Visible = true;
                tbSearch.Enabled = false;

            }
            else
            {
                dtpDate.Visible = false;
                tbSearch.Enabled = true;

            }

        }

        //Méthode pour afficher les fiches selon un filtre
        private void btnFiltre_Click(object sender, EventArgs e)
        {
            string cibleFiltre = (cbBoxFiltreCritere.SelectedItem).ToString();

            
            if (tbSearch.Text.Length > 0 && tbSearch.Enabled == true)
            {

                string valeurFiltre = tbSearch.Text.ToString();
                Console.WriteLine(valeurFiltre);

                FicheManager ficheManager = new FicheManager();
                List<FicheDeReparation> ficheDeReparations = new List<FicheDeReparation>();

                ficheDeReparations = ficheManager.readFiltreFiche(cibleFiltre, valeurFiltre);

                if (ficheDeReparations != null)
                {
                    lbTitleAccueil.Text = ficheDeReparations.Count + " résultat(s)";
                    dgvListeFiche.Rows.Clear();

                    foreach (FicheDeReparation ficheDeReparation in ficheDeReparations)
                    {
                        ClientManager clientManager = new ClientManager();
                        Client clt = clientManager.readClient(ficheDeReparation.Client.IdClt);
                        string nomClt = clt.fullNameClt;

                        dgvListeFiche.Rows.Add(ficheDeReparation.IdFiche, nomClt, ficheDeReparation.TTC1 + " €", ficheDeReparation.SousStatut);

                    }
                }
                else
                {
                    lbTitleAccueil.Text = "Aucun résultat";
                    DisplayData();
                }


                lbMessageError.Text = "Recherche effectué ! ";
                lbMessageError.ForeColor = System.Drawing.Color.Green;

            }
            else if (tbSearch.Enabled == false)
            {
                string valeurFiltre = dtpDate.Value.ToString();

                FicheManager ficheManager = new FicheManager();
                List<FicheDeReparation> ficheDeReparations = new List<FicheDeReparation>();

                ficheDeReparations = ficheManager.readFiltreFiche(cibleFiltre, valeurFiltre);

                if (ficheDeReparations != null)
                {
                    lbTitleAccueil.Text = ficheDeReparations.Count + " résultat(s)";
                    dgvListeFiche.Rows.Clear();

                    foreach (FicheDeReparation ficheDeReparation in ficheDeReparations)
                    {
                        ClientManager clientManager = new ClientManager();
                        Client clt = clientManager.readClient(ficheDeReparation.Client.IdClt);
                        string nomClt = clt.fullNameClt;

                        dgvListeFiche.Rows.Add(ficheDeReparation.IdFiche, nomClt, ficheDeReparation.TTC1 + " €", ficheDeReparation.Statut);

                    }
                }
                else
                {
                    lbTitleAccueil.Text = "Aucun résultat";
                    DisplayData();
                }

                lbMessageError.Text = "Recherche effectué ! ";
                lbMessageError.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbMessageError.Text = "Vérifier l'entrée utilisateur ! ";
                lbMessageError.ForeColor = System.Drawing.Color.Red;
            }
        }


        //Méthode qui affiche toutes les fiches
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        //Changement de la valeur de la combobox dans le datagridview
        private void comboInDgv_SelectionIndexChanged(object sender, EventArgs e)
        {

            string valeurSelection = (sender as ComboBox).SelectedItem.ToString();
            int idFiche = (int)dgvListeFiche.CurrentRow.Cells["numFiche"].Value;

            if(valeurSelection != "Aucune action n'est disponible")
            {
                FicheManager ficheManager = new FicheManager();

                if(valeurSelection == "En attente d'accord client" || valeurSelection == "En attente de traitement")
                {
                    ficheManager.updateFicheDevis(idFiche);
                }

                if(valeurSelection == "En attente de règlement" || valeurSelection == "Réglée" || valeurSelection == "Refusé" || valeurSelection == "Archivée")
                {
                    ficheManager.updateFicheFacture(idFiche);
                }

                if (ficheManager.updateFicheSousStatut(idFiche, valeurSelection))
                {
                    lbMessageError.Text = "Statut modifié ! ";
                    lbMessageError.ForeColor = System.Drawing.Color.Green;
                    DisplayData();
                }
                else
                {
                    lbMessageError.Text = "Statut non modifié ! ";
                    lbMessageError.ForeColor = System.Drawing.Color.Red;
                }

            }

        }

        //Changement de la valeur de la combobox dans le datagridview
        private void dgvListeFiche_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            var combo = e.Control as ComboBox;
            if(combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(comboInDgv_SelectionIndexChanged);
                combo.SelectedIndexChanged += comboInDgv_SelectionIndexChanged;
            }
        }
    }
}
