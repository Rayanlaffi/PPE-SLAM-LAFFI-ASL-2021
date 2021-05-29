namespace PPE_SLAM_LAFFI_ASL
{
    partial class ASL
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAteliers = new System.Windows.Forms.TabPage();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIntervenant = new System.Windows.Forms.DataGridView();
            this.dgvTheme = new System.Windows.Forms.DataGridView();
            this.dgvAtelier = new System.Windows.Forms.DataGridView();
            this.cbxAtelier = new System.Windows.Forms.ComboBox();
            this.tabGestion = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxCapaciteMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxPlaces = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxMinuteF = new System.Windows.Forms.TextBox();
            this.txtBoxHeureF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxMinuteD = new System.Windows.Forms.TextBox();
            this.txtBoxHeureD = new System.Windows.Forms.TextBox();
            this.btnAffecterIntervenant = new System.Windows.Forms.Button();
            this.btnDesaffecter = new System.Windows.Forms.Button();
            this.cbxAffecterIntervenant = new System.Windows.Forms.ComboBox();
            this.lblParticipant = new System.Windows.Forms.Label();
            this.cbxIntervenants = new System.Windows.Forms.ComboBox();
            this.lblIntervenants = new System.Windows.Forms.Label();
            this.cbxAnimateur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxGestionAtelier = new System.Windows.Forms.ComboBox();
            this.lblConnexion2 = new System.Windows.Forms.Label();
            this.tabConnexion = new System.Windows.Forms.TabPage();
            this.lblErreur = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnCapacite = new System.Windows.Forms.Button();
            this.btnHeure = new System.Windows.Forms.Button();
            this.lblFormatHeure = new System.Windows.Forms.Label();
            this.btnDeco = new System.Windows.Forms.Button();
            this.btnDeco2 = new System.Windows.Forms.Button();
            this.theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intervenants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomAtelier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.places = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabAteliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtelier)).BeginInit();
            this.tabGestion.SuspendLayout();
            this.tabConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAteliers);
            this.tabControl.Controls.Add(this.tabGestion);
            this.tabControl.Controls.Add(this.tabConnexion);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabAteliers
            // 
            this.tabAteliers.Controls.Add(this.btnDeco2);
            this.tabAteliers.Controls.Add(this.lblConnexion);
            this.tabAteliers.Controls.Add(this.label1);
            this.tabAteliers.Controls.Add(this.dgvIntervenant);
            this.tabAteliers.Controls.Add(this.dgvTheme);
            this.tabAteliers.Controls.Add(this.dgvAtelier);
            this.tabAteliers.Controls.Add(this.cbxAtelier);
            this.tabAteliers.Location = new System.Drawing.Point(4, 22);
            this.tabAteliers.Name = "tabAteliers";
            this.tabAteliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabAteliers.Size = new System.Drawing.Size(792, 424);
            this.tabAteliers.TabIndex = 0;
            this.tabAteliers.Text = "Ateliers";
            this.tabAteliers.UseVisualStyleBackColor = true;
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Location = new System.Drawing.Point(27, 15);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(106, 13);
            this.lblConnexion.TabIndex = 5;
            this.lblConnexion.Text = "INFOS CONNEXION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Afficher les horaires de chaque atelier :";
            // 
            // dgvIntervenant
            // 
            this.dgvIntervenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervenant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervenants});
            this.dgvIntervenant.Location = new System.Drawing.Point(464, 176);
            this.dgvIntervenant.Name = "dgvIntervenant";
            this.dgvIntervenant.Size = new System.Drawing.Size(287, 150);
            this.dgvIntervenant.TabIndex = 3;
            // 
            // dgvTheme
            // 
            this.dgvTheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.theme});
            this.dgvTheme.Location = new System.Drawing.Point(65, 176);
            this.dgvTheme.Name = "dgvTheme";
            this.dgvTheme.Size = new System.Drawing.Size(393, 150);
            this.dgvTheme.TabIndex = 2;
            // 
            // dgvAtelier
            // 
            this.dgvAtelier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtelier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomAtelier,
            this.animateur,
            this.heureDebut,
            this.heureFin,
            this.places});
            this.dgvAtelier.Location = new System.Drawing.Point(65, 90);
            this.dgvAtelier.Name = "dgvAtelier";
            this.dgvAtelier.Size = new System.Drawing.Size(686, 80);
            this.dgvAtelier.TabIndex = 1;
            // 
            // cbxAtelier
            // 
            this.cbxAtelier.FormattingEnabled = true;
            this.cbxAtelier.Location = new System.Drawing.Point(65, 54);
            this.cbxAtelier.Name = "cbxAtelier";
            this.cbxAtelier.Size = new System.Drawing.Size(384, 21);
            this.cbxAtelier.TabIndex = 0;
            this.cbxAtelier.SelectedIndexChanged += new System.EventHandler(this.cbxAtelier_SelectedIndexChanged);
            this.cbxAtelier.Enter += new System.EventHandler(this.cbxAtelier_Enter);
            // 
            // tabGestion
            // 
            this.tabGestion.Controls.Add(this.label13);
            this.tabGestion.Controls.Add(this.pictureBox1);
            this.tabGestion.Controls.Add(this.btnDeco);
            this.tabGestion.Controls.Add(this.lblFormatHeure);
            this.tabGestion.Controls.Add(this.btnHeure);
            this.tabGestion.Controls.Add(this.btnCapacite);
            this.tabGestion.Controls.Add(this.label12);
            this.tabGestion.Controls.Add(this.label11);
            this.tabGestion.Controls.Add(this.label10);
            this.tabGestion.Controls.Add(this.txtBoxCapaciteMax);
            this.tabGestion.Controls.Add(this.label9);
            this.tabGestion.Controls.Add(this.txtBoxPlaces);
            this.tabGestion.Controls.Add(this.label8);
            this.tabGestion.Controls.Add(this.txtBoxMinuteF);
            this.tabGestion.Controls.Add(this.txtBoxHeureF);
            this.tabGestion.Controls.Add(this.label7);
            this.tabGestion.Controls.Add(this.txtBoxMinuteD);
            this.tabGestion.Controls.Add(this.txtBoxHeureD);
            this.tabGestion.Controls.Add(this.btnAffecterIntervenant);
            this.tabGestion.Controls.Add(this.btnDesaffecter);
            this.tabGestion.Controls.Add(this.cbxAffecterIntervenant);
            this.tabGestion.Controls.Add(this.lblParticipant);
            this.tabGestion.Controls.Add(this.cbxIntervenants);
            this.tabGestion.Controls.Add(this.lblIntervenants);
            this.tabGestion.Controls.Add(this.cbxAnimateur);
            this.tabGestion.Controls.Add(this.label6);
            this.tabGestion.Controls.Add(this.label5);
            this.tabGestion.Controls.Add(this.cbxGestionAtelier);
            this.tabGestion.Controls.Add(this.lblConnexion2);
            this.tabGestion.Location = new System.Drawing.Point(4, 22);
            this.tabGestion.Name = "tabGestion";
            this.tabGestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestion.Size = new System.Drawing.Size(792, 424);
            this.tabGestion.TabIndex = 1;
            this.tabGestion.Text = "Gestion";
            this.tabGestion.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "H";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "H";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = " / ";
            // 
            // txtBoxCapaciteMax
            // 
            this.txtBoxCapaciteMax.Location = new System.Drawing.Point(361, 117);
            this.txtBoxCapaciteMax.Name = "txtBoxCapaciteMax";
            this.txtBoxCapaciteMax.Size = new System.Drawing.Size(28, 20);
            this.txtBoxCapaciteMax.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Nombre d\'intervenants dans l\'atelier : ";
            // 
            // txtBoxPlaces
            // 
            this.txtBoxPlaces.Location = new System.Drawing.Point(310, 117);
            this.txtBoxPlaces.Name = "txtBoxPlaces";
            this.txtBoxPlaces.ReadOnly = true;
            this.txtBoxPlaces.Size = new System.Drawing.Size(28, 20);
            this.txtBoxPlaces.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Horaire  de fin :";
            // 
            // txtBoxMinuteF
            // 
            this.txtBoxMinuteF.Location = new System.Drawing.Point(281, 255);
            this.txtBoxMinuteF.MaxLength = 2;
            this.txtBoxMinuteF.Name = "txtBoxMinuteF";
            this.txtBoxMinuteF.Size = new System.Drawing.Size(24, 20);
            this.txtBoxMinuteF.TabIndex = 21;
            // 
            // txtBoxHeureF
            // 
            this.txtBoxHeureF.Location = new System.Drawing.Point(242, 255);
            this.txtBoxHeureF.MaxLength = 2;
            this.txtBoxHeureF.Name = "txtBoxHeureF";
            this.txtBoxHeureF.Size = new System.Drawing.Size(24, 20);
            this.txtBoxHeureF.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Horaire de début :";
            // 
            // txtBoxMinuteD
            // 
            this.txtBoxMinuteD.Location = new System.Drawing.Point(181, 255);
            this.txtBoxMinuteD.MaxLength = 2;
            this.txtBoxMinuteD.Name = "txtBoxMinuteD";
            this.txtBoxMinuteD.Size = new System.Drawing.Size(24, 20);
            this.txtBoxMinuteD.TabIndex = 18;
            // 
            // txtBoxHeureD
            // 
            this.txtBoxHeureD.Location = new System.Drawing.Point(142, 255);
            this.txtBoxHeureD.MaxLength = 2;
            this.txtBoxHeureD.Name = "txtBoxHeureD";
            this.txtBoxHeureD.Size = new System.Drawing.Size(24, 20);
            this.txtBoxHeureD.TabIndex = 17;
            // 
            // btnAffecterIntervenant
            // 
            this.btnAffecterIntervenant.Location = new System.Drawing.Point(289, 207);
            this.btnAffecterIntervenant.Name = "btnAffecterIntervenant";
            this.btnAffecterIntervenant.Size = new System.Drawing.Size(160, 23);
            this.btnAffecterIntervenant.TabIndex = 16;
            this.btnAffecterIntervenant.Text = "Affecter l\'intervenant";
            this.btnAffecterIntervenant.UseVisualStyleBackColor = true;
            this.btnAffecterIntervenant.Click += new System.EventHandler(this.btnAffecterIntervenant_Click);
            // 
            // btnDesaffecter
            // 
            this.btnDesaffecter.Location = new System.Drawing.Point(289, 164);
            this.btnDesaffecter.Name = "btnDesaffecter";
            this.btnDesaffecter.Size = new System.Drawing.Size(160, 23);
            this.btnDesaffecter.TabIndex = 15;
            this.btnDesaffecter.Text = "Retirer l\'intervenant";
            this.btnDesaffecter.UseVisualStyleBackColor = true;
            this.btnDesaffecter.Click += new System.EventHandler(this.btnDesaffecter_Click);
            // 
            // cbxAffecterIntervenant
            // 
            this.cbxAffecterIntervenant.FormattingEnabled = true;
            this.cbxAffecterIntervenant.Location = new System.Drawing.Point(142, 209);
            this.cbxAffecterIntervenant.Name = "cbxAffecterIntervenant";
            this.cbxAffecterIntervenant.Size = new System.Drawing.Size(141, 21);
            this.cbxAffecterIntervenant.TabIndex = 14;
            // 
            // lblParticipant
            // 
            this.lblParticipant.AutoSize = true;
            this.lblParticipant.Location = new System.Drawing.Point(139, 193);
            this.lblParticipant.Name = "lblParticipant";
            this.lblParticipant.Size = new System.Drawing.Size(115, 13);
            this.lblParticipant.TabIndex = 13;
            this.lblParticipant.Text = "Intervenant à affecter :";
            // 
            // cbxIntervenants
            // 
            this.cbxIntervenants.FormattingEnabled = true;
            this.cbxIntervenants.Location = new System.Drawing.Point(142, 166);
            this.cbxIntervenants.Name = "cbxIntervenants";
            this.cbxIntervenants.Size = new System.Drawing.Size(141, 21);
            this.cbxIntervenants.TabIndex = 12;
            // 
            // lblIntervenants
            // 
            this.lblIntervenants.AutoSize = true;
            this.lblIntervenants.Location = new System.Drawing.Point(139, 150);
            this.lblIntervenants.Name = "lblIntervenants";
            this.lblIntervenants.Size = new System.Drawing.Size(136, 13);
            this.lblIntervenants.TabIndex = 11;
            this.lblIntervenants.Text = "Intervenants dans l\'atelier : ";
            this.lblIntervenants.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbxAnimateur
            // 
            this.cbxAnimateur.FormattingEnabled = true;
            this.cbxAnimateur.Location = new System.Drawing.Point(142, 117);
            this.cbxAnimateur.Name = "cbxAnimateur";
            this.cbxAnimateur.Size = new System.Drawing.Size(141, 21);
            this.cbxAnimateur.TabIndex = 10;
            this.cbxAnimateur.SelectedIndexChanged += new System.EventHandler(this.cbxAnimateur_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Animateur :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Veuillez choisir un atelier : ";
            // 
            // cbxGestionAtelier
            // 
            this.cbxGestionAtelier.FormattingEnabled = true;
            this.cbxGestionAtelier.Location = new System.Drawing.Point(142, 75);
            this.cbxGestionAtelier.Name = "cbxGestionAtelier";
            this.cbxGestionAtelier.Size = new System.Drawing.Size(384, 21);
            this.cbxGestionAtelier.TabIndex = 7;
            this.cbxGestionAtelier.SelectedIndexChanged += new System.EventHandler(this.cbxGestionAtelier_SelectedIndexChanged);
            this.cbxGestionAtelier.Enter += new System.EventHandler(this.cbxGestionAtelier_Enter);
            // 
            // lblConnexion2
            // 
            this.lblConnexion2.AutoSize = true;
            this.lblConnexion2.Location = new System.Drawing.Point(23, 18);
            this.lblConnexion2.Name = "lblConnexion2";
            this.lblConnexion2.Size = new System.Drawing.Size(106, 13);
            this.lblConnexion2.TabIndex = 6;
            this.lblConnexion2.Text = "INFOS CONNEXION";
            // 
            // tabConnexion
            // 
            this.tabConnexion.Controls.Add(this.lblErreur);
            this.tabConnexion.Controls.Add(this.label4);
            this.tabConnexion.Controls.Add(this.label3);
            this.tabConnexion.Controls.Add(this.textBoxMdp);
            this.tabConnexion.Controls.Add(this.textBoxLogin);
            this.tabConnexion.Controls.Add(this.label2);
            this.tabConnexion.Controls.Add(this.btnValider);
            this.tabConnexion.Location = new System.Drawing.Point(4, 22);
            this.tabConnexion.Name = "tabConnexion";
            this.tabConnexion.Size = new System.Drawing.Size(792, 424);
            this.tabConnexion.TabIndex = 2;
            this.tabConnexion.Text = "Se connecter";
            this.tabConnexion.UseVisualStyleBackColor = true;
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Location = new System.Drawing.Point(352, 224);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(126, 13);
            this.lblErreur.TabIndex = 6;
            this.lblErreur.Text = "Veuillez vous connecter !";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label4.Location = new System.Drawing.Point(260, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "SE CONNECTER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe : ";
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(311, 161);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.PasswordChar = '*';
            this.textBoxMdp.Size = new System.Drawing.Size(209, 20);
            this.textBoxMdp.TabIndex = 3;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(311, 124);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(209, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email : ";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(311, 187);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(209, 23);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Se connecter";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnCapacite
            // 
            this.btnCapacite.Location = new System.Drawing.Point(395, 115);
            this.btnCapacite.Name = "btnCapacite";
            this.btnCapacite.Size = new System.Drawing.Size(131, 23);
            this.btnCapacite.TabIndex = 29;
            this.btnCapacite.Text = "Changer la capacité :";
            this.btnCapacite.UseVisualStyleBackColor = true;
            this.btnCapacite.Click += new System.EventHandler(this.btnCapacite_Click);
            // 
            // btnHeure
            // 
            this.btnHeure.Location = new System.Drawing.Point(142, 281);
            this.btnHeure.Name = "btnHeure";
            this.btnHeure.Size = new System.Drawing.Size(163, 23);
            this.btnHeure.TabIndex = 30;
            this.btnHeure.Text = "Changer la capacité :";
            this.btnHeure.UseVisualStyleBackColor = true;
            this.btnHeure.Click += new System.EventHandler(this.btnHeure_Click);
            // 
            // lblFormatHeure
            // 
            this.lblFormatHeure.AutoSize = true;
            this.lblFormatHeure.Location = new System.Drawing.Point(322, 242);
            this.lblFormatHeure.Name = "lblFormatHeure";
            this.lblFormatHeure.Size = new System.Drawing.Size(117, 13);
            this.lblFormatHeure.TabIndex = 31;
            this.lblFormatHeure.Text = "ATTENTION FORMAT";
            // 
            // btnDeco
            // 
            this.btnDeco.Location = new System.Drawing.Point(629, 13);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(145, 23);
            this.btnDeco.TabIndex = 32;
            this.btnDeco.Text = "Se deconnecter";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // btnDeco2
            // 
            this.btnDeco2.Location = new System.Drawing.Point(628, 10);
            this.btnDeco2.Name = "btnDeco2";
            this.btnDeco2.Size = new System.Drawing.Size(145, 23);
            this.btnDeco2.TabIndex = 33;
            this.btnDeco2.Text = "Se deconnecter";
            this.btnDeco2.UseVisualStyleBackColor = true;
            this.btnDeco2.Click += new System.EventHandler(this.btnDeco2_Click);
            // 
            // theme
            // 
            this.theme.HeaderText = "Thèmes";
            this.theme.Name = "theme";
            this.theme.ReadOnly = true;
            this.theme.Width = 393;
            // 
            // intervenants
            // 
            this.intervenants.HeaderText = "Intervenants";
            this.intervenants.Name = "intervenants";
            this.intervenants.ReadOnly = true;
            this.intervenants.Width = 232;
            // 
            // nomAtelier
            // 
            this.nomAtelier.Frozen = true;
            this.nomAtelier.HeaderText = "Nom de l\'atelier";
            this.nomAtelier.Name = "nomAtelier";
            this.nomAtelier.ReadOnly = true;
            this.nomAtelier.Width = 250;
            // 
            // animateur
            // 
            this.animateur.Frozen = true;
            this.animateur.HeaderText = "Animateur";
            this.animateur.Name = "animateur";
            this.animateur.ReadOnly = true;
            // 
            // heureDebut
            // 
            this.heureDebut.Frozen = true;
            this.heureDebut.HeaderText = "Heure de début";
            this.heureDebut.Name = "heureDebut";
            this.heureDebut.ReadOnly = true;
            // 
            // heureFin
            // 
            this.heureFin.Frozen = true;
            this.heureFin.HeaderText = "Heure de fin";
            this.heureFin.Name = "heureFin";
            this.heureFin.ReadOnly = true;
            // 
            // places
            // 
            this.places.Frozen = true;
            this.places.HeaderText = "Places restantes";
            this.places.Name = "places";
            this.places.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPE_SLAM_LAFFI_ASL.Properties.Resources.icof;
            this.pictureBox1.Location = new System.Drawing.Point(505, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 108);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(579, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "PPE LAFFI RAYAN";
            // 
            // ASL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "ASL";
            this.Text = "PROJET ASL";
            this.Load += new System.EventHandler(this.ASL_Load);
            this.tabControl.ResumeLayout(false);
            this.tabAteliers.ResumeLayout(false);
            this.tabAteliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtelier)).EndInit();
            this.tabGestion.ResumeLayout(false);
            this.tabGestion.PerformLayout();
            this.tabConnexion.ResumeLayout(false);
            this.tabConnexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAteliers;
        private System.Windows.Forms.ComboBox cbxAtelier;
        private System.Windows.Forms.TabPage tabGestion;
        private System.Windows.Forms.DataGridView dgvIntervenant;
        private System.Windows.Forms.DataGridView dgvTheme;
        private System.Windows.Forms.DataGridView dgvAtelier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabConnexion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.Label lblConnexion2;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxGestionAtelier;
        private System.Windows.Forms.ComboBox cbxAnimateur;
        private System.Windows.Forms.ComboBox cbxIntervenants;
        private System.Windows.Forms.Label lblIntervenants;
        private System.Windows.Forms.ComboBox cbxAffecterIntervenant;
        private System.Windows.Forms.Label lblParticipant;
        private System.Windows.Forms.Button btnAffecterIntervenant;
        private System.Windows.Forms.Button btnDesaffecter;
        private System.Windows.Forms.TextBox txtBoxMinuteD;
        private System.Windows.Forms.TextBox txtBoxHeureD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxMinuteF;
        private System.Windows.Forms.TextBox txtBoxHeureF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxPlaces;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxCapaciteMax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHeure;
        private System.Windows.Forms.Button btnCapacite;
        private System.Windows.Forms.Label lblFormatHeure;
        private System.Windows.Forms.Button btnDeco;
        private System.Windows.Forms.Button btnDeco2;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervenants;
        private System.Windows.Forms.DataGridViewTextBoxColumn theme;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomAtelier;
        private System.Windows.Forms.DataGridViewTextBoxColumn animateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn places;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
    }
}

