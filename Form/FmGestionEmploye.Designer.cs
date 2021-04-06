namespace LAB7
{
    partial class FmGestionEmploye
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
            this.dgvListeEmploye = new System.Windows.Forms.DataGridView();
            this.btnDeleteCurrent = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.tbNomUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFonction = new System.Windows.Forms.ComboBox();
            this.lbMessageError = new System.Windows.Forms.Label();
            this.idEmploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motDePasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActiver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDesactiver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEmploye)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListeEmploye
            // 
            this.dgvListeEmploye.AllowUserToAddRows = false;
            this.dgvListeEmploye.AllowUserToDeleteRows = false;
            this.dgvListeEmploye.AllowUserToResizeColumns = false;
            this.dgvListeEmploye.AllowUserToResizeRows = false;
            this.dgvListeEmploye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeEmploye.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListeEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeEmploye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmploye,
            this.motDePasse,
            this.nomUtilisateur,
            this.fonction,
            this.activ,
            this.btnActiver,
            this.btnDesactiver,
            this.btnDelete});
            this.dgvListeEmploye.Location = new System.Drawing.Point(12, 12);
            this.dgvListeEmploye.Name = "dgvListeEmploye";
            this.dgvListeEmploye.RowHeadersWidth = 51;
            this.dgvListeEmploye.Size = new System.Drawing.Size(776, 207);
            this.dgvListeEmploye.TabIndex = 2;
            this.dgvListeEmploye.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeEmploye_CellContentClick);
            this.dgvListeEmploye.SelectionChanged += new System.EventHandler(this.dgvListeEmploye_SelectionChanged);
            // 
            // btnDeleteCurrent
            // 
            this.btnDeleteCurrent.Location = new System.Drawing.Point(17, 390);
            this.btnDeleteCurrent.Name = "btnDeleteCurrent";
            this.btnDeleteCurrent.Size = new System.Drawing.Size(156, 23);
            this.btnDeleteCurrent.TabIndex = 24;
            this.btnDeleteCurrent.Text = "Supprimer la sélection ";
            this.btnDeleteCurrent.UseVisualStyleBackColor = true;
            this.btnDeleteCurrent.Click += new System.EventHandler(this.btnDeleteCurrent_Click);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(99, 235);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(75, 20);
            this.tbId.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(13, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Identifiant";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(98, 361);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(17, 361);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Ajouter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(124, 302);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(134, 20);
            this.tbMdp.TabIndex = 18;
            // 
            // tbNomUser
            // 
            this.tbNomUser.Location = new System.Drawing.Point(145, 269);
            this.tbNomUser.Name = "tbNomUser";
            this.tbNomUser.Size = new System.Drawing.Size(113, 20);
            this.tbNomUser.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(13, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(13, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fonction";
            // 
            // cbFonction
            // 
            this.cbFonction.FormattingEnabled = true;
            this.cbFonction.Items.AddRange(new object[] {
            "Administrateur",
            "Technicien"});
            this.cbFonction.Location = new System.Drawing.Point(91, 334);
            this.cbFonction.Name = "cbFonction";
            this.cbFonction.Size = new System.Drawing.Size(121, 21);
            this.cbFonction.TabIndex = 26;
            // 
            // lbMessageError
            // 
            this.lbMessageError.AutoSize = true;
            this.lbMessageError.Location = new System.Drawing.Point(17, 425);
            this.lbMessageError.Name = "lbMessageError";
            this.lbMessageError.Size = new System.Drawing.Size(0, 13);
            this.lbMessageError.TabIndex = 27;
            // 
            // idEmploye
            // 
            this.idEmploye.FillWeight = 50F;
            this.idEmploye.HeaderText = "Id";
            this.idEmploye.MinimumWidth = 6;
            this.idEmploye.Name = "idEmploye";
            // 
            // motDePasse
            // 
            this.motDePasse.HeaderText = "motDePasse";
            this.motDePasse.Name = "motDePasse";
            this.motDePasse.Visible = false;
            // 
            // nomUtilisateur
            // 
            this.nomUtilisateur.HeaderText = "Nom d\'utilisateur";
            this.nomUtilisateur.MinimumWidth = 6;
            this.nomUtilisateur.Name = "nomUtilisateur";
            // 
            // fonction
            // 
            this.fonction.HeaderText = "Fonction";
            this.fonction.MinimumWidth = 6;
            this.fonction.Name = "fonction";
            // 
            // activ
            // 
            this.activ.HeaderText = "Actif";
            this.activ.Name = "activ";
            // 
            // btnActiver
            // 
            this.btnActiver.HeaderText = "Activer";
            this.btnActiver.MinimumWidth = 6;
            this.btnActiver.Name = "btnActiver";
            this.btnActiver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnActiver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnActiver.Text = "Activer";
            this.btnActiver.UseColumnTextForButtonValue = true;
            // 
            // btnDesactiver
            // 
            this.btnDesactiver.HeaderText = "Désactiver";
            this.btnDesactiver.Name = "btnDesactiver";
            this.btnDesactiver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDesactiver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDesactiver.Text = "Désactiver";
            this.btnDesactiver.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Supprimer";
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // FmGestionEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMessageError);
            this.Controls.Add(this.cbFonction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteCurrent);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbNomUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListeEmploye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmGestionEmploye";
            this.Text = "FmGestionEmploye";
            this.Load += new System.EventHandler(this.FmGestionEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEmploye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListeEmploye;
        private System.Windows.Forms.Button btnDeleteCurrent;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.TextBox tbNomUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFonction;
        private System.Windows.Forms.Label lbMessageError;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn motDePasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonction;
        private System.Windows.Forms.DataGridViewTextBoxColumn activ;
        private System.Windows.Forms.DataGridViewButtonColumn btnActiver;
        private System.Windows.Forms.DataGridViewButtonColumn btnDesactiver;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}