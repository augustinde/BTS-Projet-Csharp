namespace LAB7
{
    partial class FmTva
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbListTva = new System.Windows.Forms.ComboBox();
            this.tbCreateTva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitCreateTva = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTvaActif = new System.Windows.Forms.Label();
            this.lbMessageErreur = new System.Windows.Forms.Label();
            this.btnActiverTaux = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Taux TVA";
            // 
            // cbListTva
            // 
            this.cbListTva.FormattingEnabled = true;
            this.cbListTva.Location = new System.Drawing.Point(12, 45);
            this.cbListTva.Name = "cbListTva";
            this.cbListTva.Size = new System.Drawing.Size(181, 21);
            this.cbListTva.TabIndex = 21;
            // 
            // tbCreateTva
            // 
            this.tbCreateTva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCreateTva.Location = new System.Drawing.Point(508, 45);
            this.tbCreateTva.Name = "tbCreateTva";
            this.tbCreateTva.Size = new System.Drawing.Size(161, 26);
            this.tbCreateTva.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(504, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Créé un nouveau taux de TVA";
            // 
            // btnSubmitCreateTva
            // 
            this.btnSubmitCreateTva.Location = new System.Drawing.Point(508, 77);
            this.btnSubmitCreateTva.Name = "btnSubmitCreateTva";
            this.btnSubmitCreateTva.Size = new System.Drawing.Size(161, 40);
            this.btnSubmitCreateTva.TabIndex = 25;
            this.btnSubmitCreateTva.Text = "Ajouter le taux";
            this.btnSubmitCreateTva.UseVisualStyleBackColor = true;
            this.btnSubmitCreateTva.Click += new System.EventHandler(this.btnSubmitCreateTva_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(242, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Taux TVA actif";
            // 
            // lbTvaActif
            // 
            this.lbTvaActif.AutoSize = true;
            this.lbTvaActif.Location = new System.Drawing.Point(285, 52);
            this.lbTvaActif.Name = "lbTvaActif";
            this.lbTvaActif.Size = new System.Drawing.Size(0, 13);
            this.lbTvaActif.TabIndex = 27;
            // 
            // lbMessageErreur
            // 
            this.lbMessageErreur.AutoSize = true;
            this.lbMessageErreur.Location = new System.Drawing.Point(514, 130);
            this.lbMessageErreur.Name = "lbMessageErreur";
            this.lbMessageErreur.Size = new System.Drawing.Size(0, 13);
            this.lbMessageErreur.TabIndex = 28;
            // 
            // btnActiverTaux
            // 
            this.btnActiverTaux.Location = new System.Drawing.Point(12, 77);
            this.btnActiverTaux.Name = "btnActiverTaux";
            this.btnActiverTaux.Size = new System.Drawing.Size(161, 40);
            this.btnActiverTaux.TabIndex = 29;
            this.btnActiverTaux.Text = "Activer le taux";
            this.btnActiverTaux.UseVisualStyleBackColor = true;
            this.btnActiverTaux.Click += new System.EventHandler(this.btnActiverTaux_Click);
            // 
            // FmTva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActiverTaux);
            this.Controls.Add(this.lbMessageErreur);
            this.Controls.Add(this.lbTvaActif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmitCreateTva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCreateTva);
            this.Controls.Add(this.cbListTva);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmTva";
            this.Text = "FmTva";
            this.Load += new System.EventHandler(this.FmTva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbListTva;
        private System.Windows.Forms.TextBox tbCreateTva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitCreateTva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTvaActif;
        private System.Windows.Forms.Label lbMessageErreur;
        private System.Windows.Forms.Button btnActiverTaux;
    }
}