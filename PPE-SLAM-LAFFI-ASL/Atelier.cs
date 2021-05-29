using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_SLAM_LAFFI_ASL
{
    class Atelier
    {
        #region Propriétés privées
        private int id;
        private int capaciteMax;
        private string nom;
        private string heureFin;
        private string heureDebut;
        private int id_Participant;
        #endregion

        #region Constructeurs
        public Atelier(int unId, int unCapaciteMax, string unNom, string uneHeureFin, string uneHeureDebut, int unId_Participant)
        {
            id = unId;
            capaciteMax = unCapaciteMax;
            nom = unNom;
            heureFin = uneHeureFin;
            heureDebut = uneHeureDebut;
            id_Participant = unId_Participant;
        }
        #endregion

        #region Accesseurs
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int CapaciteMax
        {
            get
            {
                return capaciteMax;
            }

            set
            {
                capaciteMax = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string HeureFin
        {
            get
            {
                return heureFin;
            }

            set
            {
                heureFin = value;
            }
        }

        public string HeureDebut
        {
            get
            {
                return heureDebut;
            }

            set
            {
                heureDebut = value;
            }
        }

        public int Id_Participant
        {
            get
            {
                return id_Participant;
            }

            set
            {
                id_Participant = value;
            }
        }
        #endregion

        #region Méthodes publiques

        #endregion

        #region Méthodes d'appel au DAO métier

        // Méthode statique qui retourne l'ensemble des comptes sous forme de List
        public static List<Atelier> listeAtelier()
        {
            return DAOAtelier.getAllAtelier();
        }

        
        public static Dictionary<int, String> getDicoAteliers()
        {
            return DAOAtelier.getDicoAteliers();
        }

        public static Atelier getAtelier(int id)
        {
            return DAOAtelier.getUnAtelier(id);
        }

        public static void updateAnimateur(int ancienAnimateur, int nouveauAnimateur)
        {
            DAOAtelier.updateAnimateur(ancienAnimateur, nouveauAnimateur);
        }
        public static void updateHeure(int idAtelier, String heureDebut, String heureFin)
        {
            DAOAtelier.updateHeure(idAtelier, heureDebut, heureFin);
        }
        public static void updateCapacite(int capacite, int idAtelier)
        {
            DAOAtelier.updateCapacite(capacite, idAtelier);
        }
        

        #endregion
    }
}
