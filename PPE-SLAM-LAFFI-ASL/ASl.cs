using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_SLAM_LAFFI_ASL
{
    public partial class ASL : Form
    {
        Dictionary<int, String> lesAteliers = Atelier.getDicoAteliers();
        String nom = "";
        String prenom = "";
        String email = "";
        public ASL()
        {
            InitializeComponent();
        }

        private void cbxAtelier_SelectedIndexChanged(object sender, EventArgs e) // quand je choisi
        {
            dgvAtelier.Rows.Clear();
            KeyValuePair<int, String> laSelection = (KeyValuePair<int, String>)cbxAtelier.SelectedItem;
            int idAtelier = laSelection.Key;
            Atelier unAtelier = DAOAtelier.getUnAtelier(idAtelier);
            int capaciteAtelier = unAtelier.CapaciteMax;
            int nbrIntervenant = DAOParticipant.getNombreParticipantDansAtelier(idAtelier);

            Participant unAnimateur = Participant.getParticipant(unAtelier.Id_Participant);
            dgvAtelier.Rows.Add(unAtelier.Nom, unAnimateur.Nom + " " + unAnimateur.Prenom, unAtelier.HeureDebut, unAtelier.HeureFin, capaciteAtelier - nbrIntervenant + " / " + capaciteAtelier);

            List<Theme> listeTheme = Theme.listeThemeByAtelier(unAtelier.Id);
            dgvTheme.Rows.Clear();
            foreach (Theme theme in listeTheme)
            {
                dgvTheme.Rows.Add(theme.Nom);
            }
            List<Participant> listeParticipants = Participant.getAllIntervenantParAtelier(unAtelier.Id);
            dgvIntervenant.Rows.Clear();
            foreach (Participant intervenant in listeParticipants)
            {
                if (unAnimateur.Id != intervenant.Id)
                {
                    dgvIntervenant.Rows.Add(intervenant.Nom + " " + intervenant.Prenom);
                }

            }

        }

        private void cbxAtelier_Enter(object sender, EventArgs e) // Quand je rentre dans le combobox
        {
            cbxAtelier.ResetText();
            cbxAtelier.DataSource = new BindingSource(lesAteliers, null);
            cbxAtelier.DisplayMember = "Value";
            cbxAtelier.ValueMember = "Key";

        }
        private void deconnexion() 
        {
            
            lblConnexion.Text = "";
            lblConnexion2.Text = "";
            tabControl.TabPages.Remove(tabAteliers);
            tabControl.TabPages.Remove(tabGestion);
            tabControl.TabPages.Add(tabConnexion);
            textBoxLogin.Text = "";
            textBoxMdp.Text = "";

            
        }
            

    private void btnValider_Click(object sender, EventArgs e)
        {
            String leLogin = textBoxLogin.Text;
            String leMotDePasse = CreateMD5(textBoxMdp.Text);

            Utilisateur unUtilisateur = Utilisateur.getUtilisateur(leLogin);

            if (unUtilisateur != null && unUtilisateur.Mdp == leMotDePasse)
            {
                String leMotDePasseBdd = unUtilisateur.Mdp;
                String unEmail = unUtilisateur.Email;

                if (leMotDePasse == leMotDePasseBdd && leLogin == unEmail)
                {
                    tabControl.TabPages.Add(tabAteliers);
                    tabControl.TabPages.Add(tabGestion);
                    tabControl.TabPages.Remove(tabConnexion);
                    nom = unUtilisateur.Nom;
                    prenom = unUtilisateur.Prenom;
                    email = unUtilisateur.Email;

                    lblConnexion.Text = "Bonjour " + nom + " " + prenom;
                    lblConnexion2.Text = "Bonjour " + nom + " " + prenom;
                }
            }
            else
            {
                lblErreur.Text = "Erreur, identifiant ou mot de passe incorrect.";
                lblErreur.ForeColor = Color.Red;
            }
        }

        public static string CreateMD5(string text)
        {
            // Use input string to calculate MD5 hash
            {
                MD5 md5 = new MD5CryptoServiceProvider();

                //compute hash from the bytes of text  
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

                //get hash result after compute it  
                byte[] result = md5.Hash;

                StringBuilder strBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    //change it into 2 hexadecimal digits  
                    //for each byte  
                    strBuilder.Append(result[i].ToString("x2"));
                }

                return strBuilder.ToString();
            }
        }

        private void ASL_Load(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabGestion);
            tabControl.TabPages.Remove(tabAteliers);
        }

        private void cbxGestionAtelier_Enter(object sender, EventArgs e)
        {
            cbxGestionAtelier.ResetText();
            cbxGestionAtelier.DataSource = new BindingSource(lesAteliers, null);
            cbxGestionAtelier.DisplayMember = "Value";
            cbxGestionAtelier.ValueMember = "Key";
        }

        private void afficherListeAnimateur()
        {
            KeyValuePair<int, String> laSelection = (KeyValuePair<int, String>)cbxGestionAtelier.SelectedItem;
            int idAtelier = laSelection.Key;
            Dictionary<int, String> lesParticipantsSaufAnimateur = DAOParticipant.getDicoIntervenants(idAtelier);
            cbxAnimateur.ResetText();
            cbxAnimateur.DataSource = new BindingSource(lesParticipantsSaufAnimateur, null);
            cbxAnimateur.DisplayMember = "Value";
            cbxAnimateur.ValueMember = "Key";

        }

        private void afficherListeIntervenants()
        {
            KeyValuePair<int, String> laSelection = (KeyValuePair<int, String>)cbxGestionAtelier.SelectedItem;
            int idAtelier = laSelection.Key;
            Dictionary<int, String> lesParticipantsDansAtelier = DAOParticipant.getDicoIntervenantDansAtelier(idAtelier);
            cbxIntervenants.ResetText();
            cbxIntervenants.DataSource = new BindingSource(lesParticipantsDansAtelier, null);
            cbxIntervenants.DisplayMember = "Value";
            cbxIntervenants.ValueMember = "Key";

        }
        private void afficherListeIntervenantsNonAffecter()
        {
            KeyValuePair<int, String> laSelection = (KeyValuePair<int, String>)cbxGestionAtelier.SelectedItem;
            int idAtelier = laSelection.Key;
            Dictionary<int, String> lesParticipantsDansAtelier = DAOParticipant.getDicoIntervenantsNonAffecter(idAtelier);
            
                
            cbxAffecterIntervenant.ResetText();
            cbxAffecterIntervenant.DataSource = new BindingSource(lesParticipantsDansAtelier, null);
            cbxAffecterIntervenant.DisplayMember = "Value";
            cbxAffecterIntervenant.ValueMember = "Key";
            
            

        }
        private void afficherNbrIntervenant()
        {
            KeyValuePair<int, String> laSelection = (KeyValuePair<int, String>)cbxGestionAtelier.SelectedItem;
            int idAtelier = laSelection.Key;
            Atelier unAtelier = DAOAtelier.getUnAtelier(idAtelier);
            int capaciteAtelier = unAtelier.CapaciteMax;
            int nbrIntervenant = DAOParticipant.getNombreParticipantDansAtelier(idAtelier);
            txtBoxPlaces.Text = nbrIntervenant +"";
            txtBoxCapaciteMax.Text = capaciteAtelier + "";
        }

        private void afficherHeures()
        {
            KeyValuePair<int, String> laSelection = (KeyValuePair<int, String>)cbxGestionAtelier.SelectedItem;
            int idAtelier = laSelection.Key;
            Atelier unAtelier = DAOAtelier.getUnAtelier(idAtelier);
            String heure_Debut = unAtelier.HeureDebut;
            String heure_Fin = unAtelier.HeureFin;
            char[] charsHeureDebut = heure_Debut.ToCharArray(0, 2);
            char[] charsHeureFin = heure_Fin.ToCharArray(0, 2);
            string HeureDebut = new string(charsHeureDebut);
            string HeureFin = new string(charsHeureFin);
            txtBoxHeureD.Text = HeureDebut;
            txtBoxHeureF.Text = HeureFin;

            charsHeureDebut = heure_Debut.ToCharArray(3, 2);
            charsHeureFin = heure_Fin.ToCharArray(3, 2);
            HeureDebut = new string(charsHeureDebut);
            HeureFin = new string(charsHeureFin);
            txtBoxMinuteD.Text = HeureDebut;
            txtBoxMinuteF.Text = HeureFin;

            lblFormatHeure.Text = "Format attendu : \n '00', '01', '02', '03' \n... '21', '22', '23'";
            
        }

        private void cbxGestionAtelier_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, String> laSelection = (KeyValuePair<int, String>)cbxGestionAtelier.SelectedItem;
            int idAtelier = laSelection.Key;
            Atelier unAtelier = DAOAtelier.getUnAtelier(idAtelier);
            int idAnimateur = unAtelier.Id_Participant;
            afficherNbrIntervenant();
            afficherListeAnimateur();
            afficherListeIntervenants();
            afficherListeIntervenantsNonAffecter();
            afficherHeures();

        }

        private void btnDesaffecter_Click(object sender, EventArgs e)
        {
            
            KeyValuePair<int, String> selectedEntryIntervenants = (KeyValuePair<int, String>)cbxIntervenants.SelectedItem;
            int keyIntervenants = selectedEntryIntervenants.Key;
            string valueIntervenants = selectedEntryIntervenants.Value;

            int tailleListeDeroulante = cbxIntervenants.Items.Count;
            if(cbxIntervenants.SelectedIndex != -1)
            {
                Participant.supprimerIntervenant(keyIntervenants);
                MessageBox.Show("Vous avez bien désaffecter " + valueIntervenants);
                afficherListeIntervenants();
                afficherNbrIntervenant();
                afficherListeIntervenantsNonAffecter();
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas supprimer l'animateur.");
            }
        }

        private void btnAffecterIntervenant_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, String> selection_cbxAtelier = (KeyValuePair<int, String>)cbxGestionAtelier.SelectedItem;
            int IdAtelier = selection_cbxAtelier.Key;

            int nombreParticipantAAffecter = DAOParticipant.getNombreParticipantNonAffecter(IdAtelier);
            if (nombreParticipantAAffecter != 0)
            {
                Atelier unAtelier = DAOAtelier.getUnAtelier(IdAtelier);
                int capaciteAtelier = unAtelier.CapaciteMax;
                int nbrIntervenant = DAOParticipant.getNombreParticipantDansAtelier(IdAtelier);
                if (nbrIntervenant < capaciteAtelier)
                {
                    KeyValuePair<int, String> selection_cbxIntervenants = (KeyValuePair<int, String>)cbxAffecterIntervenant.SelectedItem;
                    int IdIntervenant = selection_cbxIntervenants.Key;
                    Participant.insertIntervenant(IdIntervenant, IdAtelier);
                    afficherListeIntervenants();
                    afficherListeIntervenantsNonAffecter();
                    afficherNbrIntervenant();
                }
                else
                {
                    MessageBox.Show("L'atelier est plein.");
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez plus affecter des intervenants car il n'y en a plus à affecter.");


            }
           

            
            
            
        }

        private void cbxAnimateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, String> selection_cbxGestionAtelier = (KeyValuePair<int, String>)cbxGestionAtelier.SelectedItem;
             int idAtelier = selection_cbxGestionAtelier.Key;
            Atelier LAtelier = Atelier.getAtelier(idAtelier);
            Participant animateur = Participant.getParticipant(LAtelier.Id_Participant);

            KeyValuePair<int, String> selected_NomAnimateur = (KeyValuePair<int, String>)cbxAnimateur.SelectedItem;
            int idNouveauAnimateur = selected_NomAnimateur.Key;
            int idAncienAnimateur = animateur.Id;
            Atelier.updateAnimateur(idAncienAnimateur, idNouveauAnimateur);
        }

        private void btnHeure_Click(object sender, EventArgs e)
        {
            string[] tabHeure = new string[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" };
            if (txtBoxHeureD.Text != "" && txtBoxMinuteD.Text != "" && txtBoxHeureF.Text != "" && txtBoxMinuteF.Text != "")
            {
                if (Int16.Parse(txtBoxHeureD.Text) != Int16.Parse(txtBoxHeureF.Text))
                {
                    if (tabHeure.Contains(txtBoxHeureD.Text).ToString() == "True" &&
                        tabHeure.Contains(txtBoxMinuteD.Text).ToString() == "True" &&
                        tabHeure.Contains(txtBoxHeureF.Text).ToString() == "True" &&
                        tabHeure.Contains(txtBoxMinuteF.Text).ToString() == "True")
                    {
                        KeyValuePair<int, String> selection_cbxGestionAtelier = (KeyValuePair<int, String>)cbxGestionAtelier.SelectedItem;
                        int idAtelier = selection_cbxGestionAtelier.Key;
                        String heureDebut = txtBoxHeureD.Text + ":" + txtBoxMinuteD.Text + ":00.00";
                        String heureFin = txtBoxHeureF.Text + ":" + txtBoxMinuteF.Text + ":00.00";
                        DAOAtelier.updateHeure(idAtelier, heureDebut, heureFin);
                        MessageBox.Show("L'heure de début et fin a bien été modifiée.");

                    }
                    else
                    {
                        MessageBox.Show("Le format de l'heure n'est pas bon. Format attendu pour l'heure, minute: exemple (00), (01), (02) ");
                        afficherHeures();
                    }
                }
                else 
                {
                    MessageBox.Show("L'heure de fin ne peut pas être égale à l'heure de début.");
                    afficherHeures();
                }
            }
            else
            {
                MessageBox.Show("L'heure de début et de fin ne peuvent pas être vide.");
            }
            
        }

        private void btnCapacite_Click(object sender, EventArgs e)
        {
            if (txtBoxCapaciteMax.Text != "" && txtBoxCapaciteMax.Text != "")
            {
                int capacite = Int16.Parse(txtBoxCapaciteMax.Text);
                int places = Int16.Parse(txtBoxPlaces.Text);
                if (txtBoxCapaciteMax.Text != "" && capacite >= places)
                {
                    KeyValuePair<int, String> selection_cbxGestionAtelier = (KeyValuePair<int, String>)cbxGestionAtelier.SelectedItem;
                    int idAtelier = selection_cbxGestionAtelier.Key;
                    MessageBox.Show("La capacité maximum de l'atelier a bien été modifiée.");
                    DAOAtelier.updateCapacite(capacite, idAtelier);
                }
                else
                {
                    MessageBox.Show("Impossible de changer la capacité car il y a "+ places + " intervenants.\n" +
                        "Veuillez retirer les intervenants avant de modifier la capacité. ");
                    afficherNbrIntervenant();
                }
            }
            else
            {
                MessageBox.Show("Veuillez choisir un atelier.");
            }
                
            
        }

        private void btnDeco_Click(object sender, EventArgs e)
        {
            deconnexion();
        }

        private void btnDeco2_Click(object sender, EventArgs e)
        {
            deconnexion();
        }
    }
}
