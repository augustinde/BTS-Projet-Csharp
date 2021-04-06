using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB7.Component;

namespace LAB7.Manager
{
    public class InfoManager
    {
        //Méthode qui créé la commande pour lire les infos de la société
        public InfoLabSept readInfo()
        {

            InfoLabSept infoLabSept = new InfoLabSept();

            string bdd = "server=localhost;port=3306;database=testlab7;uid=root";

            MySqlConnection connection = new MySqlConnection(bdd);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM infolab7 LIMIT 1";

            try
            {
                MySqlDataReader lecteur = command.ExecuteReader();

                if(lecteur != null)
                {
                    while (lecteur.Read())
                    {
                        infoLabSept.NomLab = lecteur[1].ToString();
                        infoLabSept.AdresseLab = lecteur[2].ToString();
                        infoLabSept.CpLab = lecteur[3].ToString();
                        infoLabSept.VilleLab = lecteur[4].ToString();
                        infoLabSept.TelLab = lecteur[5].ToString();
                        infoLabSept.FaxLab = lecteur[6].ToString();
                        infoLabSept.TypeSocieteLab = lecteur[7].ToString();
                        infoLabSept.RCSLab1 = lecteur[8].ToString();
                        infoLabSept.SiretLab1 = lecteur[9].ToString();
                        infoLabSept.APELab1 = lecteur[10].ToString();
                    }
                    return infoLabSept;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }


        }

        //Méthode qui créé la commande pour modifier les infos de la société
        public int updateInfo(string nomLab, string adresseLab, string cpLab, string villeLab, string telLab, string faxLab, string typeLab, string rcsLab, string siretLab, string apeLab)
        {
            BaseDonnee bd = new BaseDonnee();

            MySqlCommand command = new MySqlCommand("UPDATE infolab7 SET nomLab = @nomLab, adresseLab = @adresseLab, cpLab = @cpLab, villeLab = @villeLab, telLab = @telLab, faxLab = @faxLab, typeSocieteLab = @typeLab, RCSLab = @rcsLab, SiretLab = @siretLab, APELab = @apeLab WHERE idInfoLab = 1");
            command.Parameters.AddWithValue("@nomLab", nomLab);
            command.Parameters.AddWithValue("@adresseLab", adresseLab);
            command.Parameters.AddWithValue("@cpLab", cpLab);
            command.Parameters.AddWithValue("@villeLab", villeLab);
            command.Parameters.AddWithValue("@telLab", telLab);
            command.Parameters.AddWithValue("@faxLab", faxLab);
            command.Parameters.AddWithValue("@typeLab", typeLab);
            command.Parameters.AddWithValue("@rcsLab", rcsLab);
            command.Parameters.AddWithValue("@siretLab", siretLab);
            command.Parameters.AddWithValue("@apeLab", apeLab);
            
            bool rqTest = bd.Update(command);

            if (rqTest)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


    }
}
