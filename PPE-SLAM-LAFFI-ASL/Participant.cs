using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_SLAM_LAFFI_ASL
{
    class Participant
    {
        #region Propriétés privées
        private int id;
        private string nom;
        private string prenom;
        private string adresse;
        private string mail;
        private string numero;
        private string club;
        #endregion

        #region Constructeurs nom, prenom, adresse, mail, numero, club
        public Participant(int unId, string unNom, string unPrenom, string uneAdresse, string unMail, string unNumero, string unClub)
        {
            id = unId;
            nom = unNom;
            prenom = unPrenom;
            adresse = uneAdresse;
            mail = unMail;
            numero = unNumero;
            club = unClub;
        }
        #endregion

        #region Accesseurs
        public int Id { get { return id; } set { id = value; } }
        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public string Adresse { get { return adresse; } set { adresse = value; } }
        public string Mail { get { return mail; } set { mail = value; } }
        public string Numero { get { return numero; } set { numero = value; } }
        public string Club { get { return club; } set { club = value; } }

        #endregion

        #region Méthodes publiques

        #endregion

        #region Méthodes d'appel au DAO métier

        // Méthode statique qui retourne l'ensemble des comptes sous forme de List
        public static List<Participant> listeParticipant()
        {
            return DAOParticipant.getAllParticipant();
        }
        public static Dictionary<int, String> getDicoIntervenantDansAtelier(int idAtelier)
        {
            return DAOParticipant.getDicoIntervenantDansAtelier(idAtelier);
        }
        public static Dictionary<int, String> getDicoIntervenants(int idAtelier)
        {
            return DAOParticipant.getDicoIntervenants(idAtelier);
        }
        public static Dictionary<int, String> getDicoIntervenantsNonAffecter(int idAtelier)
        {
            return DAOParticipant.getDicoIntervenantsNonAffecter(idAtelier);
        }
        public static int getNombreParticipantNonAffecter(int idAtelier)
        {
            return DAOParticipant.getNombreParticipantNonAffecter(idAtelier);
        }
        public static int getNombreParticipantDansAtelier(int idAtelier)
        {
            return DAOParticipant.getNombreParticipantDansAtelier(idAtelier);
        }

        public static Participant getParticipant(int id)
        {
            return DAOParticipant.getUnParticipant(id);
        }

        public static List<Participant> getAllIntervenantParAtelier(int idAtelier)
        {
            return DAOParticipant.getAllIntervenantParAtelier(idAtelier);
        }
        public static List<Participant> getIntervenantsNonAffecter(int idAtelier)
        {
            return DAOParticipant.getIntervenantsNonAffecter(idAtelier);
        }

        public static void supprimerIntervenant(int idParticipant)
        {
            DAOParticipant.supprimerIntervenant(idParticipant);
        }
        public static void insertIntervenant(int idIntervenant, int idAtelier)
        {
            DAOParticipant.insertIntervenant(idIntervenant, idAtelier);
        }
        

        #endregion
    }
}
