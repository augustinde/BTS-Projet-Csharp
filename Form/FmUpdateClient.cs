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

namespace LAB7
{
    public partial class FmUpdateClient : Form
    {
        public FmUpdateClient()
        {
            InitializeComponent();
        }

        private void btSubmitNumeroClient_Click(object sender, EventArgs e)
        {

            int numeroClient = Int32.Parse(cbListeClient.Text[0].ToString());
            ClientManager clientManager = new ClientManager();
            Client client = clientManager.readClient(numeroClient);

            if(client != null)
            {
                tbNomClient.Text = client.NomClt;
                tbPrenomClient.Text = client.PrenomClt;
                tbAdresseClient.Text = client.AdresseClt;
                tbCpClient.Text = client.CpClt;
                tbVilleClient.Text = client.VilleClt;
                tbEmailClient.Text = client.AdresseMailClt;
                tbTelClient.Text = client.TelClt;
                lbMessageErreur.Text = "Client récupéré !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbMessageErreur.Text = "Le client n'existe pas ou la requête n'a pas abouti !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }
           
        }

        private void btUpdateClient_Click(object sender, EventArgs e)
        {
            int.TryParse(cbListeClient.Text, out int idClient);
            string nomClient = tbNomClient.Text;
            string prenomClient = tbPrenomClient.Text;
            string adresseClient = tbAdresseClient.Text;
            string cpClient = tbCpClient.Text;
            string villeClient = tbVilleClient.Text;
            string emailClient = tbEmailClient.Text;
            string telClient = tbTelClient.Text;

            ClientManager clientManager = new ClientManager();
            int test = clientManager.updateClient(idClient, nomClient, prenomClient, adresseClient, cpClient, villeClient, emailClient, telClient);

            if(test == 1)
            {
                lbMessageErreur.Text = "Client modifié !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbMessageErreur.Text = "Client non modifié !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void btSupprimerClient_Click(object sender, EventArgs e)
        {
            int.TryParse(cbListeClient.Text, out int idClient);

            ClientManager clientManager = new ClientManager();
            int test = clientManager.deleteClient(idClient);

            if (test == 1)
            {
                lbMessageErreur.Text = "Client supprimé !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Green;
                tbNomClient.Text = "";
                tbPrenomClient.Text = "";
                tbAdresseClient.Text = "";
                tbCpClient.Text = "";
                tbVilleClient.Text = "";
                tbEmailClient.Text = "";
                tbTelClient.Text = "";
            }
            else
            {
                lbMessageErreur.Text = "Client non supprimé !";
                lbMessageErreur.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void FmUpdateClient_Load(object sender, EventArgs e)
        {
            ClientManager clientManager = new ClientManager();
            List<Client> clientCollection = new List<Client>();
            clientCollection = clientManager.readAllClient();

            foreach(Client client in clientCollection)
            {
                string str = client.IdClt + " - " + client.NomClt + " " + client.PrenomClt;
                cbListeClient.Items.Add(str);
            }
        }
    }
}
