namespace LAB7
{
    partial class FmPreviewFiche
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTelClt = new System.Windows.Forms.TextBox();
            this.tbEmailClt = new System.Windows.Forms.TextBox();
            this.tbAdresseClt = new System.Windows.Forms.TextBox();
            this.tbFullNameClt = new System.Windows.Forms.TextBox();
            this.dtDateAchat = new System.Windows.Forms.DateTimePicker();
            this.lbDateAchat = new System.Windows.Forms.Label();
            this.lbDateDevis = new System.Windows.Forms.Label();
            this.dtDateDevis = new System.Windows.Forms.DateTimePicker();
            this.lbIdFiche = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNumSerie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDureeReparation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbCommentaire = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModele = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMarque = new System.Windows.Forms.TextBox();
            this.tbTva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMainOeuvre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPieceDet = new System.Windows.Forms.DataGridView();
            this.idPieceDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPieceDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbHT = new System.Windows.Forms.TextBox();
            this.tbTTC = new System.Windows.Forms.TextBox();
            this.tbStatut = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieceDet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTelClt);
            this.groupBox1.Controls.Add(this.tbEmailClt);
            this.groupBox1.Controls.Add(this.tbAdresseClt);
            this.groupBox1.Controls.Add(this.tbFullNameClt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations client";
            // 
            // tbTelClt
            // 
            this.tbTelClt.Location = new System.Drawing.Point(7, 122);
            this.tbTelClt.Name = "tbTelClt";
            this.tbTelClt.ReadOnly = true;
            this.tbTelClt.Size = new System.Drawing.Size(140, 26);
            this.tbTelClt.TabIndex = 4;
            // 
            // tbEmailClt
            // 
            this.tbEmailClt.Location = new System.Drawing.Point(7, 90);
            this.tbEmailClt.Name = "tbEmailClt";
            this.tbEmailClt.ReadOnly = true;
            this.tbEmailClt.Size = new System.Drawing.Size(140, 26);
            this.tbEmailClt.TabIndex = 3;
            // 
            // tbAdresseClt
            // 
            this.tbAdresseClt.Location = new System.Drawing.Point(7, 58);
            this.tbAdresseClt.Name = "tbAdresseClt";
            this.tbAdresseClt.ReadOnly = true;
            this.tbAdresseClt.Size = new System.Drawing.Size(234, 26);
            this.tbAdresseClt.TabIndex = 2;
            // 
            // tbFullNameClt
            // 
            this.tbFullNameClt.Location = new System.Drawing.Point(7, 26);
            this.tbFullNameClt.Name = "tbFullNameClt";
            this.tbFullNameClt.ReadOnly = true;
            this.tbFullNameClt.Size = new System.Drawing.Size(234, 26);
            this.tbFullNameClt.TabIndex = 0;
            // 
            // dtDateAchat
            // 
            this.dtDateAchat.Enabled = false;
            this.dtDateAchat.Location = new System.Drawing.Point(10, 113);
            this.dtDateAchat.Name = "dtDateAchat";
            this.dtDateAchat.Size = new System.Drawing.Size(234, 26);
            this.dtDateAchat.TabIndex = 1;
            // 
            // lbDateAchat
            // 
            this.lbDateAchat.AutoSize = true;
            this.lbDateAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateAchat.Location = new System.Drawing.Point(6, 90);
            this.lbDateAchat.Name = "lbDateAchat";
            this.lbDateAchat.Size = new System.Drawing.Size(183, 20);
            this.lbDateAchat.TabIndex = 3;
            this.lbDateAchat.Text = "Date d\'achat du produit :";
            // 
            // lbDateDevis
            // 
            this.lbDateDevis.AutoSize = true;
            this.lbDateDevis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateDevis.Location = new System.Drawing.Point(8, 224);
            this.lbDateDevis.Name = "lbDateDevis";
            this.lbDateDevis.Size = new System.Drawing.Size(128, 20);
            this.lbDateDevis.TabIndex = 5;
            this.lbDateDevis.Text = "Date de la fiche :";
            // 
            // dtDateDevis
            // 
            this.dtDateDevis.Enabled = false;
            this.dtDateDevis.Location = new System.Drawing.Point(9, 247);
            this.dtDateDevis.Name = "dtDateDevis";
            this.dtDateDevis.Size = new System.Drawing.Size(200, 20);
            this.dtDateDevis.TabIndex = 4;
            // 
            // lbIdFiche
            // 
            this.lbIdFiche.AutoSize = true;
            this.lbIdFiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdFiche.Location = new System.Drawing.Point(19, 13);
            this.lbIdFiche.Name = "lbIdFiche";
            this.lbIdFiche.Size = new System.Drawing.Size(60, 24);
            this.lbIdFiche.TabIndex = 8;
            this.lbIdFiche.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNumSerie);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbDureeReparation);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rtbCommentaire);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbModele);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbMarque);
            this.groupBox2.Controls.Add(this.lbDateAchat);
            this.groupBox2.Controls.Add(this.dtDateAchat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(265, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 392);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations produit";
            // 
            // tbNumSerie
            // 
            this.tbNumSerie.Location = new System.Drawing.Point(6, 327);
            this.tbNumSerie.Name = "tbNumSerie";
            this.tbNumSerie.ReadOnly = true;
            this.tbNumSerie.Size = new System.Drawing.Size(238, 26);
            this.tbNumSerie.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Numéro de série :";
            // 
            // tbDureeReparation
            // 
            this.tbDureeReparation.Location = new System.Drawing.Point(175, 359);
            this.tbDureeReparation.Name = "tbDureeReparation";
            this.tbDureeReparation.ReadOnly = true;
            this.tbDureeReparation.Size = new System.Drawing.Size(69, 26);
            this.tbDureeReparation.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Durée de la réparation : ";
            // 
            // rtbCommentaire
            // 
            this.rtbCommentaire.Location = new System.Drawing.Point(6, 169);
            this.rtbCommentaire.Name = "rtbCommentaire";
            this.rtbCommentaire.ReadOnly = true;
            this.rtbCommentaire.Size = new System.Drawing.Size(238, 126);
            this.rtbCommentaire.TabIndex = 14;
            this.rtbCommentaire.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Commentaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Modèle";
            // 
            // tbModele
            // 
            this.tbModele.Location = new System.Drawing.Point(75, 58);
            this.tbModele.Name = "tbModele";
            this.tbModele.ReadOnly = true;
            this.tbModele.Size = new System.Drawing.Size(140, 26);
            this.tbModele.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Marque";
            // 
            // tbMarque
            // 
            this.tbMarque.Location = new System.Drawing.Point(75, 26);
            this.tbMarque.Name = "tbMarque";
            this.tbMarque.ReadOnly = true;
            this.tbMarque.Size = new System.Drawing.Size(140, 26);
            this.tbMarque.TabIndex = 5;
            // 
            // tbTva
            // 
            this.tbTva.Location = new System.Drawing.Point(9, 302);
            this.tbTva.Name = "tbTva";
            this.tbTva.ReadOnly = true;
            this.tbTva.Size = new System.Drawing.Size(99, 20);
            this.tbTva.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Montant TVA";
            // 
            // tbMainOeuvre
            // 
            this.tbMainOeuvre.Location = new System.Drawing.Point(9, 351);
            this.tbMainOeuvre.Name = "tbMainOeuvre";
            this.tbMainOeuvre.ReadOnly = true;
            this.tbMainOeuvre.Size = new System.Drawing.Size(99, 20);
            this.tbMainOeuvre.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Montant main d\'oeuvre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(521, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Pièces détachées";
            // 
            // dgvPieceDet
            // 
            this.dgvPieceDet.AllowUserToAddRows = false;
            this.dgvPieceDet.AllowUserToDeleteRows = false;
            this.dgvPieceDet.AllowUserToResizeColumns = false;
            this.dgvPieceDet.AllowUserToResizeRows = false;
            this.dgvPieceDet.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPieceDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPieceDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPieceDet,
            this.nomPieceDet,
            this.quantite,
            this.prixTotal});
            this.dgvPieceDet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPieceDet.Location = new System.Drawing.Point(521, 69);
            this.dgvPieceDet.Name = "dgvPieceDet";
            this.dgvPieceDet.ReadOnly = true;
            this.dgvPieceDet.Size = new System.Drawing.Size(267, 244);
            this.dgvPieceDet.TabIndex = 23;
            // 
            // idPieceDet
            // 
            this.idPieceDet.DataPropertyName = "idPieceDet";
            this.idPieceDet.HeaderText = "Id";
            this.idPieceDet.Name = "idPieceDet";
            this.idPieceDet.ReadOnly = true;
            this.idPieceDet.Visible = false;
            this.idPieceDet.Width = 25;
            // 
            // nomPieceDet
            // 
            this.nomPieceDet.DataPropertyName = "nomPieceDet";
            this.nomPieceDet.HeaderText = "Libelle";
            this.nomPieceDet.Name = "nomPieceDet";
            this.nomPieceDet.ReadOnly = true;
            this.nomPieceDet.Width = 75;
            // 
            // quantite
            // 
            this.quantite.DataPropertyName = "quantite";
            this.quantite.HeaderText = "Quantite";
            this.quantite.Name = "quantite";
            this.quantite.ReadOnly = true;
            this.quantite.Width = 75;
            // 
            // prixTotal
            // 
            this.prixTotal.DataPropertyName = "prixTotal";
            this.prixTotal.HeaderText = "Total";
            this.prixTotal.Name = "prixTotal";
            this.prixTotal.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(517, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Total HT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(521, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Total TTC";
            // 
            // tbHT
            // 
            this.tbHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHT.Location = new System.Drawing.Point(525, 344);
            this.tbHT.Name = "tbHT";
            this.tbHT.ReadOnly = true;
            this.tbHT.Size = new System.Drawing.Size(140, 26);
            this.tbHT.TabIndex = 17;
            // 
            // tbTTC
            // 
            this.tbTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTTC.Location = new System.Drawing.Point(525, 399);
            this.tbTTC.Name = "tbTTC";
            this.tbTTC.ReadOnly = true;
            this.tbTTC.Size = new System.Drawing.Size(140, 26);
            this.tbTTC.TabIndex = 26;
            // 
            // tbStatut
            // 
            this.tbStatut.Location = new System.Drawing.Point(9, 399);
            this.tbStatut.Name = "tbStatut";
            this.tbStatut.ReadOnly = true;
            this.tbStatut.Size = new System.Drawing.Size(166, 20);
            this.tbStatut.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Statut :";
            // 
            // FmPreviewFiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbStatut);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbTTC);
            this.Controls.Add(this.tbHT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvPieceDet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMainOeuvre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbIdFiche);
            this.Controls.Add(this.lbDateDevis);
            this.Controls.Add(this.dtDateDevis);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FmPreviewFiche";
            this.Text = "Prévisualisation de la fiche";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieceDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTelClt;
        private System.Windows.Forms.TextBox tbEmailClt;
        private System.Windows.Forms.TextBox tbAdresseClt;
        private System.Windows.Forms.TextBox tbFullNameClt;
        private System.Windows.Forms.DateTimePicker dtDateAchat;
        private System.Windows.Forms.Label lbDateAchat;
        private System.Windows.Forms.Label lbDateDevis;
        private System.Windows.Forms.DateTimePicker dtDateDevis;
        private System.Windows.Forms.Label lbIdFiche;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMarque;
        private System.Windows.Forms.RichTextBox rtbCommentaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDureeReparation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMainOeuvre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPieceDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPieceDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPieceDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbHT;
        private System.Windows.Forms.TextBox tbTTC;
        private System.Windows.Forms.TextBox tbNumSerie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbStatut;
        private System.Windows.Forms.Label label11;
    }
}