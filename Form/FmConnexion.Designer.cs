namespace LAB7
{
    partial class FmConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmConnexion));
            this.labelUtilisateur = new System.Windows.Forms.Label();
            this.labelMotDePasse = new System.Windows.Forms.Label();
            this.tbUtilisateur = new System.Windows.Forms.TextBox();
            this.tbMotDePasse = new System.Windows.Forms.TextBox();
            this.btnSubmitConnexion = new System.Windows.Forms.Button();
            this.lbTextConnexion = new System.Windows.Forms.Label();
            this.lbErreurConnexion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUtilisateur
            // 
            this.labelUtilisateur.AutoSize = true;
            this.labelUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtilisateur.Location = new System.Drawing.Point(231, 163);
            this.labelUtilisateur.Name = "labelUtilisateur";
            this.labelUtilisateur.Size = new System.Drawing.Size(127, 26);
            this.labelUtilisateur.TabIndex = 1;
            this.labelUtilisateur.Text = "Utilisateur : ";
            // 
            // labelMotDePasse
            // 
            this.labelMotDePasse.AutoSize = true;
            this.labelMotDePasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.labelMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotDePasse.Location = new System.Drawing.Point(198, 204);
            this.labelMotDePasse.Name = "labelMotDePasse";
            this.labelMotDePasse.Size = new System.Drawing.Size(160, 26);
            this.labelMotDePasse.TabIndex = 2;
            this.labelMotDePasse.Text = "Mot de passe : ";
            // 
            // tbUtilisateur
            // 
            this.tbUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.tbUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUtilisateur.ForeColor = System.Drawing.Color.White;
            this.tbUtilisateur.Location = new System.Drawing.Point(364, 163);
            this.tbUtilisateur.Name = "tbUtilisateur";
            this.tbUtilisateur.Size = new System.Drawing.Size(167, 29);
            this.tbUtilisateur.TabIndex = 3;
            this.tbUtilisateur.Text = "francis";
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.tbMotDePasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMotDePasse.ForeColor = System.Drawing.Color.White;
            this.tbMotDePasse.Location = new System.Drawing.Point(364, 204);
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.PasswordChar = '¤';
            this.tbMotDePasse.Size = new System.Drawing.Size(167, 29);
            this.tbMotDePasse.TabIndex = 4;
            this.tbMotDePasse.Text = "test";
            // 
            // btnSubmitConnexion
            // 
            this.btnSubmitConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.btnSubmitConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitConnexion.Location = new System.Drawing.Point(288, 253);
            this.btnSubmitConnexion.Name = "btnSubmitConnexion";
            this.btnSubmitConnexion.Size = new System.Drawing.Size(148, 43);
            this.btnSubmitConnexion.TabIndex = 5;
            this.btnSubmitConnexion.Text = "Connexion";
            this.btnSubmitConnexion.UseVisualStyleBackColor = false;
            this.btnSubmitConnexion.Click += new System.EventHandler(this.btnSubmitConnexion_Click);
            // 
            // lbTextConnexion
            // 
            this.lbTextConnexion.AutoSize = true;
            this.lbTextConnexion.BackColor = System.Drawing.Color.Transparent;
            this.lbTextConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextConnexion.Location = new System.Drawing.Point(182, 69);
            this.lbTextConnexion.Name = "lbTextConnexion";
            this.lbTextConnexion.Size = new System.Drawing.Size(385, 31);
            this.lbTextConnexion.TabIndex = 9;
            this.lbTextConnexion.Text = "Connexion au panel de gestion";
            // 
            // lbErreurConnexion
            // 
            this.lbErreurConnexion.AutoSize = true;
            this.lbErreurConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErreurConnexion.ForeColor = System.Drawing.Color.Red;
            this.lbErreurConnexion.Location = new System.Drawing.Point(188, 315);
            this.lbErreurConnexion.Name = "lbErreurConnexion";
            this.lbErreurConnexion.Size = new System.Drawing.Size(0, 20);
            this.lbErreurConnexion.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 88);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(753, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbErreurConnexion);
            this.Controls.Add(this.lbTextConnexion);
            this.Controls.Add(this.btnSubmitConnexion);
            this.Controls.Add(this.tbMotDePasse);
            this.Controls.Add(this.tbUtilisateur);
            this.Controls.Add(this.labelMotDePasse);
            this.Controls.Add(this.labelUtilisateur);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmConnexion";
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUtilisateur;
        private System.Windows.Forms.Label labelMotDePasse;
        private System.Windows.Forms.TextBox tbUtilisateur;
        private System.Windows.Forms.TextBox tbMotDePasse;
        private System.Windows.Forms.Button btnSubmitConnexion;
        private System.Windows.Forms.Label lbTextConnexion;
        private System.Windows.Forms.Label lbErreurConnexion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}