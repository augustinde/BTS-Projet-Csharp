namespace LAB7
{
    partial class FmAcceuil
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
            this.lbTitleAccueil = new System.Windows.Forms.Label();
            this.dgvListeFiche = new System.Windows.Forms.DataGridView();
            this.numFiche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVisualise = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDownload = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnTransformDevis = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAction = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnTransformFacture = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAccepter = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRefus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBoxFiltreCritere = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbMessageError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFiche)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitleAccueil
            // 
            this.lbTitleAccueil.AutoSize = true;
            this.lbTitleAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbTitleAccueil.Location = new System.Drawing.Point(12, 9);
            this.lbTitleAccueil.Name = "lbTitleAccueil";
            this.lbTitleAccueil.Size = new System.Drawing.Size(0, 24);
            this.lbTitleAccueil.TabIndex = 0;
            // 
            // dgvListeFiche
            // 
            this.dgvListeFiche.AllowUserToAddRows = false;
            this.dgvListeFiche.AllowUserToDeleteRows = false;
            this.dgvListeFiche.AllowUserToResizeColumns = false;
            this.dgvListeFiche.AllowUserToResizeRows = false;
            this.dgvListeFiche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeFiche.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListeFiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeFiche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numFiche,
            this.nomClt,
            this.montant,
            this.statut,
            this.btnVisualise,
            this.btnDownload,
            this.btnTransformDevis,
            this.btnAction,
            this.btnTransformFacture,
            this.btnAccepter,
            this.btnRefus,
            this.btnDelete});
            this.dgvListeFiche.Location = new System.Drawing.Point(-1, 51);
            this.dgvListeFiche.Name = "dgvListeFiche";
            this.dgvListeFiche.RowHeadersWidth = 51;
            this.dgvListeFiche.Size = new System.Drawing.Size(802, 256);
            this.dgvListeFiche.TabIndex = 1;
            this.dgvListeFiche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeFiche_CellContentClick);
            this.dgvListeFiche.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvListeFiche_EditingControlShowing);
            // 
            // numFiche
            // 
            this.numFiche.HeaderText = "Numéro de fiche";
            this.numFiche.MinimumWidth = 6;
            this.numFiche.Name = "numFiche";
            // 
            // nomClt
            // 
            this.nomClt.HeaderText = "Nom du client";
            this.nomClt.MinimumWidth = 6;
            this.nomClt.Name = "nomClt";
            // 
            // montant
            // 
            this.montant.HeaderText = "Montant";
            this.montant.MinimumWidth = 6;
            this.montant.Name = "montant";
            // 
            // statut
            // 
            this.statut.HeaderText = "Statut";
            this.statut.MinimumWidth = 6;
            this.statut.Name = "statut";
            // 
            // btnVisualise
            // 
            this.btnVisualise.HeaderText = "Affichage";
            this.btnVisualise.MinimumWidth = 6;
            this.btnVisualise.Name = "btnVisualise";
            this.btnVisualise.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnVisualise.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnVisualise.Text = "Afficher";
            this.btnVisualise.UseColumnTextForButtonValue = true;
            // 
            // btnDownload
            // 
            this.btnDownload.HeaderText = "Téléchargement";
            this.btnDownload.MinimumWidth = 6;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDownload.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDownload.Text = "Télécharger";
            this.btnDownload.UseColumnTextForButtonValue = true;
            // 
            // btnTransformDevis
            // 
            this.btnTransformDevis.HeaderText = "Transformer en devis";
            this.btnTransformDevis.MinimumWidth = 6;
            this.btnTransformDevis.Name = "btnTransformDevis";
            this.btnTransformDevis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnTransformDevis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnTransformDevis.Text = "Transformer";
            this.btnTransformDevis.UseColumnTextForButtonValue = true;
            this.btnTransformDevis.Visible = false;
            // 
            // btnAction
            // 
            this.btnAction.HeaderText = "Action";
            this.btnAction.Name = "btnAction";
            // 
            // btnTransformFacture
            // 
            this.btnTransformFacture.HeaderText = "Transformer en facture";
            this.btnTransformFacture.MinimumWidth = 6;
            this.btnTransformFacture.Name = "btnTransformFacture";
            this.btnTransformFacture.Text = "Transformer";
            this.btnTransformFacture.UseColumnTextForButtonValue = true;
            this.btnTransformFacture.Visible = false;
            // 
            // btnAccepter
            // 
            this.btnAccepter.HeaderText = "Accepter";
            this.btnAccepter.Name = "btnAccepter";
            this.btnAccepter.Text = "Accepter";
            this.btnAccepter.UseColumnTextForButtonValue = true;
            this.btnAccepter.Visible = false;
            // 
            // btnRefus
            // 
            this.btnRefus.HeaderText = "Refuser";
            this.btnRefus.Name = "btnRefus";
            this.btnRefus.Text = "Refuser";
            this.btnRefus.UseColumnTextForButtonValue = true;
            this.btnRefus.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Supprimer";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recherche d\'une fiche de réparation";
            // 
            // cbBoxFiltreCritere
            // 
            this.cbBoxFiltreCritere.FormattingEnabled = true;
            this.cbBoxFiltreCritere.Location = new System.Drawing.Point(12, 345);
            this.cbBoxFiltreCritere.Name = "cbBoxFiltreCritere";
            this.cbBoxFiltreCritere.Size = new System.Drawing.Size(121, 21);
            this.cbBoxFiltreCritere.TabIndex = 22;
            this.cbBoxFiltreCritere.SelectionChangeCommitted += new System.EventHandler(this.cbBoxFiltreCritere_SelectionChangeCommitted);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(139, 345);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(104, 20);
            this.tbSearch.TabIndex = 21;
            // 
            // btnFiltre
            // 
            this.btnFiltre.Location = new System.Drawing.Point(248, 343);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(76, 23);
            this.btnFiltre.TabIndex = 20;
            this.btnFiltre.Text = "Rechercher";
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(330, 343);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(76, 23);
            this.btnShowAll.TabIndex = 19;
            this.btnShowAll.Text = "Tout afficher";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd.MM.yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(13, 373);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(92, 20);
            this.dtpDate.TabIndex = 23;
            this.dtpDate.Visible = false;
            // 
            // lbMessageError
            // 
            this.lbMessageError.AutoSize = true;
            this.lbMessageError.Location = new System.Drawing.Point(145, 379);
            this.lbMessageError.Name = "lbMessageError";
            this.lbMessageError.Size = new System.Drawing.Size(0, 13);
            this.lbMessageError.TabIndex = 24;
            // 
            // FmAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListeFiche);
            this.Controls.Add(this.lbMessageError);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbBoxFiltreCritere);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnFiltre);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitleAccueil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmAcceuil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.FmAcceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFiche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitleAccueil;
        private System.Windows.Forms.DataGridView dgvListeFiche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBoxFiltreCritere;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbMessageError;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFiche;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClt;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
        private System.Windows.Forms.DataGridViewButtonColumn btnVisualise;
        private System.Windows.Forms.DataGridViewButtonColumn btnDownload;
        private System.Windows.Forms.DataGridViewButtonColumn btnTransformDevis;
        private System.Windows.Forms.DataGridViewComboBoxColumn btnAction;
        private System.Windows.Forms.DataGridViewButtonColumn btnTransformFacture;
        private System.Windows.Forms.DataGridViewButtonColumn btnAccepter;
        private System.Windows.Forms.DataGridViewButtonColumn btnRefus;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}