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
    public partial class FmFicheEnd : Form
    {

        public FmFicheEnd()
        {
            InitializeComponent();
        }

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


        public FmFicheEnd(Client client, Marque marque, Modele modele, DateTime dateAchat, string commentaire, List<FicheAsPieceDet> pieceDetachees, int dureeReparation, string numSerie)
        {
            double ht = 0, ttc = 0, surplusTVA = 0;

            InitializeComponent();
            tbNomClt.Text = client.NomClt;
            tbPnomClt.Text = client.PrenomClt;
            tbTelClt.Text = client.TelClt;
            tbEmailClt.Text = client.AdresseMailClt;
            tbAdresseClt.Text = client.AdresseClt;
            tbCpClt.Text = client.CpClt;
            tbVilleClt.Text = client.VilleClt;
            tbIdClt.Text = client.IdClt.ToString();
            
            tbMarque.Text = marque.NomMarque;
            lbIdMarque.Text = marque.IdMarque.ToString();

            tbModele.Text = modele.NomModele;
            lbIdModele.Text = modele.IdModele.ToString();

            rtbCommentaire.Text = commentaire;
            dtDateAchat.Value = dateAchat;

            tbNumSerie.Text = numSerie;

            //dataGridViewPieceDeta.DataSource = pieceDetachees;
            foreach (FicheAsPieceDet ficheAsPieceDet in pieceDetachees)
            {
                dataGridViewPieceDeta.Rows.Add(ficheAsPieceDet.IdPieceDet, ficheAsPieceDet.NomPiece, ficheAsPieceDet.Quantite, ficheAsPieceDet.PrixTotal);
                ht += ficheAsPieceDet.PrixTotal;
            }

            TvaManager tvaManager = new TvaManager();
            Tva tva = tvaManager.readTvaActif();

            MainOeuvreManager mainOeuvreManager = new MainOeuvreManager();
            MainOeuvre mainOeuvre = mainOeuvreManager.readMainOeuvreActif();

            ht = ht + mainOeuvre.MontantMainOeuvre * dureeReparation;
            surplusTVA = ht * tva.MontantTva / 100;
            ttc = ht + surplusTVA;

            tbHT.Text = ht.ToString() + " €";
            tbPrixTotal.Text = ttc.ToString() + " €";
            tbDureeReparation.Text = dureeReparation.ToString();

        }

        private void btSubmitFiche_Click(object sender, EventArgs e)
        {
            //DateTime dateAchat, Modele modele, Marque marque, string commentaire, int dureeRep, Statut statut, Client client

            DateTime dateAchat = dtDateAchat.Value;
            Modele modele = new Modele(Int32.Parse(lbIdModele.Text), tbModele.Text);
            Marque marque = new Marque(Int32.Parse(lbIdMarque.Text), tbMarque.Text);
            string commentaire = rtbCommentaire.Text;
            int dureeRep = Int32.Parse(tbDureeReparation.Text);
            string statut = "Fiche de réparation";
            Client client = new Client(Int32.Parse(tbIdClt.Text), tbNomClt.Text, tbPnomClt.Text, tbAdresseClt.Text, tbCpClt.Text, tbVilleClt.Text, tbEmailClt.Text, tbTelClt.Text);
            string numSerie = tbNumSerie.Text.ToString();

            List<FicheAsPieceDet> pieceCollection = new List<FicheAsPieceDet>();

            foreach (DataGridViewRow row in dataGridViewPieceDeta.Rows)
            {
                FicheAsPieceDet ficheHasPiece = new FicheAsPieceDet();
                ficheHasPiece.IdPieceDet = Int32.Parse(row.Cells[0].Value.ToString());
                ficheHasPiece.NomPiece = row.Cells[1].Value.ToString();
                ficheHasPiece.Quantite = Int32.Parse(row.Cells[2].Value.ToString());
                ficheHasPiece.PrixTotal = Double.Parse(row.Cells[3].Value.ToString());
                pieceCollection.Add(ficheHasPiece);

            }

            FicheManager ficheManager = new FicheManager();
            long lastId = ficheManager.createFiche(dateAchat, modele, marque, commentaire, dureeRep, pieceCollection, statut, client, numSerie);

            if(lastId != -99)
            {
                int testSavePiece = ficheManager.createListPieceDet(pieceCollection, lastId);

                if (testSavePiece == 1)
                {

                    PieceDetacheeManager pieceDetacheeManager = new PieceDetacheeManager();
                       
                    foreach(FicheAsPieceDet ficheAsPieceDet in pieceCollection)
                    {
                        pieceDetacheeManager.updateStockAfterSaveFiche(ficheAsPieceDet.IdPieceDet, ficheAsPieceDet.Quantite);
                    }

                    lbMessageErreur.Text = "Fiche enregistré !";
                    lbMessageErreur.ForeColor = System.Drawing.Color.Green;

                    MessageBox.Show("Fiche enregistré !");

                    Form fmVerif = VerifOpenForm("FmAcceuil");

                    if (fmVerif != null)
                    {
                        fmVerif.Close();
                        FmAcceuil fLc = new FmAcceuil();
                        Form fmVerifAdmin = VerifOpenForm("FmAdmin");
                        fLc.MdiParent = fmVerifAdmin;
                        fLc.Dock = DockStyle.Fill;
                        fLc.Show();

                        if (Application.OpenForms["FmFicheEnd"] != null){
                            Application.OpenForms["FmFicheEnd"].Close();
                        }

                        if (Application.OpenForms["FmAddPiece"] != null)
                        {
                            Application.OpenForms["FmAddPiece"].Close();
                        }

                        if (Application.OpenForms["FmCreateFicheRepa"] != null)
                        {
                            Application.OpenForms["FmCreateFicheRepa"].Close();
                        }

                    }
                    else
                    {
                        FmAdmin fLc = new FmAdmin();
                        fLc.MdiParent = this;
                        fLc.Dock = DockStyle.Fill;
                        fLc.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Erreur lors de l'enregistrement de la fiche !");

                    lbMessageErreur.Text = "L'enregistrement des pièces à échoué !";
                    lbMessageErreur.ForeColor = System.Drawing.Color.Red;

                    ficheManager.deleteFiche(Int32.Parse(lastId.ToString()));
                }
            }
            else
            {
                MessageBox.Show("Erreur lors de l'enregistrement de la fiche !");

                lbMessageErreur.Text = "L'enregistrement de la fiche à échoué !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}
