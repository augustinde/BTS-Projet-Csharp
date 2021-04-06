 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7
{
    public class FicheDeReparation
    {
        /*
         * Propriété de l'objet FicheDeReparation
         */
        //Auto incremente
        private int idFiche;

        //Donnée lors de la création de la fiche de réparation
        private DateTime dateAchat;
        private Modele modele;
        private Marque marque;
        private string commentaire;
        private List<FicheAsPieceDet> pieceDetachees;
        private int dureeReparation;
        private Tva TVA;
        private double TTC;
        private double HT;
        private MainOeuvre mainOeuvre;
        private string statut;
        private string sousStatut;
        private Client client;
        private string numSerie;

        //Donnée devis et facture
        private DateTime dateDevis;

        /*
         * Constructeurs de l'objet FicheDeReparation
         */
        public FicheDeReparation()
        {

        }

        public FicheDeReparation(int idFiche, double ttc, string statut, string sousStatut, Client client)
        {
            this.idFiche = idFiche;
            this.client = client;
            this.TTC = ttc;
            this.statut = statut;
            this.sousStatut = sousStatut;

        }

        public FicheDeReparation(DateTime dateAchat, Modele modele, Marque marque, string commentaire, List<FicheAsPieceDet> pieceDetachees, int dureeReparation, Tva tVA, double tTC, double hT, MainOeuvre mainOeuvre, string statut, string sousStatut, Client client, string numSerie)
        {
            this.dateAchat = dateAchat;
            this.modele = modele;
            this.commentaire = commentaire;
            this.pieceDetachees = pieceDetachees;
            this.dureeReparation = dureeReparation;
            TVA = tVA;
            TTC = tTC;
            HT = hT;
            this.mainOeuvre = mainOeuvre;
            this.statut = statut;
            this.sousStatut = sousStatut;
            this.client = client;
            this.marque = marque;
            this.numSerie = numSerie;

        }

        public FicheDeReparation(DateTime dateAchat, Modele modele, Marque marque, string commentaire, List<FicheAsPieceDet> pieceDetachees, int dureeReparation, Tva tVA, double tTC, double hT, MainOeuvre mainOeuvre, string statut, string sousStatut, Client client, DateTime dateDevis, string numSerie)
        {
            this.dateAchat = dateAchat;
            this.modele = modele;
            this.commentaire = commentaire;
            this.pieceDetachees = pieceDetachees;
            this.dureeReparation = dureeReparation;
            TVA = tVA;
            TTC = tTC;
            HT = hT;
            this.mainOeuvre = mainOeuvre;
            this.statut = statut;
            this.sousStatut = sousStatut;
            this.client = client;
            this.dateDevis = dateDevis;
            this.numSerie = numSerie;

        }

        /*
         * Accesseurs et mutateurs
         */
        public DateTime DateAchat { get => dateAchat; set => dateAchat = value; }
        public Modele Modele { get => modele; set => modele = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public List<FicheAsPieceDet> PieceDetachees { get => pieceDetachees; set => pieceDetachees = value; }
        public int DureeReparation { get => dureeReparation; set => dureeReparation = value; }
        public Tva TVA1 { get => TVA; set => TVA = value; }
        public double TTC1 { get => TTC; set => TTC = value; }
        public double HT1 { get => HT; set => HT = value; }
        public MainOeuvre MainOeuvre { get => mainOeuvre; set => mainOeuvre = value; }
        public string Statut { get => statut; set => statut = value; }
        public Client Client { get => client; set => client = value; }
        public DateTime DateDevis { get => dateDevis; set => dateDevis = value; }
        public int IdFiche { get => idFiche; set => idFiche = value; }
        public Marque Marque { get => marque; set => marque = value; }
        public string NumSerie { get => numSerie; set => numSerie = value; }
        public string SousStatut { get => sousStatut; set => sousStatut = value; }
    }
}
