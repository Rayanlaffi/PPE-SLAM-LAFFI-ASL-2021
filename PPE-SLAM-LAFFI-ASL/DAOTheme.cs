using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_SLAM_LAFFI_ASL
{
    class DAOTheme
    {

        // Retourne une collection de tous les Ateliers lus en BDD 
        public static List<Theme> getAllTheme()
        {
            List<Theme> lesThemes = new List<Theme>();
            string req = "Select * from theme";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Theme unTheme = new Theme(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()));
                lesThemes.Add(unTheme);
            }

            return lesThemes;

        }



        public static List<Theme> getAllThemeInAtelier(int idAtelier)
        {
            List<Theme> lesThemes = new List<Theme>();
            string req = "Select * from Theme where id_Atelier = " + idAtelier;
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Theme unTheme = new Theme(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()));
                lesThemes.Add(unTheme);
            }

            return lesThemes;

        }


    }
}
