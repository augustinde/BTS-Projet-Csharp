namespace LAB7
{
    partial class FmTechos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmTechos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crééFicheDeRéparationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crééClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marquesAgréésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modèlesDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crééUnModèleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesModèlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crééUneMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesMarquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.crééFicheDeRéparationToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.marquesAgréésToolStripMenuItem,
            this.modèlesDisponiblesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.accueilToolStripMenuItem.Text = "Accueil";
            this.accueilToolStripMenuItem.Click += new System.EventHandler(this.accueilToolStripMenuItem_Click);
            // 
            // crééFicheDeRéparationToolStripMenuItem
            // 
            this.crééFicheDeRéparationToolStripMenuItem.Name = "crééFicheDeRéparationToolStripMenuItem";
            this.crééFicheDeRéparationToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.crééFicheDeRéparationToolStripMenuItem.Text = "Créé fiche de réparation";
            this.crééFicheDeRéparationToolStripMenuItem.Click += new System.EventHandler(this.crééFicheDeRéparationToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crééClientToolStripMenuItem,
            this.listeClientToolStripMenuItem,
            this.modifierClientToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // crééClientToolStripMenuItem
            // 
            this.crééClientToolStripMenuItem.Name = "crééClientToolStripMenuItem";
            this.crééClientToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.crééClientToolStripMenuItem.Text = "Créé client";
            this.crééClientToolStripMenuItem.Click += new System.EventHandler(this.crééClientToolStripMenuItem_Click);
            // 
            // listeClientToolStripMenuItem
            // 
            this.listeClientToolStripMenuItem.Name = "listeClientToolStripMenuItem";
            this.listeClientToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.listeClientToolStripMenuItem.Text = "Liste client";
            this.listeClientToolStripMenuItem.Click += new System.EventHandler(this.listeClientToolStripMenuItem_Click);
            // 
            // modifierClientToolStripMenuItem
            // 
            this.modifierClientToolStripMenuItem.Name = "modifierClientToolStripMenuItem";
            this.modifierClientToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.modifierClientToolStripMenuItem.Text = "Modifier client";
            this.modifierClientToolStripMenuItem.Click += new System.EventHandler(this.modifierClientToolStripMenuItem_Click);
            // 
            // marquesAgréésToolStripMenuItem
            // 
            this.marquesAgréésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crééUneMarqueToolStripMenuItem,
            this.listeDesMarquesToolStripMenuItem});
            this.marquesAgréésToolStripMenuItem.Name = "marquesAgréésToolStripMenuItem";
            this.marquesAgréésToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.marquesAgréésToolStripMenuItem.Text = "Marques agréés";
            // 
            // modèlesDisponiblesToolStripMenuItem
            // 
            this.modèlesDisponiblesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crééUnModèleToolStripMenuItem,
            this.listeDesModèlesToolStripMenuItem});
            this.modèlesDisponiblesToolStripMenuItem.Name = "modèlesDisponiblesToolStripMenuItem";
            this.modèlesDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.modèlesDisponiblesToolStripMenuItem.Text = "Modèles disponibles";
            // 
            // crééUnModèleToolStripMenuItem
            // 
            this.crééUnModèleToolStripMenuItem.Name = "crééUnModèleToolStripMenuItem";
            this.crééUnModèleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crééUnModèleToolStripMenuItem.Text = "Créé un modèle";
            this.crééUnModèleToolStripMenuItem.Click += new System.EventHandler(this.crééUnModèleToolStripMenuItem_Click);
            // 
            // listeDesModèlesToolStripMenuItem
            // 
            this.listeDesModèlesToolStripMenuItem.Name = "listeDesModèlesToolStripMenuItem";
            this.listeDesModèlesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeDesModèlesToolStripMenuItem.Text = "Liste des modèles";
            this.listeDesModèlesToolStripMenuItem.Click += new System.EventHandler(this.listeDesModèlesToolStripMenuItem_Click);
            // 
            // crééUneMarqueToolStripMenuItem
            // 
            this.crééUneMarqueToolStripMenuItem.Name = "crééUneMarqueToolStripMenuItem";
            this.crééUneMarqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crééUneMarqueToolStripMenuItem.Text = "Créé une marque";
            this.crééUneMarqueToolStripMenuItem.Click += new System.EventHandler(this.crééUneMarqueToolStripMenuItem_Click);
            // 
            // listeDesMarquesToolStripMenuItem
            // 
            this.listeDesMarquesToolStripMenuItem.Name = "listeDesMarquesToolStripMenuItem";
            this.listeDesMarquesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeDesMarquesToolStripMenuItem.Text = "Liste des marques";
            this.listeDesMarquesToolStripMenuItem.Click += new System.EventHandler(this.listeDesMarquesToolStripMenuItem_Click);
            // 
            // FmTechos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FmTechos";
            this.Text = "Panel technicien - LAB7";
            this.Load += new System.EventHandler(this.FmTechos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crééFicheDeRéparationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crééClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marquesAgréésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modèlesDisponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crééUneMarqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesMarquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crééUnModèleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesModèlesToolStripMenuItem;
    }
}