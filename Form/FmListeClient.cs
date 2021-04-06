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
    public partial class FmListeClient : Form
    {
        public FmListeClient()
        {
            InitializeComponent();

        }

        private void FmListeClient_Load(object sender, EventArgs e)
        {

            ClientManager cm = new ClientManager();
            List<Client> clients = new List<Client>();
            clients = cm.readAllClient();

            dataGridView1.DataSource = clients;
        }
    }
}
