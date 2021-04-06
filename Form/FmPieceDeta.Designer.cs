namespace LAB7
{
    partial class FmPieceDeta
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
            this.dataGridViewPieceDeta = new System.Windows.Forms.DataGridView();
            this.idPieceDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPieceDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixUnitairePieceDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockPieceDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLibellePiece = new System.Windows.Forms.TextBox();
            this.tbPrixUnitaire = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.btnSubmitAddPiece = new System.Windows.Forms.Button();
            this.btnUpdatePiece = new System.Windows.Forms.Button();
            this.btnDeletePiece = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteCurrent = new System.Windows.Forms.Button();
            this.lbMessageError = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbBoxCritereFiltre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMessageFiltre = new System.Windows.Forms.Label();
            this.lbMessageErreur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPieceDeta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPieceDeta
            // 
            this.dataGridViewPieceDeta.AllowUserToAddRows = false;
            this.dataGridViewPieceDeta.AllowUserToDeleteRows = false;
            this.dataGridViewPieceDeta.AllowUserToResizeColumns = false;
            this.dataGridViewPieceDeta.AllowUserToResizeRows = false;
            this.dataGridViewPieceDeta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPieceDeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPieceDeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPieceDet,
            this.nomPieceDet,
            this.prixUnitairePieceDet,
            this.stockPieceDet});
            this.dataGridViewPieceDeta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewPieceDeta.Location = new System.Drawing.Point(394, 102);
            this.dataGridViewPieceDeta.Name = "dataGridViewPieceDeta";
            this.dataGridViewPieceDeta.ReadOnly = true;
            this.dataGridViewPieceDeta.Size = new System.Drawing.Size(394, 275);
            this.dataGridViewPieceDeta.TabIndex = 0;
            this.dataGridViewPieceDeta.SelectionChanged += new System.EventHandler(this.dataGridViewPieceDeta_SelectionChanged);
            // 
            // idPieceDet
            // 
            this.idPieceDet.DataPropertyName = "idPieceDet";
            this.idPieceDet.HeaderText = "Id";
            this.idPieceDet.Name = "idPieceDet";
            this.idPieceDet.ReadOnly = true;
            this.idPieceDet.Width = 50;
            // 
            // nomPieceDet
            // 
            this.nomPieceDet.DataPropertyName = "nomPieceDet";
            this.nomPieceDet.HeaderText = "Libelle";
            this.nomPieceDet.Name = "nomPieceDet";
            this.nomPieceDet.ReadOnly = true;
            // 
            // prixUnitairePieceDet
            // 
            this.prixUnitairePieceDet.DataPropertyName = "prixUnitairePieceDet";
            this.prixUnitairePieceDet.HeaderText = "Prix unitaire (en €)";
            this.prixUnitairePieceDet.Name = "prixUnitairePieceDet";
            this.prixUnitairePieceDet.ReadOnly = true;
            // 
            // stockPieceDet
            // 
            this.stockPieceDet.DataPropertyName = "stockPieceDet";
            this.stockPieceDet.HeaderText = "Stock";
            this.stockPieceDet.Name = "stockPieceDet";
            this.stockPieceDet.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(64, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(28, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prix unitaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(68, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock";
            // 
            // tbLibellePiece
            // 
            this.tbLibellePiece.Location = new System.Drawing.Point(124, 152);
            this.tbLibellePiece.Name = "tbLibellePiece";
            this.tbLibellePiece.Size = new System.Drawing.Size(179, 20);
            this.tbLibellePiece.TabIndex = 4;
            // 
            // tbPrixUnitaire
            // 
            this.tbPrixUnitaire.Location = new System.Drawing.Point(124, 186);
            this.tbPrixUnitaire.Name = "tbPrixUnitaire";
            this.tbPrixUnitaire.Size = new System.Drawing.Size(75, 20);
            this.tbPrixUnitaire.TabIndex = 5;
            this.tbPrixUnitaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrixUnitaire_KeyPress);
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(124, 221);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(75, 20);
            this.tbStock.TabIndex = 6;
            // 
            // btnSubmitAddPiece
            // 
            this.btnSubmitAddPiece.Location = new System.Drawing.Point(52, 256);
            this.btnSubmitAddPiece.Name = "btnSubmitAddPiece";
            this.btnSubmitAddPiece.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitAddPiece.TabIndex = 7;
            this.btnSubmitAddPiece.Text = "Ajouter";
            this.btnSubmitAddPiece.UseVisualStyleBackColor = true;
            this.btnSubmitAddPiece.Click += new System.EventHandler(this.btnSubmitAddPiece_Click);
            // 
            // btnUpdatePiece
            // 
            this.btnUpdatePiece.Location = new System.Drawing.Point(133, 256);
            this.btnUpdatePiece.Name = "btnUpdatePiece";
            this.btnUpdatePiece.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePiece.TabIndex = 8;
            this.btnUpdatePiece.Text = "Modifier";
            this.btnUpdatePiece.UseVisualStyleBackColor = true;
            this.btnUpdatePiece.Click += new System.EventHandler(this.btnUpdatePiece_Click);
            // 
            // btnDeletePiece
            // 
            this.btnDeletePiece.Location = new System.Drawing.Point(214, 256);
            this.btnDeletePiece.Name = "btnDeletePiece";
            this.btnDeletePiece.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePiece.TabIndex = 9;
            this.btnDeletePiece.Text = "Supprimer";
            this.btnDeletePiece.UseVisualStyleBackColor = true;
            this.btnDeletePiece.Click += new System.EventHandler(this.btnDeletePiece_Click);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(124, 116);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(75, 20);
            this.tbId.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(38, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Identifiant";
            // 
            // btnDeleteCurrent
            // 
            this.btnDeleteCurrent.Location = new System.Drawing.Point(52, 285);
            this.btnDeleteCurrent.Name = "btnDeleteCurrent";
            this.btnDeleteCurrent.Size = new System.Drawing.Size(156, 23);
            this.btnDeleteCurrent.TabIndex = 12;
            this.btnDeleteCurrent.Text = "Supprimer la sélection ";
            this.btnDeleteCurrent.UseVisualStyleBackColor = true;
            this.btnDeleteCurrent.Click += new System.EventHandler(this.btnDeleteCurrent_Click);
            // 
            // lbMessageError
            // 
            this.lbMessageError.AutoSize = true;
            this.lbMessageError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMessageError.Location = new System.Drawing.Point(49, 327);
            this.lbMessageError.Name = "lbMessageError";
            this.lbMessageError.Size = new System.Drawing.Size(0, 20);
            this.lbMessageError.TabIndex = 13;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(712, 73);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(76, 23);
            this.btnShowAll.TabIndex = 14;
            this.btnShowAll.Text = "Tout afficher";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnFiltre
            // 
            this.btnFiltre.Location = new System.Drawing.Point(630, 73);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(76, 23);
            this.btnFiltre.TabIndex = 15;
            this.btnFiltre.Text = "Rechercher";
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(521, 75);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(104, 20);
            this.tbSearch.TabIndex = 16;
            // 
            // cbBoxCritereFiltre
            // 
            this.cbBoxCritereFiltre.FormattingEnabled = true;
            this.cbBoxCritereFiltre.Location = new System.Drawing.Point(394, 75);
            this.cbBoxCritereFiltre.Name = "cbBoxCritereFiltre";
            this.cbBoxCritereFiltre.Size = new System.Drawing.Size(121, 21);
            this.cbBoxCritereFiltre.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(391, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Rechercher par ";
            // 
            // lbMessageFiltre
            // 
            this.lbMessageFiltre.AutoSize = true;
            this.lbMessageFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbMessageFiltre.Location = new System.Drawing.Point(391, 392);
            this.lbMessageFiltre.Name = "lbMessageFiltre";
            this.lbMessageFiltre.Size = new System.Drawing.Size(0, 13);
            this.lbMessageFiltre.TabIndex = 19;
            // 
            // lbMessageErreur
            // 
            this.lbMessageErreur.AutoSize = true;
            this.lbMessageErreur.Location = new System.Drawing.Point(50, 327);
            this.lbMessageErreur.Name = "lbMessageErreur";
            this.lbMessageErreur.Size = new System.Drawing.Size(0, 13);
            this.lbMessageErreur.TabIndex = 20;
            // 
            // FmPieceDeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMessageErreur);
            this.Controls.Add(this.lbMessageFiltre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBoxCritereFiltre);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnFiltre);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.lbMessageError);
            this.Controls.Add(this.btnDeleteCurrent);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeletePiece);
            this.Controls.Add(this.btnUpdatePiece);
            this.Controls.Add(this.btnSubmitAddPiece);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbPrixUnitaire);
            this.Controls.Add(this.tbLibellePiece);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPieceDeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmPieceDeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FmPieceDeta";
            this.Load += new System.EventHandler(this.FmPieceDeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPieceDeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPieceDeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLibellePiece;
        private System.Windows.Forms.TextBox tbPrixUnitaire;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Button btnSubmitAddPiece;
        private System.Windows.Forms.Button btnUpdatePiece;
        private System.Windows.Forms.Button btnDeletePiece;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteCurrent;
        private System.Windows.Forms.Label lbMessageError;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbBoxCritereFiltre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMessageFiltre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPieceDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPieceDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixUnitairePieceDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockPieceDet;
        private System.Windows.Forms.Label lbMessageErreur;
    }
}