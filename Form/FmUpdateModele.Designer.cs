namespace LAB7
{
    partial class FmUpdateModele
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
            this.lbMessageErreur = new System.Windows.Forms.Label();
            this.btSupprimerModele = new System.Windows.Forms.Button();
            this.btUpdateModele = new System.Windows.Forms.Button();
            this.lbNomMarque = new System.Windows.Forms.Label();
            this.tbNomModele = new System.Windows.Forms.TextBox();
            this.btSubmitNumeroModele = new System.Windows.Forms.Button();
            this.lbUpdateMarque = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbIdModele = new System.Windows.Forms.Label();
            this.tbMarque = new System.Windows.Forms.TextBox();
            this.lbMarque = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMessageErreur
            // 
            this.lbMessageErreur.AutoSize = true;
            this.lbMessageErreur.Location = new System.Drawing.Point(296, 176);
            this.lbMessageErreur.Name = "lbMessageErreur";
            this.lbMessageErreur.Size = new System.Drawing.Size(0, 13);
            this.lbMessageErreur.TabIndex = 29;
            // 
            // btSupprimerModele
            // 
            this.btSupprimerModele.Location = new System.Drawing.Point(312, 249);
            this.btSupprimerModele.Name = "btSupprimerModele";
            this.btSupprimerModele.Size = new System.Drawing.Size(172, 26);
            this.btSupprimerModele.TabIndex = 28;
            this.btSupprimerModele.Text = "Supprimer le modèle";
            this.btSupprimerModele.UseVisualStyleBackColor = true;
            this.btSupprimerModele.Click += new System.EventHandler(this.btSupprimerModele_Click);
            // 
            // btUpdateModele
            // 
            this.btUpdateModele.Location = new System.Drawing.Point(134, 249);
            this.btUpdateModele.Name = "btUpdateModele";
            this.btUpdateModele.Size = new System.Drawing.Size(172, 26);
            this.btUpdateModele.TabIndex = 27;
            this.btUpdateModele.Text = "Modifier le modèle";
            this.btUpdateModele.UseVisualStyleBackColor = true;
            this.btUpdateModele.Click += new System.EventHandler(this.btUpdateModele_Click);
            // 
            // lbNomMarque
            // 
            this.lbNomMarque.AutoSize = true;
            this.lbNomMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNomMarque.Location = new System.Drawing.Point(145, 131);
            this.lbNomMarque.Name = "lbNomMarque";
            this.lbNomMarque.Size = new System.Drawing.Size(54, 20);
            this.lbNomMarque.TabIndex = 26;
            this.lbNomMarque.Text = "Nom : ";
            // 
            // tbNomModele
            // 
            this.tbNomModele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNomModele.Location = new System.Drawing.Point(205, 128);
            this.tbNomModele.Name = "tbNomModele";
            this.tbNomModele.Size = new System.Drawing.Size(172, 26);
            this.tbNomModele.TabIndex = 25;
            // 
            // btSubmitNumeroModele
            // 
            this.btSubmitNumeroModele.Location = new System.Drawing.Point(388, 69);
            this.btSubmitNumeroModele.Name = "btSubmitNumeroModele";
            this.btSubmitNumeroModele.Size = new System.Drawing.Size(90, 33);
            this.btSubmitNumeroModele.TabIndex = 24;
            this.btSubmitNumeroModele.Text = "Récupérer";
            this.btSubmitNumeroModele.UseVisualStyleBackColor = true;
            this.btSubmitNumeroModele.Click += new System.EventHandler(this.btSubmitNumeroModele_Click);
            // 
            // lbUpdateMarque
            // 
            this.lbUpdateMarque.AutoSize = true;
            this.lbUpdateMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbUpdateMarque.Location = new System.Drawing.Point(117, 77);
            this.lbUpdateMarque.Name = "lbUpdateMarque";
            this.lbUpdateMarque.Size = new System.Drawing.Size(138, 20);
            this.lbUpdateMarque.TabIndex = 22;
            this.lbUpdateMarque.Text = "Choix du modèle : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbIdModele
            // 
            this.lbIdModele.AutoSize = true;
            this.lbIdModele.Location = new System.Drawing.Point(98, 83);
            this.lbIdModele.Name = "lbIdModele";
            this.lbIdModele.Size = new System.Drawing.Size(0, 13);
            this.lbIdModele.TabIndex = 31;
            this.lbIdModele.Visible = false;
            // 
            // tbMarque
            // 
            this.tbMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbMarque.Location = new System.Drawing.Point(205, 160);
            this.tbMarque.Name = "tbMarque";
            this.tbMarque.Size = new System.Drawing.Size(172, 26);
            this.tbMarque.TabIndex = 32;
            // 
            // lbMarque
            // 
            this.lbMarque.AutoSize = true;
            this.lbMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMarque.Location = new System.Drawing.Point(124, 163);
            this.lbMarque.Name = "lbMarque";
            this.lbMarque.Size = new System.Drawing.Size(75, 20);
            this.lbMarque.TabIndex = 33;
            this.lbMarque.Text = "Marque : ";
            // 
            // FmUpdateModele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMarque);
            this.Controls.Add(this.tbMarque);
            this.Controls.Add(this.lbIdModele);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbMessageErreur);
            this.Controls.Add(this.btSupprimerModele);
            this.Controls.Add(this.btUpdateModele);
            this.Controls.Add(this.lbNomMarque);
            this.Controls.Add(this.tbNomModele);
            this.Controls.Add(this.btSubmitNumeroModele);
            this.Controls.Add(this.lbUpdateMarque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmUpdateModele";
            this.Text = "FmUpdateModele";
            this.Load += new System.EventHandler(this.FmUpdateModele_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMessageErreur;
        private System.Windows.Forms.Button btSupprimerModele;
        private System.Windows.Forms.Button btUpdateModele;
        private System.Windows.Forms.Label lbNomMarque;
        private System.Windows.Forms.TextBox tbNomModele;
        private System.Windows.Forms.Button btSubmitNumeroModele;
        private System.Windows.Forms.Label lbUpdateMarque;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbIdModele;
        private System.Windows.Forms.TextBox tbMarque;
        private System.Windows.Forms.Label lbMarque;
    }
}