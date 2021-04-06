namespace LAB7
{
    partial class FmMainOeuvre
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
            this.btnActiverTaux = new System.Windows.Forms.Button();
            this.lbMessageErreur = new System.Windows.Forms.Label();
            this.lbMontantMOActif = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmitCreateMontantMO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCreateMontantMO = new System.Windows.Forms.TextBox();
            this.cbListMontantMO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnActiverTaux
            // 
            this.btnActiverTaux.Location = new System.Drawing.Point(20, 80);
            this.btnActiverTaux.Name = "btnActiverTaux";
            this.btnActiverTaux.Size = new System.Drawing.Size(161, 40);
            this.btnActiverTaux.TabIndex = 38;
            this.btnActiverTaux.Text = "Activer le montant main d\'oeuvre";
            this.btnActiverTaux.UseVisualStyleBackColor = true;
            this.btnActiverTaux.Click += new System.EventHandler(this.btnActiverTaux_Click);
            // 
            // lbMessageErreur
            // 
            this.lbMessageErreur.AutoSize = true;
            this.lbMessageErreur.Location = new System.Drawing.Point(522, 133);
            this.lbMessageErreur.Name = "lbMessageErreur";
            this.lbMessageErreur.Size = new System.Drawing.Size(0, 13);
            this.lbMessageErreur.TabIndex = 37;
            // 
            // lbMontantMOActif
            // 
            this.lbMontantMOActif.AutoSize = true;
            this.lbMontantMOActif.Location = new System.Drawing.Point(293, 55);
            this.lbMontantMOActif.Name = "lbMontantMOActif";
            this.lbMontantMOActif.Size = new System.Drawing.Size(0, 13);
            this.lbMontantMOActif.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(250, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Montant main d\'oeuvre actif";
            // 
            // btnSubmitCreateMontantMO
            // 
            this.btnSubmitCreateMontantMO.Location = new System.Drawing.Point(516, 80);
            this.btnSubmitCreateMontantMO.Name = "btnSubmitCreateMontantMO";
            this.btnSubmitCreateMontantMO.Size = new System.Drawing.Size(161, 40);
            this.btnSubmitCreateMontantMO.TabIndex = 34;
            this.btnSubmitCreateMontantMO.Text = "Ajouter le montant main d\'oeuvre";
            this.btnSubmitCreateMontantMO.UseVisualStyleBackColor = true;
            this.btnSubmitCreateMontantMO.Click += new System.EventHandler(this.btnSubmitCreateMontantMO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(512, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Créé un montant de main d\'oeuvre";
            // 
            // tbCreateMontantMO
            // 
            this.tbCreateMontantMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCreateMontantMO.Location = new System.Drawing.Point(516, 48);
            this.tbCreateMontantMO.Name = "tbCreateMontantMO";
            this.tbCreateMontantMO.Size = new System.Drawing.Size(161, 26);
            this.tbCreateMontantMO.TabIndex = 32;
            // 
            // cbListMontantMO
            // 
            this.cbListMontantMO.FormattingEnabled = true;
            this.cbListMontantMO.Location = new System.Drawing.Point(20, 48);
            this.cbListMontantMO.Name = "cbListMontantMO";
            this.cbListMontantMO.Size = new System.Drawing.Size(181, 21);
            this.cbListMontantMO.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(25, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Montant main d\'oeuvre";
            // 
            // FmMainOeuvre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActiverTaux);
            this.Controls.Add(this.lbMessageErreur);
            this.Controls.Add(this.lbMontantMOActif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmitCreateMontantMO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCreateMontantMO);
            this.Controls.Add(this.cbListMontantMO);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmMainOeuvre";
            this.Text = "FmMainOeuvre";
            this.Load += new System.EventHandler(this.FmMainOeuvre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActiverTaux;
        private System.Windows.Forms.Label lbMessageErreur;
        private System.Windows.Forms.Label lbMontantMOActif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmitCreateMontantMO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCreateMontantMO;
        private System.Windows.Forms.ComboBox cbListMontantMO;
        private System.Windows.Forms.Label label4;
    }
}