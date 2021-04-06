namespace LAB7
{
    partial class FmCreateClient
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
            this.lbCreeClient = new System.Windows.Forms.Label();
            this.tbNomClient = new System.Windows.Forms.TextBox();
            this.tbPrenomClient = new System.Windows.Forms.TextBox();
            this.tbAdresseClient = new System.Windows.Forms.TextBox();
            this.tbCpClient = new System.Windows.Forms.TextBox();
            this.tbVilleClient = new System.Windows.Forms.TextBox();
            this.tbAdresseEmailClient = new System.Windows.Forms.TextBox();
            this.tbTelClient = new System.Windows.Forms.TextBox();
            this.lbNomClient = new System.Windows.Forms.Label();
            this.lbPrenomClient = new System.Windows.Forms.Label();
            this.lbAdresseClient = new System.Windows.Forms.Label();
            this.lbCpClient = new System.Windows.Forms.Label();
            this.lbVilleClient = new System.Windows.Forms.Label();
            this.lbEmailClient = new System.Windows.Forms.Label();
            this.lbTelClient = new System.Windows.Forms.Label();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.lbClientAjoute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCreeClient
            // 
            this.lbCreeClient.AutoSize = true;
            this.lbCreeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreeClient.Location = new System.Drawing.Point(271, 29);
            this.lbCreeClient.Name = "lbCreeClient";
            this.lbCreeClient.Size = new System.Drawing.Size(191, 24);
            this.lbCreeClient.TabIndex = 0;
            this.lbCreeClient.Text = "Création d\'un client";
            // 
            // tbNomClient
            // 
            this.tbNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbNomClient.Location = new System.Drawing.Point(192, 103);
            this.tbNomClient.Name = "tbNomClient";
            this.tbNomClient.Size = new System.Drawing.Size(100, 26);
            this.tbNomClient.TabIndex = 1;
            this.tbNomClient.Text = "Bob";
            // 
            // tbPrenomClient
            // 
            this.tbPrenomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPrenomClient.Location = new System.Drawing.Point(465, 103);
            this.tbPrenomClient.Name = "tbPrenomClient";
            this.tbPrenomClient.Size = new System.Drawing.Size(100, 26);
            this.tbPrenomClient.TabIndex = 2;
            this.tbPrenomClient.Text = "Bobby";
            // 
            // tbAdresseClient
            // 
            this.tbAdresseClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAdresseClient.Location = new System.Drawing.Point(192, 159);
            this.tbAdresseClient.Name = "tbAdresseClient";
            this.tbAdresseClient.Size = new System.Drawing.Size(100, 26);
            this.tbAdresseClient.TabIndex = 3;
            this.tbAdresseClient.Text = "16 rue du test";
            // 
            // tbCpClient
            // 
            this.tbCpClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCpClient.Location = new System.Drawing.Point(465, 157);
            this.tbCpClient.Name = "tbCpClient";
            this.tbCpClient.Size = new System.Drawing.Size(100, 26);
            this.tbCpClient.TabIndex = 4;
            this.tbCpClient.Text = "02420";
            // 
            // tbVilleClient
            // 
            this.tbVilleClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbVilleClient.Location = new System.Drawing.Point(192, 211);
            this.tbVilleClient.Name = "tbVilleClient";
            this.tbVilleClient.Size = new System.Drawing.Size(100, 26);
            this.tbVilleClient.TabIndex = 5;
            this.tbVilleClient.Text = "testland";
            // 
            // tbAdresseEmailClient
            // 
            this.tbAdresseEmailClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbAdresseEmailClient.Location = new System.Drawing.Point(465, 211);
            this.tbAdresseEmailClient.Name = "tbAdresseEmailClient";
            this.tbAdresseEmailClient.Size = new System.Drawing.Size(100, 26);
            this.tbAdresseEmailClient.TabIndex = 6;
            this.tbAdresseEmailClient.Text = "test@test.com";
            // 
            // tbTelClient
            // 
            this.tbTelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbTelClient.Location = new System.Drawing.Point(192, 268);
            this.tbTelClient.Name = "tbTelClient";
            this.tbTelClient.Size = new System.Drawing.Size(100, 26);
            this.tbTelClient.TabIndex = 7;
            this.tbTelClient.Text = "0123456789";
            // 
            // lbNomClient
            // 
            this.lbNomClient.AutoSize = true;
            this.lbNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbNomClient.Location = new System.Drawing.Point(120, 103);
            this.lbNomClient.Name = "lbNomClient";
            this.lbNomClient.Size = new System.Drawing.Size(66, 24);
            this.lbNomClient.TabIndex = 8;
            this.lbNomClient.Text = "Nom : ";
            // 
            // lbPrenomClient
            // 
            this.lbPrenomClient.AutoSize = true;
            this.lbPrenomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbPrenomClient.Location = new System.Drawing.Point(367, 103);
            this.lbPrenomClient.Name = "lbPrenomClient";
            this.lbPrenomClient.Size = new System.Drawing.Size(92, 24);
            this.lbPrenomClient.TabIndex = 9;
            this.lbPrenomClient.Text = "Prénom : ";
            // 
            // lbAdresseClient
            // 
            this.lbAdresseClient.AutoSize = true;
            this.lbAdresseClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbAdresseClient.Location = new System.Drawing.Point(96, 161);
            this.lbAdresseClient.Name = "lbAdresseClient";
            this.lbAdresseClient.Size = new System.Drawing.Size(90, 24);
            this.lbAdresseClient.TabIndex = 10;
            this.lbAdresseClient.Text = "Adresse :";
            // 
            // lbCpClient
            // 
            this.lbCpClient.AutoSize = true;
            this.lbCpClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbCpClient.Location = new System.Drawing.Point(334, 161);
            this.lbCpClient.Name = "lbCpClient";
            this.lbCpClient.Size = new System.Drawing.Size(125, 24);
            this.lbCpClient.TabIndex = 11;
            this.lbCpClient.Text = "Code postal : ";
            // 
            // lbVilleClient
            // 
            this.lbVilleClient.AutoSize = true;
            this.lbVilleClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbVilleClient.Location = new System.Drawing.Point(125, 211);
            this.lbVilleClient.Name = "lbVilleClient";
            this.lbVilleClient.Size = new System.Drawing.Size(61, 24);
            this.lbVilleClient.TabIndex = 12;
            this.lbVilleClient.Text = "Ville : ";
            // 
            // lbEmailClient
            // 
            this.lbEmailClient.AutoSize = true;
            this.lbEmailClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbEmailClient.Location = new System.Drawing.Point(387, 213);
            this.lbEmailClient.Name = "lbEmailClient";
            this.lbEmailClient.Size = new System.Drawing.Size(72, 24);
            this.lbEmailClient.TabIndex = 13;
            this.lbEmailClient.Text = "Email : ";
            // 
            // lbTelClient
            // 
            this.lbTelClient.AutoSize = true;
            this.lbTelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbTelClient.Location = new System.Drawing.Point(68, 268);
            this.lbTelClient.Name = "lbTelClient";
            this.lbTelClient.Size = new System.Drawing.Size(118, 24);
            this.lbTelClient.TabIndex = 14;
            this.lbTelClient.Text = "Téléphone : ";
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCreateClient.Location = new System.Drawing.Point(310, 328);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(96, 34);
            this.btnCreateClient.TabIndex = 15;
            this.btnCreateClient.Text = "Créé";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // lbClientAjoute
            // 
            this.lbClientAjoute.AutoSize = true;
            this.lbClientAjoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbClientAjoute.Location = new System.Drawing.Point(413, 280);
            this.lbClientAjoute.Name = "lbClientAjoute";
            this.lbClientAjoute.Size = new System.Drawing.Size(0, 20);
            this.lbClientAjoute.TabIndex = 16;
            // 
            // FmCreateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(720, 413);
            this.Controls.Add(this.lbClientAjoute);
            this.Controls.Add(this.btnCreateClient);
            this.Controls.Add(this.lbTelClient);
            this.Controls.Add(this.lbEmailClient);
            this.Controls.Add(this.lbVilleClient);
            this.Controls.Add(this.lbCpClient);
            this.Controls.Add(this.lbAdresseClient);
            this.Controls.Add(this.lbPrenomClient);
            this.Controls.Add(this.lbNomClient);
            this.Controls.Add(this.tbTelClient);
            this.Controls.Add(this.tbAdresseEmailClient);
            this.Controls.Add(this.tbVilleClient);
            this.Controls.Add(this.tbCpClient);
            this.Controls.Add(this.tbAdresseClient);
            this.Controls.Add(this.tbPrenomClient);
            this.Controls.Add(this.tbNomClient);
            this.Controls.Add(this.lbCreeClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmCreateClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création d\'un client - LAB7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCreeClient;
        private System.Windows.Forms.TextBox tbNomClient;
        private System.Windows.Forms.TextBox tbPrenomClient;
        private System.Windows.Forms.TextBox tbAdresseClient;
        private System.Windows.Forms.TextBox tbCpClient;
        private System.Windows.Forms.TextBox tbVilleClient;
        private System.Windows.Forms.TextBox tbAdresseEmailClient;
        private System.Windows.Forms.TextBox tbTelClient;
        private System.Windows.Forms.Label lbNomClient;
        private System.Windows.Forms.Label lbPrenomClient;
        private System.Windows.Forms.Label lbAdresseClient;
        private System.Windows.Forms.Label lbCpClient;
        private System.Windows.Forms.Label lbVilleClient;
        private System.Windows.Forms.Label lbEmailClient;
        private System.Windows.Forms.Label lbTelClient;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Label lbClientAjoute;
    }
}