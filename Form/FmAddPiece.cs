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
    public partial class FmAddPiece : Form
    {

        public FmAddPiece()
        {
            InitializeComponent();
        }

        public FmAddPiece(Client client, Marque marque, Modele modele, DateTime dateAchat, string commentaire, int dureeReparation, string numSerie)
        {
            InitializeComponent();

            lbIdClient.Text = client.IdClt.ToString();
            lbNomClient.Text = client.NomClt;
            lbPrenomClient.Text = client.PrenomClt;
            lbAdresseClient.Text = client.AdresseClt;
            lbCpClient.Text = client.CpClt;
            lbVilleClient.Text = client.VilleClt;
            lbEmailClient.Text = client.AdresseMailClt;
            lbTelClient.Text = client.TelClt;

            lbIdMarque.Text = marque.IdMarque.ToString();
            lbNomMarque.Text = marque.NomMarque;

            lbIdModele.Text = modele.IdModele.ToString();
            lbNomModele.Text = modele.NomModele;

            rtbCommentaire.Text = commentaire;

            datetimeDateAchat.Value = dateAchat;

            lbDureeReparation.Text = dureeReparation.ToString();

            lbNumSerie.Text = numSerie;
            
        }

        private void FmAddPiece_Load(object sender, EventArgs e)
        {
            PieceDetacheeManager pieceDetacheeManager = new PieceDetacheeManager();
            List<PieceDetachee> pieceDetacheeCollection = new List<PieceDetachee>();

            pieceDetacheeCollection = pieceDetacheeManager.readAllPieceDetachee();

            List<PieceDetachee> pieceDetachees = new List<PieceDetachee>();

            for(int i = 0; i< pieceDetacheeCollection.Count(); i++)
            {
                pieceDetachees.Add(new PieceDetachee(pieceDetacheeCollection[i].IdPieceDet, pieceDetacheeCollection[i].NomPieceDet, pieceDetacheeCollection[i].PrixUnitairePieceDet, pieceDetacheeCollection[i].StockPieceDet));
            }


            cbPieceDet.DisplayMember = "nomPieceDet";
            cbPieceDet.ValueMember = "idPieceDet";
            cbPieceDet.DataSource = pieceDetachees;
            lbId.Text = ((PieceDetachee)cbPieceDet.SelectedItem).IdPieceDet.ToString();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {


            if (Int32.TryParse(tbNombre.Text, out int value))
            {

                double nombrePiece = Double.Parse(tbNombre.Text);
                double prixUnitaire = Double.Parse(tbPrixUnitaire.Text);
                double stock = Double.Parse(tbStock.Text);
                double total = nombrePiece * prixUnitaire;


                if(nombrePiece == 0)
                {
                    btnAddPiece.Enabled = false;
                }
                else if (nombrePiece > stock)
                {
                    btnAddPiece.Enabled = false;
                }
                else
                {
                    btnAddPiece.Enabled = true;
                    tbCoutTotal.Text = total.ToString();

                }

            }
            else
            {
                btnAddPiece.Enabled = false;
            }


        }

        private void cbPieceDet_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PieceDetacheeManager pieceDetacheeManager = new PieceDetacheeManager();

            int idPiece = ((PieceDetachee)cbPieceDet.SelectedItem).IdPieceDet;

            lbId.Text = idPiece.ToString();
            tbCoutTotal.Text = "";
            tbNombre.Text = "";
            PieceDetachee piece = pieceDetacheeManager.readPiece(idPiece);

            tbPrixUnitaire.Text = piece.PrixUnitairePieceDet.ToString();
            tbStock.Text = piece.StockPieceDet.ToString();
            if (piece.StockPieceDet < 1)
            {
                btnAddPiece.Enabled = false;
            }
            else
            {
                btnAddPiece.Enabled = true;
            }

        }

        private void btnAddPiece_Click(object sender, EventArgs e)
        {
            int idPiece = Int32.Parse(lbId.Text);
            int index = 999;

            if (tbNombre.Text != "0")
            {


                if (tbCoutTotal.Text != "" && tbNombre.Text != "" && lbId.Text != "")
                {
                    string nomPiece = ((PieceDetachee)cbPieceDet.SelectedItem).NomPieceDet;
                    int nombre = Int32.Parse(tbNombre.Text);
                    int resteStock = Int32.Parse(tbStock.Text) - Int32.Parse(tbNombre.Text);
                    double prix = Double.Parse(tbCoutTotal.Text);
                    
                    if (nombre > Int32.Parse(tbStock.Text))
                    {
                        lbMessageError.Text = "Pas assez de stocks !";
                        lbMessageError.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        lbMessageError.Text = "Stock suffisant !";
                        lbMessageError.ForeColor = System.Drawing.Color.Green;
                        tbStock.Text = resteStock.ToString();

                        if(dataGridViewPieceDeta.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow row in dataGridViewPieceDeta.Rows)
                            {
                                int valeurIdPiece = Int32.Parse(row.Cells[0].Value.ToString());

                                if (row.Cells[0].Value.ToString().Contains(idPiece.ToString()))
                                {
                                    index = row.Index;
                                    Console.WriteLine("Ligne : " + row.Index);
                                    Console.WriteLine("Id : " + valeurIdPiece);

                                }
                                else
                                {
                                    Console.WriteLine(row.Index);
                                    Console.WriteLine("Id : " + valeurIdPiece);

                                }
                            }

                            if(index != 999)
                            {
                                int valeurNombre = Int32.Parse(dataGridViewPieceDeta.Rows[index].Cells[2].Value.ToString());
                                dataGridViewPieceDeta.Rows[index].Cells[2].Value = valeurNombre + nombre;
                                double valeurPrix = Double.Parse(dataGridViewPieceDeta.Rows[index].Cells[3].Value.ToString());
                                dataGridViewPieceDeta.Rows[index].Cells[3].Value = prix + valeurPrix;
                            }
                            else
                            {
                                dataGridViewPieceDeta.Rows.Add(idPiece, nomPiece, nombre, Double.Parse(tbCoutTotal.Text));

                            }

                        }
                        else{
                            dataGridViewPieceDeta.Rows.Add(idPiece, nomPiece, nombre, Double.Parse(tbCoutTotal.Text));
                        }

                    }
                }
                else
                {
                    lbMessageError.Text = "Les champs ne sont pas remplis !";
                    lbMessageError.ForeColor = System.Drawing.Color.Red;
                   
                }
            }
            else
            {
                lbMessageError.Text = "La quantité ne peut pas être inférieur à 1 !";
                lbMessageError.ForeColor = System.Drawing.Color.Red;
            }

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

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmFicheEnd");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
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

                Client client = new Client(Int32.Parse(lbIdClient.Text), lbNomClient.Text, lbPrenomClient.Text, lbAdresseClient.Text, lbCpClient.Text, lbVilleClient.Text, lbEmailClient.Text, lbTelClient.Text);
                
                Modele modele = new Modele(Int32.Parse(lbIdModele.Text), lbNomModele.Text);
                Marque marque = new Marque(Int32.Parse(lbIdMarque.Text), lbNomMarque.Text);

                DateTime dateAchat = datetimeDateAchat.Value;

                string commentaire = rtbCommentaire.Text;

                int dureeReparation = Int32.Parse(lbDureeReparation.Text);

                string numSerie = lbNumSerie.Text;

                FmFicheEnd fLc = new FmFicheEnd(client, marque, modele, dateAchat, commentaire, pieceCollection, dureeReparation, numSerie);

                fLc.MdiParent = this.MdiParent;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
            
        }
    }
}
