using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using LAB7.Component;

namespace LAB7
{
    public partial class FmConnexion : Form
    {
        public FmConnexion()
        {
            InitializeComponent();

        }

        //Fonction qui créé le hashage du mot de passe
        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            //Convertis le string en tableau de byte
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            //Création d'un nouveau Stringbuilder
            var sBuilder = new StringBuilder();

            //Boucle qui parcours le tableau de byte et le formate en hexa 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            //Retourne le string hexadecimal
            return sBuilder.ToString();
        }


        private void btnSubmitConnexion_Click(object sender, EventArgs e)
        {
            //Récupération du nom d'utilisateur et du mot de passe saisi

            string utilisateur = tbUtilisateur.Text;
            string motDePasse = tbMotDePasse.Text;

            //Si les champs mot de passe et utilisateur est vide
            if (utilisateur.Length == 0 || motDePasse.Length == 0)
            {
                lbErreurConnexion.Text = "Veuillez remplir tout les champs !";
            }
            //Sinon si les champs utilisateur et mot de passe ne sont pas vide
            else
            {

                //String contenant les infos pour la connexion à la BDD
                string bdd = "server=localhost;port=3306;database=testlab7;uid=root";

                //Nouvelle connexion à la bdd
                MySqlConnection mysql;
                mysql = new MySqlConnection(bdd);


                //Nouvelle requête SQL
                string requete = "SELECT * FROM employe WHERE nomUtilisateur = @utilisateur";
                MySqlCommand command = mysql.CreateCommand();
                command.CommandText = requete;
                command.Parameters.AddWithValue("@utilisateur", utilisateur);

                //Ouverture de la requete SQL

                    mysql.Open();


                //Exécution de la requête
                MySqlDataReader lecteur = command.ExecuteReader();
                //Lecture des résultats de la requête
                int count = 0;
                while (lecteur.Read())
                {
                    count = count + 1;
                }

                //Si il y a strictement un résultat
                if (count == 1)
                {

                    //Hashage du mot de passe
                    using (SHA256 sha256Hash = SHA256.Create())
                    {

                        //Mot de passe de francis : test
                        //Mot de passe de jose : truc
                        string hashMdp = GetHash(sha256Hash, motDePasse);

                        if (lecteur[4].ToString() == "oui")
                        {

                            //Vérification si le mot de passe saisie correspond à celui de l'utilisateur en BDD
                            if (lecteur[1].ToString() == utilisateur && lecteur[2].ToString() == hashMdp)
                            {
                                //Vérification si l'user est l'admin
                                if (lecteur[3].ToString() == "Administrateur")
                                {
                                    FmAdmin fmAdm = new FmAdmin();
                                    this.Hide();
                                    fmAdm.ShowDialog();

                                }
                                //Sinon il est techos
                                else if (lecteur[3].ToString() == "Technicien")
                                {
                                    FmTechos fmTech = new FmTechos();
                                    this.Hide();
                                    fmTech.ShowDialog();
                                }
                            }
                            //Si le mot de passe sasie ne correspond pas à celui de l'utilisateur en BDD
                            else
                            {
                                //Afficher erreur de mot de passe
                                lbErreurConnexion.Text = "Connexion échoué, le mot de passe ne correspond pas !";
                            }
                        }
                        else
                        {
                            lbErreurConnexion.Text = "Connexion échoué, l'accés à été désactiver !";

                        }
                    }

                }
                //Si 0 résultat ou plus
                else
                {
                    //Affichage erreur
                    lbErreurConnexion.Text = "Connexion échoué, l'utilisateur \"" + utilisateur + "\" n'existe pas !";
                }
                mysql.Close();
               
            }



        }
    }
}
