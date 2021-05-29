using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_SLAM_LAFFI_ASL
{
    class Utilisateur
    {
        #region Propriétés privées
        private int id;
        private string nom;
        private string prenom;
        private string mdp;
        private string email;
        #endregion

        #region Constructeurs
        public Utilisateur(int unId, string unNom, string unPrenom, string unMdp, string unEmail)
        {
            id = unId;
            nom = unNom;
            prenom = unPrenom;
            mdp = unMdp;
            email = unEmail;
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

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Mdp
        {
            get
            {
                return mdp;
            }

            set
            {
                mdp = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        #endregion

        #region Méthodes publiques

        #endregion

        #region Méthodes d'appel au DAO métier

        // Méthode statique qui retourne l'ensemble des comptes sous forme de List


        public static Utilisateur getUtilisateur(String unEmail)
        {
            return DAOUtilisateur.getUtilisateur(unEmail);
        }


        #endregion
    }
}
