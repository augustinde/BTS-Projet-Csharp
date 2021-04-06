namespace LAB7
{
    partial class FmUpdateMarque
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
            this.btSubmitNumeroMarque = new System.Windows.Forms.Button();
            this.lbUpdateMarque = new System.Windows.Forms.Label();
            this.tbNomMarque = new System.Windows.Forms.TextBox();
            this.lbNomMarque = new System.Windows.Forms.Label();
            this.btUpdateMarque = new System.Windows.Forms.Button();
            this.btSupprimerMarque = new System.Windows.Forms.Button();
            this.lbMessageErreur = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbIdMarque = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSubmitNumeroMarque
            // 
            this.btSubmitNumeroMarque.Location = new System.Drawing.Point(418, 29);
            this.btSubmitNumeroMarque.Name = "btSubmitNumeroMarque";
            this.btSubmitNumeroMarque.Size = new System.Drawing.Size(73, 26);
            this.btSubmitNumeroMarque.TabIndex = 5;
            this.btSubmitNumeroMarque.Text = "Récupérer";
            this.btSubmitNumeroMarque.UseVisualStyleBackColor = true;
            this.btSubmitNumeroMarque.Click += new System.EventHandler(this.btSubmitNumeroMarque_Click);
            // 
            // lbUpdateMarque
            // 
            this.lbUpdateMarque.AutoSize = true;
            this.lbUpdateMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbUpdateMarque.Location = new System.Drawing.Point(86, 33);
            this.lbUpdateMarque.Name = "lbUpdateMarque";
            this.lbUpdateMarque.Size = new System.Drawing.Size(156, 20);
            this.lbUpdateMarque.TabIndex = 3;
            this.lbUpdateMarque.Text = "Choix de la marque : ";
            // 
            // tbNomMarque
            // 
            this.tbNomMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNomMarque.Location = new System.Drawing.Point(265, 82);
            this.tbNomMarque.Name = "tbNomMarque";
            this.tbNomMarque.Size = new System.Drawing.Size(172, 26);
            this.tbNomMarque.TabIndex = 6;
            // 
            // lbNomMarque
            // 
            this.lbNomMarque.AutoSize = true;
            this.lbNomMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNomMarque.Location = new System.Drawing.Point(205, 88);
            this.lbNomMarque.Name = "lbNomMarque";
            this.lbNomMarque.Size = new System.Drawing.Size(54, 20);
            this.lbNomMarque.TabIndex = 12;
            this.lbNomMarque.Text = "Nom : ";
            // 
            // btUpdateMarque
            // 
            this.btUpdateMarque.Location = new System.Drawing.Point(158, 175);
            this.btUpdateMarque.Name = "btUpdateMarque";
            this.btUpdateMarque.Size = new System.Drawing.Size(172, 26);
            this.btUpdateMarque.TabIndex = 19;
            this.btUpdateMarque.Text = "Modifier la marque";
            this.btUpdateMarque.UseVisualStyleBackColor = true;
            this.btUpdateMarque.Click += new System.EventHandler(this.btUpdateMarque_Click);
            // 
            // btSupprimerMarque
            // 
            this.btSupprimerMarque.Location = new System.Drawing.Point(336, 175);
            this.btSupprimerMarque.Name = "btSupprimerMarque";
            this.btSupprimerMarque.Size = new System.Drawing.Size(172, 26);
            this.btSupprimerMarque.TabIndex = 20;
            this.btSupprimerMarque.Text = "Supprimer la marque";
            this.btSupprimerMarque.UseVisualStyleBackColor = true;
            this.btSupprimerMarque.Click += new System.EventHandler(this.btSupprimerMarque_Click);
            // 
            // lbMessageErreur
            // 
            this.lbMessageErreur.AutoSize = true;
            this.lbMessageErreur.Location = new System.Drawing.Point(265, 133);
            this.lbMessageErreur.Name = "lbMessageErreur";
            this.lbMessageErreur.Size = new System.Drawing.Size(0, 13);
            this.lbMessageErreur.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(248, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbIdMarque
            // 
            this.lbIdMarque.AutoSize = true;
            this.lbIdMarque.Location = new System.Drawing.Point(13, 82);
            this.lbIdMarque.Name = "lbIdMarque";
            this.lbIdMarque.Size = new System.Drawing.Size(0, 13);
            this.lbIdMarque.TabIndex = 23;
            this.lbIdMarque.Visible = false;
            // 
            // FmUpdateMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbIdMarque);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbMessageErreur);
            this.Controls.Add(this.btSupprimerMarque);
            this.Controls.Add(this.btUpdateMarque);
            this.Controls.Add(this.lbNomMarque);
            this.Controls.Add(this.tbNomMarque);
            this.Controls.Add(this.btSubmitNumeroMarque);
            this.Controls.Add(this.lbUpdateMarque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmUpdateMarque";
            this.Text = "FmUpdateMarque";
            this.Load += new System.EventHandler(this.FmUpdateMarque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSubmitNumeroMarque;
        private System.Windows.Forms.Label lbUpdateMarque;
        private System.Windows.Forms.TextBox tbNomMarque;
        private System.Windows.Forms.Label lbNomMarque;
        private System.Windows.Forms.Button btUpdateMarque;
        private System.Windows.Forms.Button btSupprimerMarque;
        private System.Windows.Forms.Label lbMessageErreur;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbIdMarque;
    }
}