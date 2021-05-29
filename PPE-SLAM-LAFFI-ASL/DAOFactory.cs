using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_SLAM_LAFFI_ASL
{
    class DAOFactory
    {
        SqlConnection connexion;

        public DAOFactory()
        {
            //connexion = new SqlConnection("Data Source='172.17.254.10';Initial Catalog=SIO2_LAFFI;User ID='sio2-laffi';Password='Rayan-2021'");
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            // String host = "172.17.254.10";
            //String bdd = "SIO2_LAFFI";
            // String password = "Rayan-2021";
            // String user = "sio2-laffi";
            String host = "localhost";
            String bdd = "laffi_Cdc";
            builder.DataSource = host;
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = bdd;
            //builder.UserID = user;
            // builder.Password = password;
            Console.WriteLine("Connexion info created : " + builder.ConnectionString);
            connexion = new SqlConnection(builder.ConnectionString);

        }

        public void connecter()
        {
            connexion.Open();
        }

        public void deconnecter()
        {
            connexion.Close();
        }

        // Exécution d'une requête de lecture ; retourne un Datareader
        public SqlDataReader excecSQLRead(string requete)
        {
            SqlCommand maCommand;
            SqlDataAdapter monDataAdapter;
            maCommand = new SqlCommand();
            maCommand.CommandText = requete;
            maCommand.Connection = connexion;

            monDataAdapter = new SqlDataAdapter();
            monDataAdapter.SelectCommand = maCommand;

            SqlDataReader monDR;
            monDR = maCommand.ExecuteReader();

            return monDR;
        }

        // Exécution d'une requete d'écriture (Insert ou Update) ; ne retourne rien
        public void execSQLWrite(string requete)
        {

            SqlCommand maCommand;
            maCommand = new SqlCommand();
            maCommand.CommandText = requete;
            maCommand.Connection = connexion;

            maCommand.ExecuteNonQuery();

        }
    }
}
