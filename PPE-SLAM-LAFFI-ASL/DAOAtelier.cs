using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_SLAM_LAFFI_ASL
{
    class DAOAtelier
    {

        public static Dictionary<int, String> getDicoAteliers()
        {
            List<Atelier> lesAteliers = Atelier.listeAtelier();
            Dictionary<int, String> tousLesAteliers = new Dictionary<int, String>();
            foreach (Atelier atelier in lesAteliers)
            {
                tousLesAteliers.Add(atelier.Id, atelier.Nom);
            }
            return tousLesAteliers;

        }

        // Retourne une collection de tous les Ateliers lus en BDD 
        public static List<Atelier> getAllAtelier()
        {
            List<Atelier> lesAtelier = new List<Atelier>();
            string req = "Select * from Atelier";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                //Decimal.Parse(reader[2].ToString())
                //DateTime date = new DateTime(0, 0, 0, reader[2].ToString());
                // string heureDebut = reader[3].ToString();
                //string heureFin = reader[2].ToString();
                Atelier unAtelier = new Atelier(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), int.Parse(reader[5].ToString()));
                lesAtelier.Add(unAtelier);
            }
            db.deconnecter();
            return lesAtelier;

        }

        public static Atelier getUnAtelier(int id)
        {
            string req = "Select * from Atelier where id = " + id;
            DAOFactory db = new DAOFactory();
            db.connecter();
            Atelier unAtelier;
            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                unAtelier = new Atelier(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), int.Parse(reader[5].ToString()));
                db.deconnecter();
                return unAtelier;
            }

            return null;
        }

        public static void updateAnimateur(int ancienAnimateur, int nouveauAnimateur)
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "UPDATE Atelier SET id_Participant = " + nouveauAnimateur + " WHERE id_Participant = " + ancienAnimateur + ";";
            SqlDataReader reader = db.excecSQLRead(req);
            db.deconnecter();
        }
        public static void updateCapacite(int capacite, int idAtelier)
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "UPDATE Atelier SET capaciteMax = " + capacite + " WHERE id = " + idAtelier + ";";
            SqlDataReader reader = db.excecSQLRead(req);
            db.deconnecter();
        }

        public static void updateHeure(int idAtelier, String heureDebut, String heureFin)
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "UPDATE Atelier SET heureDebut = '" + heureDebut + "' WHERE id = " + idAtelier + ";";
            SqlDataReader reader = db.excecSQLRead(req);
            db.deconnecter();

            DAOFactory db2 = new DAOFactory();
            db2.connecter();
            string req2 = "UPDATE Atelier SET heureFin = '" + heureFin + "' WHERE id = " + idAtelier + ";";
            SqlDataReader reader2 = db2.excecSQLRead(req2);
            db2.deconnecter();

        }

    }
}
