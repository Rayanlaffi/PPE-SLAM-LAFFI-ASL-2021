using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PPE_SLAM_LAFFI_ASL
{
    class DAOParticipant
    {
        // Retourne une collection de tous les Ateliers lus en BDD 
        public static List<Participant> getAllParticipant()
        {
            List<Participant> lesParticipants = new List<Participant>();
            string req = "Select * from Participant";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                //Decimal.Parse(reader[2].ToString())
                //DateTime date = new DateTime(0, 0, 0, reader[2].ToString());
                // string heureDebut = reader[3].ToString();
                //string heureFin = reader[2].ToString();
                Participant unParticipant = new Participant(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
                lesParticipants.Add(unParticipant);
            }
            db.deconnecter();
            return lesParticipants;

        }

        public static Participant getUnParticipant(int id)
        {
            string req = "Select * from Participant where id = " + id;
            DAOFactory db = new DAOFactory();
            db.connecter();
            Participant unParticipant;
            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                unParticipant = new Participant(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
                db.deconnecter();
                return unParticipant;
            }

            return null;
        }

        public static List<Participant> getAllIntervenantParAtelier(int idAtelier)
        {
            List<Participant> lesParticipants = new List<Participant>();
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "Select * from intervient where id_Atelier = " + idAtelier;
            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Participant unParticipant = Participant.getParticipant(int.Parse(reader[0].ToString()));
                lesParticipants.Add(unParticipant);
            }
            db.deconnecter();
            return lesParticipants;

        }

        public static void supprimerIntervenant(int id)
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "DELETE FROM intervient WHERE id = " + id;
            SqlDataReader reader = db.excecSQLRead(req);
            db.deconnecter();
        }

        public static void insertIntervenant(int idIntervenant, int idAtelier)
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "INSERT INTO intervient (id, id_Atelier) VALUES(" + idIntervenant + "," + idAtelier + ");";
            SqlDataReader reader = db.excecSQLRead(req);
            db.deconnecter();
        }

        public static List<Participant> getIntervenantsNonAffecter(int idAtelier)
        {
            List<Participant> lesParticipantsNonAffecter = new List<Participant>();
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "Select * from Participant where id NOT IN(Select id from intervient where id_Atelier = " + idAtelier + ")";
            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Participant unParticipant = Participant.getParticipant(int.Parse(reader[0].ToString()));
                lesParticipantsNonAffecter.Add(unParticipant);
            }


            return lesParticipantsNonAffecter;
            
            
        }

        public static int getNombreParticipantNonAffecter(int idAtelier)
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "Select count(*) from Participant where id NOT IN(Select id from intervient where id_Atelier = " + idAtelier + ")";
            SqlDataReader reader = db.excecSQLRead(req);
            int resultat = 0;
            while (reader.Read())
            {
                resultat = int.Parse(reader[0].ToString());
                if (resultat == 1) // si il n'y a que l'animateur je retourne 0 pour le traitement
                {
                    resultat = 0;
                }
                
                

            }


            return resultat;


        }
        public static int getNombreParticipantDansAtelier(int idAtelier)
        {
            DAOFactory db = new DAOFactory();
            db.connecter();
            string req = "Select count(*) from intervient where id_Atelier = " + idAtelier;
            SqlDataReader reader = db.excecSQLRead(req);
            int resultat = 0;
            while (reader.Read())
            {
                resultat = int.Parse(reader[0].ToString());
                resultat += 1;
            }
            db.deconnecter();
            return resultat;

        }

        public static Dictionary<int, String> getDicoIntervenantDansAtelier(int idAtelier)
        {
            Dictionary<int, String> lesParticipantsSaufAnimateur = new Dictionary<int, String>();
            Atelier unAtelier = Atelier.getAtelier(idAtelier);
            Participant unAnimateur = getUnParticipant(unAtelier.Id_Participant);
            List<Participant> tousLesParticipants = Participant.getAllIntervenantParAtelier(idAtelier);
            //lesParticipantsSaufAnimateur.Add(unAnimateur.Id, unAnimateur.Nom + " " + unAnimateur.Prenom);
            foreach (Participant unParticipant in tousLesParticipants)
            {
                if (unAnimateur.Id != unParticipant.Id)
                {
                    lesParticipantsSaufAnimateur.Add(unParticipant.Id, unParticipant.Nom + " " + unParticipant.Prenom);
                }

            }

            return lesParticipantsSaufAnimateur;

        }

        public static Dictionary<int, String> getDicoIntervenants(int idAtelier)
        {
            Dictionary<int, String> lesIntervenants = new Dictionary<int, String>();
            List<Participant> tousLesIntervenants = getAllParticipant();
            Atelier unAtelier = Atelier.getAtelier(idAtelier);
            Participant unAnimateur = getUnParticipant(unAtelier.Id_Participant);
            lesIntervenants.Add(unAnimateur.Id, unAnimateur.Nom + " " + unAnimateur.Prenom);
            foreach (Participant unIntervenant in tousLesIntervenants)
            {
                if (unAnimateur.Id != unIntervenant.Id)
                {
                    lesIntervenants.Add(unIntervenant.Id, unIntervenant.Nom + " " + unIntervenant.Prenom);
                }
            }

            return lesIntervenants;

        }

        public static Dictionary<int, String> getDicoIntervenantsNonAffecter(int idAtelier)
        {
            Dictionary<int, String> lesIntervenantsNonAffecter = new Dictionary<int, String>();
            List<Participant> tousLesIntervenantsNonAffecter = Participant.getIntervenantsNonAffecter(idAtelier);
            Atelier unAtelier = Atelier.getAtelier(idAtelier);
            Participant unAnimateur = getUnParticipant(unAtelier.Id_Participant);
            foreach (Participant unIntervenant in tousLesIntervenantsNonAffecter)
            {
                if (unAnimateur.Id != unIntervenant.Id)
                {
                    lesIntervenantsNonAffecter.Add(unIntervenant.Id, unIntervenant.Nom + " " + unIntervenant.Prenom);
                }
            }

            return lesIntervenantsNonAffecter;

        }

    }
}
