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
    public partial class FmListeMarque : Form
    {
        public FmListeMarque()
        {
            InitializeComponent();
        }

        private void FmListeMarque_Load(object sender, EventArgs e)
        {
            MarqueManager mm = new MarqueManager();
            List<Marque> marques = new List<Marque>();
            marques = mm.readAllMarque();

            dataGridView1.DataSource = marques;

        }
    }
}
