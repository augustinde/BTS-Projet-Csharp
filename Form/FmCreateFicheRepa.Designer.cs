namespace LAB7
{
    partial class FmCreateFicheRepa
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.lbCp = new System.Windows.Forms.Label();
            this.lbVille = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMarque = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxModele = new System.Windows.Forms.ComboBox();
            this.lbNomMarque = new System.Windows.Forms.Label();
            this.lbNomModele = new System.Windows.Forms.Label();
            this.tbCommentaire = new System.Windows.Forms.TextBox();
            this.btnSubmitCreateFiche = new System.Windows.Forms.Button();
            this.dateTimeAchat = new System.Windows.Forms.DateTimePicker();
            this.tbDureeReparation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumSerie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(173, 32);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 13);
            this.lb1.TabIndex = 2;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(13, 185);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(0, 13);
            this.lbNom.TabIndex = 3;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(13, 167);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 13);
            this.lbId.TabIndex = 4;
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Location = new System.Drawing.Point(13, 204);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(0, 13);
            this.lbPrenom.TabIndex = 5;
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Location = new System.Drawing.Point(13, 229);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(0, 13);
            this.lbAdresse.TabIndex = 6;
            // 
            // lbCp
            // 
            this.lbCp.AutoSize = true;
            this.lbCp.Location = new System.Drawing.Point(13, 253);
            this.lbCp.Name = "lbCp";
            this.lbCp.Size = new System.Drawing.Size(0, 13);
            this.lbCp.TabIndex = 7;
            // 
            // lbVille
            // 
            this.lbVille.AutoSize = true;
            this.lbVille.Location = new System.Drawing.Point(13, 275);
            this.lbVille.Name = "lbVille";
            this.lbVille.Size = new System.Drawing.Size(0, 13);
            this.lbVille.TabIndex = 8;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(12, 299);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(0, 13);
            this.lbEmail.TabIndex = 9;
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Location = new System.Drawing.Point(13, 323);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(0, 13);
            this.lbTel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choix du client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(220, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Choix de la marque";
            // 
            // comboBoxMarque
            // 
            this.comboBoxMarque.FormattingEnabled = true;
            this.comboBoxMarque.Location = new System.Drawing.Point(224, 32);
            this.comboBoxMarque.Name = "comboBoxMarque";
            this.comboBoxMarque.Size = new System.Drawing.Size(155, 21);
            this.comboBoxMarque.TabIndex = 12;
            this.comboBoxMarque.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarque_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(404, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Choix du modèle";
            // 
            // comboBoxModele
            // 
            this.comboBoxModele.FormattingEnabled = true;
            this.comboBoxModele.Location = new System.Drawing.Point(408, 32);
            this.comboBoxModele.Name = "comboBoxModele";
            this.comboBoxModele.Size = new System.Drawing.Size(155, 21);
            this.comboBoxModele.TabIndex = 15;
            this.comboBoxModele.SelectedIndexChanged += new System.EventHandler(this.comboBoxModele_SelectedIndexChanged);
            // 
            // lbNomMarque
            // 
            this.lbNomMarque.AutoSize = true;
            this.lbNomMarque.Location = new System.Drawing.Point(15, 355);
            this.lbNomMarque.Name = "lbNomMarque";
            this.lbNomMarque.Size = new System.Drawing.Size(0, 13);
            this.lbNomMarque.TabIndex = 17;
            // 
            // lbNomModele
            // 
            this.lbNomModele.AutoSize = true;
            this.lbNomModele.Location = new System.Drawing.Point(12, 389);
            this.lbNomModele.Name = "lbNomModele";
            this.lbNomModele.Size = new System.Drawing.Size(0, 13);
            this.lbNomModele.TabIndex = 18;
            // 
            // tbCommentaire
            // 
            this.tbCommentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCommentaire.Location = new System.Drawing.Point(434, 77);
            this.tbCommentaire.MaxLength = 255;
            this.tbCommentaire.Multiline = true;
            this.tbCommentaire.Name = "tbCommentaire";
            this.tbCommentaire.Size = new System.Drawing.Size(354, 103);
            this.tbCommentaire.TabIndex = 19;
            // 
            // btnSubmitCreateFiche
            // 
            this.btnSubmitCreateFiche.Location = new System.Drawing.Point(318, 362);
            this.btnSubmitCreateFiche.Name = "btnSubmitCreateFiche";
            this.btnSubmitCreateFiche.Size = new System.Drawing.Size(153, 40);
            this.btnSubmitCreateFiche.TabIndex = 20;
            this.btnSubmitCreateFiche.Text = "Suivant";
            this.btnSubmitCreateFiche.UseVisualStyleBackColor = true;
            this.btnSubmitCreateFiche.Click += new System.EventHandler(this.btnSubmitCreateFiche_Click);
            // 
            // dateTimeAchat
            // 
            this.dateTimeAchat.Location = new System.Drawing.Point(588, 33);
            this.dateTimeAchat.Name = "dateTimeAchat";
            this.dateTimeAchat.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAchat.TabIndex = 21;
            // 
            // tbDureeReparation
            // 
            this.tbDureeReparation.Location = new System.Drawing.Point(434, 222);
            this.tbDureeReparation.Name = "tbDureeReparation";
            this.tbDureeReparation.Size = new System.Drawing.Size(100, 20);
            this.tbDureeReparation.TabIndex = 22;
            this.tbDureeReparation.TextChanged += new System.EventHandler(this.tbDureeReparation_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(430, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Durée de la réparation (en heures)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(430, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Numéro de série";
            // 
            // tbNumSerie
            // 
            this.tbNumSerie.Location = new System.Drawing.Point(434, 278);
            this.tbNumSerie.Name = "tbNumSerie";
            this.tbNumSerie.Size = new System.Drawing.Size(100, 20);
            this.tbNumSerie.TabIndex = 24;
            // 
            // FmCreateFicheRepa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNumSerie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDureeReparation);
            this.Controls.Add(this.dateTimeAchat);
            this.Controls.Add(this.btnSubmitCreateFiche);
            this.Controls.Add(this.tbCommentaire);
            this.Controls.Add(this.lbNomModele);
            this.Controls.Add(this.lbNomMarque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxModele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMarque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbVille);
            this.Controls.Add(this.lbCp);
            this.Controls.Add(this.lbAdresse);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmCreateFicheRepa";
            this.Text = "FmCreateFicheRepa";
            this.Load += new System.EventHandler(this.FmCreateFicheRepa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.Label lbCp;
        private System.Windows.Forms.Label lbVille;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMarque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxModele;
        private System.Windows.Forms.Label lbNomMarque;
        private System.Windows.Forms.Label lbNomModele;
        private System.Windows.Forms.TextBox tbCommentaire;
        private System.Windows.Forms.Button btnSubmitCreateFiche;
        private System.Windows.Forms.DateTimePicker dateTimeAchat;
        private System.Windows.Forms.TextBox tbDureeReparation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumSerie;
    }
}