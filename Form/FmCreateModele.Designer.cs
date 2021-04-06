namespace LAB7
{
    partial class FmCreateModele
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
            this.lbCreeMarque = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbNomModele = new System.Windows.Forms.TextBox();
            this.lbMarque = new System.Windows.Forms.Label();
            this.comboxBoxMarque = new System.Windows.Forms.ComboBox();
            this.btnSubmitModele = new System.Windows.Forms.Button();
            this.lbModeleAjoute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCreeMarque
            // 
            this.lbCreeMarque.AutoSize = true;
            this.lbCreeMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreeMarque.Location = new System.Drawing.Point(272, 40);
            this.lbCreeMarque.Name = "lbCreeMarque";
            this.lbCreeMarque.Size = new System.Drawing.Size(211, 24);
            this.lbCreeMarque.TabIndex = 2;
            this.lbCreeMarque.Text = "Création d\'un modèle";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNom.Location = new System.Drawing.Point(229, 120);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(132, 20);
            this.lbNom.TabIndex = 3;
            this.lbNom.Text = "Nom du modèle : ";
            // 
            // tbNomModele
            // 
            this.tbNomModele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNomModele.Location = new System.Drawing.Point(367, 117);
            this.tbNomModele.Name = "tbNomModele";
            this.tbNomModele.Size = new System.Drawing.Size(175, 26);
            this.tbNomModele.TabIndex = 4;
            // 
            // lbMarque
            // 
            this.lbMarque.AutoSize = true;
            this.lbMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMarque.Location = new System.Drawing.Point(208, 177);
            this.lbMarque.Name = "lbMarque";
            this.lbMarque.Size = new System.Drawing.Size(153, 20);
            this.lbMarque.TabIndex = 5;
            this.lbMarque.Text = "Marque du modèle : ";
            // 
            // comboxBoxMarque
            // 
            this.comboxBoxMarque.FormattingEnabled = true;
            this.comboxBoxMarque.Location = new System.Drawing.Point(367, 176);
            this.comboxBoxMarque.Name = "comboxBoxMarque";
            this.comboxBoxMarque.Size = new System.Drawing.Size(175, 21);
            this.comboxBoxMarque.TabIndex = 6;
            // 
            // btnSubmitModele
            // 
            this.btnSubmitModele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSubmitModele.Location = new System.Drawing.Point(276, 251);
            this.btnSubmitModele.Name = "btnSubmitModele";
            this.btnSubmitModele.Size = new System.Drawing.Size(207, 53);
            this.btnSubmitModele.TabIndex = 7;
            this.btnSubmitModele.Text = "Ajouter le modèle";
            this.btnSubmitModele.UseVisualStyleBackColor = true;
            this.btnSubmitModele.Click += new System.EventHandler(this.btnSubmitModele_Click);
            // 
            // lbModeleAjoute
            // 
            this.lbModeleAjoute.AutoSize = true;
            this.lbModeleAjoute.Location = new System.Drawing.Point(276, 218);
            this.lbModeleAjoute.Name = "lbModeleAjoute";
            this.lbModeleAjoute.Size = new System.Drawing.Size(0, 13);
            this.lbModeleAjoute.TabIndex = 8;
            // 
            // FmCreateModele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbModeleAjoute);
            this.Controls.Add(this.btnSubmitModele);
            this.Controls.Add(this.comboxBoxMarque);
            this.Controls.Add(this.lbMarque);
            this.Controls.Add(this.tbNomModele);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbCreeMarque);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmCreateModele";
            this.Text = "FmCreateModele";
            this.Load += new System.EventHandler(this.FmCreateModele_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCreeMarque;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbNomModele;
        private System.Windows.Forms.Label lbMarque;
        private System.Windows.Forms.ComboBox comboxBoxMarque;
        private System.Windows.Forms.Button btnSubmitModele;
        private System.Windows.Forms.Label lbModeleAjoute;
    }
}