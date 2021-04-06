﻿using System;
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
    public partial class FmAdmin : Form
    {
        public FmAdmin()
        {
            InitializeComponent();
          
        }

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


        private void creeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmCreateClient");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmCreateClient fCc = new FmCreateClient();
                fCc.MdiParent = this;
                fCc.Dock = DockStyle.Fill;
                fCc.TopLevel = false;
                fCc.Show();
            }
       
        }

        private void listeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fmVerif = VerifOpenForm("FmListeClient");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmListeClient fLc = new FmListeClient();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach(Form fm in this.MdiChildren)
            {
                if (!fm.Focused)
                {
                    fm.Hide();
                    fm.Dispose();
                }
            }

            Form fmVerif = VerifOpenForm("FmAcceuil");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmAcceuil fLc = new FmAcceuil();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }

        }

        private void modifierUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmUpdateClient");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmUpdateClient fLc = new FmUpdateClient();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void listeDesMarquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmListeMarque");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmListeMarque fLc = new FmListeMarque();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void crééMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmCreateMarque");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmCreateMarque fLc = new FmCreateMarque();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void modifierUneMarqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmUpdateMarque");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmUpdateMarque fLc = new FmUpdateMarque();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void infoLégalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmInfoLab");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmInfoLab fLc = new FmInfoLab();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void crééFicheDeRéparationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmCreateFicheRepa");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmCreateFicheRepa fLc = new FmCreateFicheRepa();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void crééUnModèleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmCreateModele");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmCreateModele fLc = new FmCreateModele();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void listeDesModèlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmListeModele");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmListeModele fLc = new FmListeModele();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void modifierUnModèleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmUpdateModele");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmUpdateModele fLc = new FmUpdateModele();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void tauxTVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmTva");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmTva fLc = new FmTva();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void montantMainDoeuvreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmMainOeuvre");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmMainOeuvre fLc = new FmMainOeuvre();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void piècesDétachéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmPieceDeta");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmPieceDeta fLc = new FmPieceDeta();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void FmAdmin_Load(object sender, EventArgs e)
        {
            foreach (Form fm in this.MdiChildren)
            {
                if (!fm.Focused)
                {
                    fm.Hide();
                    fm.Dispose();
                }
            }
            Form fmVerif = VerifOpenForm("FmAcceuil");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmAcceuil fLc = new FmAcceuil();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }

        private void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fmVerif = VerifOpenForm("FmGestionEmploye");
            if (fmVerif != null)
            {
                fmVerif.Focus();

            }
            else
            {
                FmGestionEmploye fLc = new FmGestionEmploye();
                fLc.MdiParent = this;
                fLc.Dock = DockStyle.Fill;
                fLc.Show();
            }
        }
    }
}
