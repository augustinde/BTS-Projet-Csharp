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
    public partial class FmListeModele : Form
    {
        public FmListeModele()
        {
            InitializeComponent();
        }

        private void FmListeModele_Load(object sender, EventArgs e)
        {
            ModeleManager modeleManager = new ModeleManager();
            List<Modele> modeleCollection = new List<Modele>();
            modeleCollection = modeleManager.readAllModele();

            dataGridView1.DataSource = modeleCollection;

        }
    }
}
