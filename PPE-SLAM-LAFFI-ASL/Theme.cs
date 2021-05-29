using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_SLAM_LAFFI_ASL
{
    class Theme
    {
        #region Propriétés privées
        private int id;
        private String nom;
        private int id_Atelier;
        #endregion

        #region Constructeurs
        public Theme(int unId, string unNom, int unId_Atelier)
        {
            id = unId;
            nom = unNom;
            id_Atelier = unId_Atelier;
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

        public int Id_Atelier
        {
            get
            {
                return id_Atelier;
            }

            set
            {
                id_Atelier = value;
            }
        }
        #endregion

        #region Méthodes publiques

        #endregion

        #region Méthodes d'appel au DAO métier

        // Méthode statique qui retourne l'ensemble des comptes sous forme de List
        public static List<Theme> listeTheme()
        {
            return DAOTheme.getAllTheme();
        }
        public static List<Theme> listeThemeByAtelier(int idAtelier)
        {
            return DAOTheme.getAllThemeInAtelier(idAtelier);
        }

        #endregion
    }
}
