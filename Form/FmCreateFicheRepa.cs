using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB7.Manager;
using LAB7.Component;

namespace LAB7
{
    public partial class FmCreateFicheRepa : Form
    {
        public FmCreateFicheRepa()
        {
            InitializeComponent();
        }

        private void FmCreateFicheRepa_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBoxMarque.Items.Clear();

            ClientManager cm = new ClientManager();
            List<Client> clientCollection = new List<Client>();

            clientCollection = cm.readAllClient();

            List<Client> clients = new List<Client>();

            for(int i = 0; i<clientCollection.Count(); i++)
            {
                clients.Add(new Client(
                    clientCollection[i].IdClt,
                    clientCollection[i].NomClt,
                    clientCollection[i].PrenomClt,
                    clientCollection[i].AdresseClt,
                    clientCollection[i].CpClt,
                    clientCollection[i].VilleClt,
                    clientCollection[i].AdresseMailClt,
                    clientCollection[i].TelClt
                    ));
            }

            comboBox1.DisplayMember = "fullNameClt";
            comboBox1.ValueMember = "idClt";
            comboBox1.DataSource = clients;

            MarqueManager marqueManager = new MarqueManager();
            List<Marque> marqueCollection = new List<Marque>();

            marqueCollection = marqueManager.readAllMarque();

            List<Marque> marques = new List<Marque>();

            for (int i = 0; i < marqueCollection.Count(); i++)
            {
                marques.Add(new Marque(marqueCollection[i].IdMarque, marqueCollection[i].NomMarque));
            }

            comboBoxMarque.DisplayMember = "nomMarque";
            comboBoxMarque.ValueMember = "idMarque";
            comboBoxMarque.DataSource = marques;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ClientManager clientManager = new ClientManager();

            Client client = new Client();
            client = clientManager.readClient(((Client)comboBox1.SelectedItem).IdClt);
            lbId.Text = client.IdClt.ToString();
            lbNom.Text = client.NomClt;
            lbPrenom.Text = client.PrenomClt;
            lbAdresse.Text = client.AdresseClt;
            lbCp.Text = client.CpClt;
            lbVille.Text = client.VilleClt;
            lbEmail.Text = client.AdresseMailClt;
            lbTel.Text = client.TelClt;
        }

        private void comboBoxMarque_SelectedIndexChanged(object sender, EventArgs e)
        {

            ModeleManager modeleManager = new ModeleManager();
            List<Modele> modeleCollection = new List<Modele>();

            Modele modele = new Modele();
            int md = ((Marque)comboBoxMarque.SelectedItem).IdMarque;
            modeleCollection = modeleManager.readModeleHasMarque(md);
            List<string> resetComboBox = new List<string>();

            if(modeleCollection.Count()<1)
            {
                comboBoxModele.DataSource = resetComboBox;
                lbNomModele.Text = "";

            }

            List<Modele> modeles = new List<Modele>();

            for(int i = 0; i<modeleCollection.Count(); i++)
            {
                modeles.Add(new Modele(modeleCollection[i].IdModele, modeleCollection[i].NomModele));
            }

            comboBoxModele.DisplayMember = "nomModele";
            comboBoxModele.ValueMember = "idModele";
            comboBoxModele.DataSource = modeles;
            lbNomMarque.Text = ((Marque)comboBoxMarque.SelectedItem).NomMarque.ToString();
        }

        private void comboBoxModele_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNomModele.Text = ((Modele)comboBoxModele.SelectedItem).NomModele.ToString();
        }

       /* private void btnSubmitCreateFiche_Click(object sender, EventArgs e)
        {
            BaseDonnee baseDonnee = new BaseDonnee();


            string commentaire = tbCommentaire.Text;
            int idMarque = ((Marque)comboBoxMarque.SelectedItem).IdMarque;
            int idModele = ((Modele)comboBoxModele.SelectedItem).IdModele;

            Marque marque = new Marque(idMarque, lbNomMarque.Text);
            Modele modele = new Modele(idModele, lbNomModele.Text);

            Client client = new Client(Int32.Parse(lbId.Text), lbNom.Text, lbPrenom.Text, lbAdresse.Text, lbCp.Text, lbVille.Text, lbEmail.Text, lbTel.Text);

            DateTime dateAchat = dateTimeAchat.Value;

            TvaManager tvaManager = new TvaManager();
            Tva tva = tvaManager.readTvaActif();



        }*/

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

        private void btnSubmitCreateFiche_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmAddPiece");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {

                string commentaire = tbCommentaire.Text;
                int idMarque = ((Marque)comboBoxMarque.SelectedItem).IdMarque;
                int idModele = ((Modele)comboBoxModele.SelectedItem).IdModele;

                Marque marque = new Marque(idMarque, lbNomMarque.Text);
                Modele modele = new Modele(idModele, lbNomModele.Text);

                Client client = new Client(Int32.Parse(lbId.Text), lbNom.Text, lbPrenom.Text, lbAdresse.Text, lbCp.Text, lbVille.Text, lbEmail.Text, lbTel.Text);

                DateTime dateAchat = dateTimeAchat.Value;

                int dureeReparation = Int32.Parse(tbDureeReparation.Text);

                string numSerie = tbNumSerie.Text;

                FmAddPiece fLc = new FmAddPiece(client, marque, modele, dateAchat, commentaire, dureeReparation, numSerie);

                fLc.MdiParent = this.MdiParent;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void tbDureeReparation_TextChanged(object sender, EventArgs e)
        {

            if (Int32.TryParse(tbDureeReparation.Text, out int value))
            {

                btnSubmitCreateFiche.Enabled = true;

            }
            else
            {
                btnSubmitCreateFiche.Enabled = false;
            }
        }
    }
}
