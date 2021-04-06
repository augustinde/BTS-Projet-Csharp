using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB7.Component;
using iTextSharp;
using iTextSharp.text.pdf;
using LAB7.Manager;
using iTextSharp.text;

namespace LAB7.Component
{
    public class CreatePDF
    {

        /*
         * Propriété de l'objet CreatePDF
         */
        private FicheDeReparation ficheDeReparation;

        /*
         * Constructeurs de l'objet CreatePDF
         */
        public CreatePDF()
        {
             
        }

        public CreatePDF(FicheDeReparation ficheDeReparation)
        {
            this.ficheDeReparation = ficheDeReparation;

        }

        
        /*
         * Méthode qui créé le PDF
         */
        public bool constructPDF(int idFiche)
        {

            //read fiche
            FicheManager ficheManager = new FicheManager();
            FicheDeReparation fiche = ficheManager.readFiche(idFiche);

            string namePdf = fiche.Statut + "-" + fiche.IdFiche + "-" + fiche.Client.NomClt;
            //create PDF
            System.IO.FileStream fs = new System.IO.FileStream("../../"+namePdf+".pdf", System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None);
            Rectangle pageA4 = new Rectangle(PageSize.A4);
            Document document = new Document(pageA4);

            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();


            //create image
            var logo = iTextSharp.text.Image.GetInstance("../../assets/logoLab7.PNG");
            logo.ScaleAbsoluteHeight(100);
            logo.ScaleAbsoluteWidth(100);

            //read all marque
            MarqueManager marqueManager = new MarqueManager();
            List<Marque> marques = new List<Marque>();
            marques = marqueManager.readAllMarque();

            string marquesStr = "";

            for(int i = 0; i<marques.Count(); i++)
            {
                marquesStr += marques[i].NomMarque;
                if(i != marques.Count())
                {
                    marquesStr += " - ";
                }
            }


            //read info lab7
            InfoManager infoManager = new InfoManager();
            InfoLabSept info = infoManager.readInfo();

            string infoStr = 
                info.NomLab.ToUpper() + "\n" +
                info.AdresseLab.ToUpper() + "\n" +
                info.CpLab + " " + info.VilleLab.ToUpper() + "\n" +
                "TEL : " + info.TelLab + "\n" +
                "FAX : " + info.FaxLab;


            PdfPTable tableHeader = new PdfPTable(5);
            tableHeader.WidthPercentage = 100f;
            float[] widthCollFive = { 100, 20, 350, 20, 150 };
            tableHeader.SetWidths(widthCollFive);


            PdfPCell cell;
            cell = new PdfPCell(logo);
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableHeader.AddCell(cell);

            cell = new PdfPCell();
            cell.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableHeader.AddCell(cell);

            cell = new PdfPCell(new Paragraph(marquesStr));
            cell.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableHeader.AddCell(cell);

            cell = new PdfPCell();
            cell.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableHeader.AddCell(cell);

            cell = new PdfPCell(new Paragraph(infoStr));
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableHeader.AddCell(cell);
            
            //add table
            document.Add(tableHeader);

            DateTime dateTest = new DateTime(2000, 01, 01, 00, 00, 00);

            PdfPTable tableNumFiche = new PdfPTable(3);
            tableNumFiche.WidthPercentage = 100f;
            float[] widthColThree = { 200, 500, 200 };
            tableNumFiche.SetWidths(widthColThree);

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableNumFiche.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.Statut + " n°" + fiche.IdFiche));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidth = 1;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableNumFiche.AddCell(cell);

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableNumFiche.AddCell(cell);

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableNumFiche.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.SousStatut));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidth = 1;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableNumFiche.AddCell(cell);

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableNumFiche.AddCell(cell);


            //add table
            document.Add(tableNumFiche);

            //saut de ligne
            document.Add(new Paragraph("\n"));


            //table info client
            PdfPTable tableInfoClient = new PdfPTable(4);
            tableInfoClient.WidthPercentage = 100f;
            float[] widthCollFour = { 200, 200, 300, 200 };
            tableInfoClient.SetWidths(widthCollFour);

            DateTime dateInfo = new DateTime();

            if(fiche.Statut == "Devis")
            {
                dateInfo = fiche.DateDevis;
            }

            else
            {
                dateInfo = DateTime.Now;
            }


            //ligne 1
            cell = new PdfPCell(new Paragraph(dateInfo.Day.ToString() + "/" + dateInfo.Month.ToString() + "/" + dateInfo.Year.ToString()));
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell(new Paragraph("NOM"));
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.Client.fullNameClt));
            cell.BorderWidth = 1;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);


            //ligne 2

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell(new Paragraph("ADRESSE"));
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.Client.AdresseClt));
            cell.BorderWidth = 1;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);

            //ligne 3

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell(new Paragraph("CP + VILLE"));
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.Client.CpClt + " " + fiche.Client.VilleClt));
            cell.BorderWidth = 1;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);


            //ligne 4
            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell(new Paragraph("TELEPHONE"));
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.Client.TelClt));
            cell.BorderWidth = 1;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);

            //ligne 5
            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell(new Paragraph("EMAIL"));
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.Client.AdresseMailClt));
            cell.BorderWidth = 1;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoClient.AddCell(cell);

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            tableInfoClient.AddCell(cell);

            //add table
            document.Add(tableInfoClient);

            //saut de ligne
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph("\n"));

            Marque marque = marqueManager.readMarque(fiche.Marque.IdMarque);


            //table info produit
            PdfPTable tableInfoProduit = new PdfPTable(4);
            tableInfoProduit.WidthPercentage = 100f;
            float[] widthCollInfoProduit = { 200, 300, 200, 200 };
            tableInfoProduit.SetWidths(widthCollInfoProduit);


            //ligne 1
            cell = new PdfPCell(new Paragraph("MARQUE"));
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoProduit.AddCell(cell);

            cell = new PdfPCell(new Paragraph(marque.NomMarque));
            cell.BorderWidth = 1;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoProduit.AddCell(cell);

            cell = new PdfPCell(new Paragraph("MODELE"));
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoProduit.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.Modele.NomModele));
            cell.BorderWidth = 1;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoProduit.AddCell(cell);


            //ligne 2
            cell = new PdfPCell(new Paragraph("DATE D'ACHAT"));
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoProduit.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.DateAchat.Day.ToString() + "/" + fiche.DateAchat.Month.ToString() + "/" + fiche.DateAchat.Year.ToString()));
            cell.BorderWidth = 1;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoProduit.AddCell(cell);

            cell = new PdfPCell(new Paragraph("N° SERIE"));
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoProduit.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.NumSerie));
            cell.BorderWidth = 1;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoProduit.AddCell(cell);


            //ligne 3
            cell = new PdfPCell(new Paragraph("COMMENTAIRE"));
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableInfoProduit.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.Commentaire));
            cell.BorderWidth = 1;
            cell.Colspan = 3;
            cell.Padding = 5;
            tableInfoProduit.AddCell(cell);

            document.Add(tableInfoProduit);

            //saut de ligne
            document.Add(new Paragraph("\n"));

            if(fiche.Statut != "Facture")
            {
                //table phrase
                PdfPTable tablePhrase = new PdfPTable(4);
                tablePhrase.WidthPercentage = 100f;
                float[] widthCollPhrasee = { 200, 200, 300, 200 };
                tablePhrase.SetWidths(widthCollPhrasee);

                cell = new PdfPCell(new Paragraph("A la suite de l'examen de votre appareil, nous vous informons que le montant du devis de réparation (ce devis est valable 1 mois) s'élèverait approximativement à la somme de " + fiche.TTC1.ToString() + " euros dont le détail ci-dessous :" ));
                cell.BorderWidth = 0;
                cell.Colspan = 4;
                cell.Padding = 5;
                tablePhrase.AddCell(cell);

                document.Add(tablePhrase);
            }


            FicheAsPieceDetManager ficheAsPieceDetManager = new FicheAsPieceDetManager();
            List<FicheAsPieceDet> ficheAsPieceDets = new List<FicheAsPieceDet>();

            ficheAsPieceDets = ficheAsPieceDetManager.readAllPieceInFiche(fiche.IdFiche);

            //table liste pièces detachées
            PdfPTable tableListPieceDet = new PdfPTable(5);
            tableListPieceDet.WidthPercentage = 100f;
            float[] widthCollListProduit = { 100, 150, 90, 110, 100 };
            tableListPieceDet.SetWidths(widthCollListProduit);

            //ligne 1
            cell = new PdfPCell(new Paragraph("Référence"));
            cell.BorderWidth = 2;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Désignation"));
            cell.BorderWidth = 2;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Quantité"));
            cell.BorderWidth = 2;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Prix unitaire HT"));
            cell.BorderWidth = 2;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Montant"));
            cell.BorderWidth = 2;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            PieceDetacheeManager pieceDetacheeManager = new PieceDetacheeManager();

            //ligne supplémentaire
            foreach (FicheAsPieceDet ficheAsPiece in ficheAsPieceDets)
            {
                PieceDetachee pieceDetachee = pieceDetacheeManager.readPiece(ficheAsPiece.IdPieceDet);
                
                cell = new PdfPCell(new Paragraph(pieceDetachee.IdPieceDet.ToString()));
                cell.BorderWidthTop = 1;
                cell.BorderWidthBottom = 1;
                cell.BorderWidthRight = 1;
                cell.BorderWidthLeft = 2;
                cell.Colspan = 1;
                cell.Padding = 5;
                tableListPieceDet.AddCell(cell);

                cell = new PdfPCell(new Paragraph(pieceDetachee.NomPieceDet));
                cell.BorderWidth = 1;
                cell.Colspan = 1;
                cell.Padding = 5;
                tableListPieceDet.AddCell(cell);

                cell = new PdfPCell(new Paragraph(ficheAsPiece.Quantite.ToString()));
                cell.BorderWidth = 1;
                cell.Colspan = 1;
                cell.Padding = 5;
                tableListPieceDet.AddCell(cell);

                cell = new PdfPCell(new Paragraph(pieceDetachee.PrixUnitairePieceDet.ToString() + " €"));
                cell.BorderWidth = 1;
                cell.Colspan = 1;
                cell.Padding = 5;
                tableListPieceDet.AddCell(cell);

                cell = new PdfPCell(new Paragraph(ficheAsPiece.PrixTotal.ToString() + " €"));
                cell.BorderWidthTop = 1;
                cell.BorderWidthBottom = 1;
                cell.BorderWidthLeft = 1;
                cell.BorderWidthRight = 2;
                cell.Colspan = 1;
                cell.Padding = 5;
                tableListPieceDet.AddCell(cell);
            }

            //ligne maxLigne - 3
            cell = new PdfPCell(new Paragraph(" "));
            cell.BorderWidthLeft = 0;
            cell.BorderWidthBottom = 0;
            cell.BorderWidthRight = 0;
            cell.BorderWidthTop = 2;
            cell.Colspan = 2;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell(new Paragraph(" "));
            cell.BorderWidthLeft = 2;
            cell.BorderWidth = 0;
            cell.Colspan = 2;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell(new Paragraph(" "));
            cell.BorderWidthBottom = 0;
            cell.BorderWidthTop = 0;
            cell.BorderWidthRight = 2;
            cell.BorderWidthLeft = 0;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            //ligne maxLigne - 2
            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 2;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell(new Paragraph("TOTAL HT :"));
            cell.BorderWidthBottom = 0;
            cell.BorderWidthTop = 0;
            cell.BorderWidthRight = 0;
            cell.BorderWidthLeft = 2;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.HT1.ToString()));
            cell.BorderWidthLeft = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthBottom = 1;
            cell.BorderWidthRight = 2;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            //ligne maxLigne - 1
            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 2;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell(new Paragraph("TVA :"));
            cell.BorderWidthBottom = 0;
            cell.BorderWidthTop = 0;
            cell.BorderWidthRight = 0;
            cell.BorderWidthLeft = 2;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.TVA1.MontantTva.ToString()));
            cell.BorderWidthLeft = 1;
            cell.BorderWidthTop = 0;
            cell.BorderWidthBottom = 0;
            cell.BorderWidthRight = 2;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            //ligne maxLigne - 0
            cell = new PdfPCell();
            cell.BorderWidth = 0;
            cell.Colspan = 2;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell(new Paragraph("TOTAL TTC :"));
            cell.BorderWidthTop = 0;
            cell.BorderWidthRight = 0;
            cell.BorderWidthLeft = 2;
            cell.BorderWidthBottom = 2;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell();
            cell.BorderWidthLeft = 0;
            cell.BorderWidthTop = 0;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 2;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            cell = new PdfPCell(new Paragraph(fiche.TTC1.ToString()));
            cell.BorderWidthLeft = 1;
            cell.BorderWidthRight = 2;
            cell.BorderWidthBottom = 2;
            cell.Colspan = 1;
            cell.Padding = 5;
            tableListPieceDet.AddCell(cell);

            document.Add(tableListPieceDet);



            if(fiche.Statut != "Facture" || fiche.Statut != "Fiche de réparation")
            {

                //table phrase
                PdfPTable tablePhrase2 = new PdfPTable(5);
                tablePhrase2.WidthPercentage = 100f;
                float[] widthCollPhrase2 = { 200, 200, 200, 200, 200 };
                tablePhrase2.SetWidths(widthCollPhrase2);

                cell = new PdfPCell(new Paragraph(" "));
                cell.BorderWidth = 0;
                cell.Colspan = 5;
                cell.Padding = 5;
                tablePhrase2.AddCell(cell);

                cell = new PdfPCell(new Paragraph("COCHER LA CASE DE VOTRE CHOIX - DATER ET SIGNER :"));
                cell.BorderWidth = 0;
                cell.Colspan = 5;
                cell.Padding = 5;
                tablePhrase2.AddCell(cell);


                cell = new PdfPCell(new Paragraph("[ ] J'accepte la réparation pour la somme de " + fiche.TTC1.ToString() + " €"));
                cell.BorderWidth = 0;
                cell.Colspan = 5;
                cell.Padding = 5;
                tablePhrase2.AddCell(cell);


                cell = new PdfPCell(new Paragraph("[ ] J'accepte la réparation et règlerai les frais d'établissement du devis : 20 €"));
                cell.BorderWidth = 0;
                cell.Colspan = 5;
                cell.Padding = 5;
                tablePhrase2.AddCell(cell);


                cell = new PdfPCell(new Paragraph("[ ] J'accepte la réparation et laisse mon appareil à votre disposition sans frais."));
                cell.BorderWidth = 0;
                cell.Colspan = 5;
                cell.Padding = 5;
                tablePhrase2.AddCell(cell);


                cell = new PdfPCell(new Paragraph(" "));
                cell.BorderWidth = 0;
                cell.Colspan = 5;
                cell.Padding = 5;
                tablePhrase2.AddCell(cell);


                cell = new PdfPCell(new Paragraph(info.NomLab + " " + info.TypeSocieteLab + " - RCS : " + info.RCSLab1 + " - SIRET : " + info.SiretLab1 + " - CODE APE : " + info.APELab1));
                cell.BorderWidth = 0;
                cell.Colspan = 5;
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                cell.Padding = 5;
                tablePhrase2.AddCell(cell);

                document.Add(tablePhrase2);
            }
            else
            {
                //table phrase
                PdfPTable tablePhrase2 = new PdfPTable(5);
                tablePhrase2.WidthPercentage = 100f;
                float[] widthCollPhrase2 = { 200, 200, 200, 200, 200 };
                tablePhrase2.SetWidths(widthCollPhrase2);

                cell = new PdfPCell(new Paragraph(" "));
                cell.BorderWidth = 0;
                cell.Colspan = 5;
                cell.Padding = 5;
                tablePhrase2.AddCell(cell);

                cell = new PdfPCell(new Paragraph("DATER ET SIGNER :"));
                cell.BorderWidth = 0;
                cell.Colspan = 5;
                cell.Padding = 5;
                tablePhrase2.AddCell(cell);

                cell = new PdfPCell(new Paragraph(" "));
                cell.BorderWidth = 0;
                cell.Colspan = 5;
                cell.Padding = 5;
                tablePhrase2.AddCell(cell);

                cell = new PdfPCell(new Paragraph(info.NomLab + " " + info.TypeSocieteLab + " - RCS : " + info.RCSLab1 + " - SIRET : " + info.SiretLab1 + " - CODE APE : " + info.APELab1));
                cell.BorderWidth = 0;
                cell.Colspan = 5;
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                cell.Padding = 5;
                tablePhrase2.AddCell(cell);

                document.Add(tablePhrase2);
            }

            document.Close();

            return true;
        }
        
        /*
         * Accesseur et mutateur
         */
        public FicheDeReparation FicheDeReparation { get => ficheDeReparation; set => ficheDeReparation = value; }
        
        



    }
}
