using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_SLAM_LAFFI_ASL
{
    class DAOUtilisateur
    {

        public static Utilisateur getUtilisateur(String unEmail)
        {
            string req = "Select * from utilisateur where email = '" + unEmail + "'";
            DAOFactory db = new DAOFactory();
            db.connecter();
            Utilisateur unUtilisateur;
            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                unUtilisateur = new Utilisateur(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                return unUtilisateur;
            }

            return null;
        }




    }
}
