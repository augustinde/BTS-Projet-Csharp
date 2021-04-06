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
    public partial class FmCreateMarque : Form
    {
        public FmCreateMarque()
        {
            InitializeComponent();
        }

        private void btnCreateMarque_Click(object sender, EventArgs e)
        {
            string nomMarque = tbNomMarque.Text;

            MarqueManager mm = new MarqueManager();
            int test = mm.createMarque(nomMarque);
            if (test == 1)
            {
                lbMarqueAjoute.Text = "Marque ajouté !";
                lbMarqueAjoute.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbMarqueAjoute.Text = "Marque non ajouté !";
                lbMarqueAjoute.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}
