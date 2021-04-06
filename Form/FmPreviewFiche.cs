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

namespace LAB7
{
    public partial class FmPreviewFiche : Form
    {
        public FmPreviewFiche(int idFiche)
        {
            InitializeComponent();
            FicheManager ficheManager = new FicheManager();
            FicheDeReparation fiche = ficheManager.readFiche(idFiche);
            tbFullNameClt.Text = fiche.Client.fullNameClt;
            tbEmailClt.Text = fiche.Client.AdresseMailClt;
            tbAdresseClt.Text = fiche.Client.AdresseClt + ", " + fiche.Client.CpClt + " " + fiche.Client.VilleClt;
            tbTelClt.Text = fiche.Client.TelClt;
            tbStatut.Text = fiche.Statut;

            DateTime dateTest = new DateTime(2000, 01, 01, 00, 00, 00);

            if(fiche.DateDevis == dateTest)
            {
                lbDateDevis.Visible = false;
                dtDateDevis.Visible = false;
            }
            else
            {
                lbDateDevis.Visible = true;
                dtDateDevis.Visible = true;
                dtDateDevis.Value = fiche.DateDevis;
            }
            

            lbIdFiche.Text = "Fiche n°" + fiche.IdFiche;
            tbDureeReparation.Text = fiche.DureeReparation.ToString();
            rtbCommentaire.Text = fiche.Commentaire;
            tbTva.Text = fiche.TVA1.MontantTva.ToString();
            tbTTC.Text = fiche.TTC1.ToString();
            tbHT.Text = fiche.HT1.ToString();
            tbMainOeuvre.Text = fiche.MainOeuvre.MontantMainOeuvre.ToString();
            tbModele.Text = fiche.Modele.NomModele;
            tbMarque.Text = fiche.Marque.NomMarque;
            tbNumSerie.Text = fiche.NumSerie;

            FicheAsPieceDetManager ficheAsPieceDetManager = new FicheAsPieceDetManager();
            List<FicheAsPieceDet> pieceDetachees = ficheAsPieceDetManager.readAllPieceInFiche(idFiche);

            PieceDetacheeManager pieceDetacheeManager = new PieceDetacheeManager();

            foreach (FicheAsPieceDet ficheAsPieceDet in pieceDetachees)
            {
                PieceDetachee piece = pieceDetacheeManager.readPiece(ficheAsPieceDet.IdPieceDet);

                dgvPieceDet.Rows.Add(ficheAsPieceDet.IdPieceDet, piece.NomPieceDet, ficheAsPieceDet.Quantite, ficheAsPieceDet.PrixTotal);
            }


        }


    }
}
