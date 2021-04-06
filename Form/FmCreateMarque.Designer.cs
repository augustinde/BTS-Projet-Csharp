namespace LAB7
{
    partial class FmCreateMarque
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
            this.tbNomMarque = new System.Windows.Forms.TextBox();
            this.lbNomMarque = new System.Windows.Forms.Label();
            this.btnCreateMarque = new System.Windows.Forms.Button();
            this.lbMarqueAjoute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCreeMarque
            // 
            this.lbCreeMarque.AutoSize = true;
            this.lbCreeMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreeMarque.Location = new System.Drawing.Point(252, 52);
            this.lbCreeMarque.Name = "lbCreeMarque";
            this.lbCreeMarque.Size = new System.Drawing.Size(224, 24);
            this.lbCreeMarque.TabIndex = 1;
            this.lbCreeMarque.Text = "Création d\'une marque";
            // 
            // tbNomMarque
            // 
            this.tbNomMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNomMarque.Location = new System.Drawing.Point(406, 114);
            this.tbNomMarque.Name = "tbNomMarque";
            this.tbNomMarque.Size = new System.Drawing.Size(100, 26);
            this.tbNomMarque.TabIndex = 2;
            this.tbNomMarque.Text = "Airbus";
            // 
            // lbNomMarque
            // 
            this.lbNomMarque.AutoSize = true;
            this.lbNomMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbNomMarque.Location = new System.Drawing.Point(218, 114);
            this.lbNomMarque.Name = "lbNomMarque";
            this.lbNomMarque.Size = new System.Drawing.Size(182, 24);
            this.lbNomMarque.TabIndex = 9;
            this.lbNomMarque.Text = "Nom de la marque : ";
            // 
            // btnCreateMarque
            // 
            this.btnCreateMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCreateMarque.Location = new System.Drawing.Point(313, 190);
            this.btnCreateMarque.Name = "btnCreateMarque";
            this.btnCreateMarque.Size = new System.Drawing.Size(96, 34);
            this.btnCreateMarque.TabIndex = 16;
            this.btnCreateMarque.Text = "Créé";
            this.btnCreateMarque.UseVisualStyleBackColor = true;
            this.btnCreateMarque.Click += new System.EventHandler(this.btnCreateMarque_Click);
            // 
            // lbMarqueAjoute
            // 
            this.lbMarqueAjoute.AutoSize = true;
            this.lbMarqueAjoute.Location = new System.Drawing.Point(310, 245);
            this.lbMarqueAjoute.Name = "lbMarqueAjoute";
            this.lbMarqueAjoute.Size = new System.Drawing.Size(0, 13);
            this.lbMarqueAjoute.TabIndex = 17;
            // 
            // FmCreateMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMarqueAjoute);
            this.Controls.Add(this.btnCreateMarque);
            this.Controls.Add(this.lbNomMarque);
            this.Controls.Add(this.tbNomMarque);
            this.Controls.Add(this.lbCreeMarque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmCreateMarque";
            this.Text = "FmCreateMarque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCreeMarque;
        private System.Windows.Forms.TextBox tbNomMarque;
        private System.Windows.Forms.Label lbNomMarque;
        private System.Windows.Forms.Button btnCreateMarque;
        private System.Windows.Forms.Label lbMarqueAjoute;
    }
}