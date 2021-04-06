namespace LAB7
{
    partial class FmAddPiece
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
            this.btnAddPiece = new System.Windows.Forms.Button();
            this.cbPieceDet = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPrixUnitaire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbCoutTotal = new System.Windows.Forms.TextBox();
            this.lbMessageError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.dataGridViewPieceDeta = new System.Windows.Forms.DataGridView();
            this.idPieceDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPieceDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbIdClient = new System.Windows.Forms.Label();
            this.lbNomClient = new System.Windows.Forms.Label();
            this.lbPrenomClient = new System.Windows.Forms.Label();
            this.lbAdresseClient = new System.Windows.Forms.Label();
            this.lbCpClient = new System.Windows.Forms.Label();
            this.lbVilleClient = new System.Windows.Forms.Label();
            this.lbEmailClient = new System.Windows.Forms.Label();
            this.lbTelClient = new System.Windows.Forms.Label();
            this.lbIdMarque = new System.Windows.Forms.Label();
            this.lbNomMarque = new System.Windows.Forms.Label();
            this.lbNomModele = new System.Windows.Forms.Label();
            this.lbIdModele = new System.Windows.Forms.Label();
            this.rtbCommentaire = new System.Windows.Forms.RichTextBox();
            this.datetimeDateAchat = new System.Windows.Forms.DateTimePicker();
            this.lbDureeReparation = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbNumSerie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPieceDeta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPiece
            // 
            this.btnAddPiece.Location = new System.Drawing.Point(74, 176);
            this.btnAddPiece.Name = "btnAddPiece";
            this.btnAddPiece.Size = new System.Drawing.Size(165, 23);
            this.btnAddPiece.TabIndex = 0;
            this.btnAddPiece.Text = "Ajouter à la fiche de réparation";
            this.btnAddPiece.UseVisualStyleBackColor = true;
            this.btnAddPiece.Click += new System.EventHandler(this.btnAddPiece_Click);
            // 
            // cbPieceDet
            // 
            this.cbPieceDet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPieceDet.FormattingEnabled = true;
            this.cbPieceDet.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbPieceDet.Location = new System.Drawing.Point(141, 43);
            this.cbPieceDet.Name = "cbPieceDet";
            this.cbPieceDet.Size = new System.Drawing.Size(121, 21);
            this.cbPieceDet.TabIndex = 1;
            this.cbPieceDet.SelectedIndexChanged += new System.EventHandler(this.cbPieceDet_SelectedIndexChanged_1);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(141, 70);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(121, 20);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbPrixUnitaire
            // 
            this.tbPrixUnitaire.Enabled = false;
            this.tbPrixUnitaire.Location = new System.Drawing.Point(141, 96);
            this.tbPrixUnitaire.Name = "tbPrixUnitaire";
            this.tbPrixUnitaire.ReadOnly = true;
            this.tbPrixUnitaire.Size = new System.Drawing.Size(121, 20);
            this.tbPrixUnitaire.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom de la pièce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(45, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prix unitaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(70, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(64, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "En stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(57, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Coût total";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(26, 218);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 13);
            this.lbId.TabIndex = 11;
            this.lbId.Visible = false;
            // 
            // tbStock
            // 
            this.tbStock.Enabled = false;
            this.tbStock.Location = new System.Drawing.Point(141, 122);
            this.tbStock.Name = "tbStock";
            this.tbStock.ReadOnly = true;
            this.tbStock.Size = new System.Drawing.Size(121, 20);
            this.tbStock.TabIndex = 12;
            // 
            // tbCoutTotal
            // 
            this.tbCoutTotal.Enabled = false;
            this.tbCoutTotal.Location = new System.Drawing.Point(141, 148);
            this.tbCoutTotal.Name = "tbCoutTotal";
            this.tbCoutTotal.ReadOnly = true;
            this.tbCoutTotal.Size = new System.Drawing.Size(121, 20);
            this.tbCoutTotal.TabIndex = 13;
            // 
            // lbMessageError
            // 
            this.lbMessageError.AutoSize = true;
            this.lbMessageError.Location = new System.Drawing.Point(132, 218);
            this.lbMessageError.Name = "lbMessageError";
            this.lbMessageError.Size = new System.Drawing.Size(0, 13);
            this.lbMessageError.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 15;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(288, 356);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(168, 23);
            this.btnSuivant.TabIndex = 16;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
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
            this.quantite,
            this.Prix});
            this.dataGridViewPieceDeta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewPieceDeta.Location = new System.Drawing.Point(365, 61);
            this.dataGridViewPieceDeta.Name = "dataGridViewPieceDeta";
            this.dataGridViewPieceDeta.ReadOnly = true;
            this.dataGridViewPieceDeta.Size = new System.Drawing.Size(298, 192);
            this.dataGridViewPieceDeta.TabIndex = 19;
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
            // quantite
            // 
            this.quantite.DataPropertyName = "quantite";
            this.quantite.HeaderText = "Quantite";
            this.quantite.Name = "quantite";
            this.quantite.ReadOnly = true;
            this.quantite.Width = 50;
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "prix";
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            this.Prix.Width = 50;
            // 
            // lbIdClient
            // 
            this.lbIdClient.AutoSize = true;
            this.lbIdClient.Location = new System.Drawing.Point(29, 260);
            this.lbIdClient.Name = "lbIdClient";
            this.lbIdClient.Size = new System.Drawing.Size(0, 13);
            this.lbIdClient.TabIndex = 20;
            this.lbIdClient.Visible = false;
            // 
            // lbNomClient
            // 
            this.lbNomClient.AutoSize = true;
            this.lbNomClient.Location = new System.Drawing.Point(29, 273);
            this.lbNomClient.Name = "lbNomClient";
            this.lbNomClient.Size = new System.Drawing.Size(0, 13);
            this.lbNomClient.TabIndex = 21;
            this.lbNomClient.Visible = false;
            // 
            // lbPrenomClient
            // 
            this.lbPrenomClient.AutoSize = true;
            this.lbPrenomClient.Location = new System.Drawing.Point(29, 286);
            this.lbPrenomClient.Name = "lbPrenomClient";
            this.lbPrenomClient.Size = new System.Drawing.Size(0, 13);
            this.lbPrenomClient.TabIndex = 22;
            this.lbPrenomClient.Visible = false;
            // 
            // lbAdresseClient
            // 
            this.lbAdresseClient.AutoSize = true;
            this.lbAdresseClient.Location = new System.Drawing.Point(29, 299);
            this.lbAdresseClient.Name = "lbAdresseClient";
            this.lbAdresseClient.Size = new System.Drawing.Size(0, 13);
            this.lbAdresseClient.TabIndex = 23;
            this.lbAdresseClient.Visible = false;
            // 
            // lbCpClient
            // 
            this.lbCpClient.AutoSize = true;
            this.lbCpClient.Location = new System.Drawing.Point(29, 312);
            this.lbCpClient.Name = "lbCpClient";
            this.lbCpClient.Size = new System.Drawing.Size(0, 13);
            this.lbCpClient.TabIndex = 24;
            this.lbCpClient.Visible = false;
            // 
            // lbVilleClient
            // 
            this.lbVilleClient.AutoSize = true;
            this.lbVilleClient.Location = new System.Drawing.Point(29, 325);
            this.lbVilleClient.Name = "lbVilleClient";
            this.lbVilleClient.Size = new System.Drawing.Size(0, 13);
            this.lbVilleClient.TabIndex = 25;
            this.lbVilleClient.Visible = false;
            // 
            // lbEmailClient
            // 
            this.lbEmailClient.AutoSize = true;
            this.lbEmailClient.Location = new System.Drawing.Point(29, 338);
            this.lbEmailClient.Name = "lbEmailClient";
            this.lbEmailClient.Size = new System.Drawing.Size(0, 13);
            this.lbEmailClient.TabIndex = 26;
            this.lbEmailClient.Visible = false;
            // 
            // lbTelClient
            // 
            this.lbTelClient.AutoSize = true;
            this.lbTelClient.Location = new System.Drawing.Point(29, 351);
            this.lbTelClient.Name = "lbTelClient";
            this.lbTelClient.Size = new System.Drawing.Size(0, 13);
            this.lbTelClient.TabIndex = 27;
            this.lbTelClient.Visible = false;
            // 
            // lbIdMarque
            // 
            this.lbIdMarque.AutoSize = true;
            this.lbIdMarque.Location = new System.Drawing.Point(80, 260);
            this.lbIdMarque.Name = "lbIdMarque";
            this.lbIdMarque.Size = new System.Drawing.Size(0, 13);
            this.lbIdMarque.TabIndex = 28;
            this.lbIdMarque.Visible = false;
            // 
            // lbNomMarque
            // 
            this.lbNomMarque.AutoSize = true;
            this.lbNomMarque.Location = new System.Drawing.Point(80, 273);
            this.lbNomMarque.Name = "lbNomMarque";
            this.lbNomMarque.Size = new System.Drawing.Size(0, 13);
            this.lbNomMarque.TabIndex = 29;
            this.lbNomMarque.Visible = false;
            // 
            // lbNomModele
            // 
            this.lbNomModele.AutoSize = true;
            this.lbNomModele.Location = new System.Drawing.Point(121, 273);
            this.lbNomModele.Name = "lbNomModele";
            this.lbNomModele.Size = new System.Drawing.Size(0, 13);
            this.lbNomModele.TabIndex = 30;
            this.lbNomModele.Visible = false;
            // 
            // lbIdModele
            // 
            this.lbIdModele.AutoSize = true;
            this.lbIdModele.Location = new System.Drawing.Point(121, 260);
            this.lbIdModele.Name = "lbIdModele";
            this.lbIdModele.Size = new System.Drawing.Size(0, 13);
            this.lbIdModele.TabIndex = 31;
            this.lbIdModele.Visible = false;
            // 
            // rtbCommentaire
            // 
            this.rtbCommentaire.Location = new System.Drawing.Point(241, 242);
            this.rtbCommentaire.Name = "rtbCommentaire";
            this.rtbCommentaire.Size = new System.Drawing.Size(100, 96);
            this.rtbCommentaire.TabIndex = 32;
            this.rtbCommentaire.Text = "";
            this.rtbCommentaire.Visible = false;
            // 
            // datetimeDateAchat
            // 
            this.datetimeDateAchat.Location = new System.Drawing.Point(83, 306);
            this.datetimeDateAchat.Name = "datetimeDateAchat";
            this.datetimeDateAchat.Size = new System.Drawing.Size(143, 20);
            this.datetimeDateAchat.TabIndex = 33;
            this.datetimeDateAchat.Visible = false;
            // 
            // lbDureeReparation
            // 
            this.lbDureeReparation.AutoSize = true;
            this.lbDureeReparation.Location = new System.Drawing.Point(121, 286);
            this.lbDureeReparation.Name = "lbDureeReparation";
            this.lbDureeReparation.Size = new System.Drawing.Size(0, 13);
            this.lbDureeReparation.TabIndex = 34;
            this.lbDureeReparation.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "label7";
            // 
            // lbNumSerie
            // 
            this.lbNumSerie.AutoSize = true;
            this.lbNumSerie.Location = new System.Drawing.Point(185, 366);
            this.lbNumSerie.Name = "lbNumSerie";
            this.lbNumSerie.Size = new System.Drawing.Size(0, 13);
            this.lbNumSerie.TabIndex = 36;
            this.lbNumSerie.Visible = false;
            // 
            // FmAddPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 391);
            this.Controls.Add(this.lbNumSerie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbDureeReparation);
            this.Controls.Add(this.datetimeDateAchat);
            this.Controls.Add(this.rtbCommentaire);
            this.Controls.Add(this.lbIdModele);
            this.Controls.Add(this.lbNomModele);
            this.Controls.Add(this.lbNomMarque);
            this.Controls.Add(this.lbIdMarque);
            this.Controls.Add(this.lbTelClient);
            this.Controls.Add(this.lbEmailClient);
            this.Controls.Add(this.lbVilleClient);
            this.Controls.Add(this.lbCpClient);
            this.Controls.Add(this.lbAdresseClient);
            this.Controls.Add(this.lbPrenomClient);
            this.Controls.Add(this.lbNomClient);
            this.Controls.Add(this.lbIdClient);
            this.Controls.Add(this.dataGridViewPieceDeta);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbMessageError);
            this.Controls.Add(this.tbCoutTotal);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrixUnitaire);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.cbPieceDet);
            this.Controls.Add(this.btnAddPiece);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmAddPiece";
            this.Text = "Ajout de pièce";
            this.Load += new System.EventHandler(this.FmAddPiece_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPieceDeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPiece;
        private System.Windows.Forms.ComboBox cbPieceDet;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbPrixUnitaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbCoutTotal;
        private System.Windows.Forms.Label lbMessageError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.DataGridView dataGridViewPieceDeta;
        private System.Windows.Forms.Label lbIdClient;
        private System.Windows.Forms.Label lbNomClient;
        private System.Windows.Forms.Label lbPrenomClient;
        private System.Windows.Forms.Label lbAdresseClient;
        private System.Windows.Forms.Label lbCpClient;
        private System.Windows.Forms.Label lbVilleClient;
        private System.Windows.Forms.Label lbEmailClient;
        private System.Windows.Forms.Label lbTelClient;
        private System.Windows.Forms.Label lbIdMarque;
        private System.Windows.Forms.Label lbNomMarque;
        private System.Windows.Forms.Label lbNomModele;
        private System.Windows.Forms.Label lbIdModele;
        private System.Windows.Forms.RichTextBox rtbCommentaire;
        private System.Windows.Forms.DateTimePicker datetimeDateAchat;
        private System.Windows.Forms.Label lbDureeReparation;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPieceDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPieceDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbNumSerie;
    }
}