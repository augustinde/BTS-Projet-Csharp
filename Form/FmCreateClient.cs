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
    public partial class FmCreateClient : Form
    {
        public FmCreateClient()
        {
            InitializeComponent();
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {


            string nomClient = tbNomClient.Text;
            string prenomClient = tbPrenomClient.Text;
            string adresseClient = tbAdresseClient.Text;
            string cpClient = tbCpClient.Text;
            string villeClient = tbVilleClient.Text;
            string emailClient = tbAdresseEmailClient.Text;
            string telClient = tbTelClient.Text;

            ClientManager clientManager = new ClientManager();
            int test = clientManager.createClient(nomClient, prenomClient, adresseClient, cpClient, villeClient, emailClient, telClient);
            if(test == 1)
            {
                lbClientAjoute.Text = "Client ajouté !";
                lbClientAjoute.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbClientAjoute.Text = "Client non ajouté !";
                lbClientAjoute.ForeColor = System.Drawing.Color.Red;
            }

        }


    }
}
