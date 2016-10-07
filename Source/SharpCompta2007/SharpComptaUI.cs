using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Globalization;
using CoucheAcceeDonnees;


namespace SharpCompta2007
{
	/// <summary>
	/// Description résumée de Form1.
	/// </summary>
	public class SharpComptaUI : System.Windows.Forms.Form
	{
       
		private System.Windows.Forms.MainMenu mainMenu1;
        private MenuItem Menu_PlanComptable;
        private MenuItem Menu_Saisie_PlanComptable;
        private MenuItem menuItem5;
        private MenuItem Menu_Listing_PlanComptable;
        private MenuItem Menu_JournauxAuxiliaires;
        private MenuItem Menu_Saisie_JournauxAuxilliaires;
        private MenuItem menuItem4;
        private MenuItem Menu_Listing_JournauxAuxilliaires;
        private MenuItem Menu_LibellesAutomatiques;
        private MenuItem Menu_Saisie_LibellésAutomatiques;
        private MenuItem menuItem3;
        private MenuItem Menu_Listing_LibellesAutomatiques;
        private MenuItem Menu_Operations;
        private MenuItem Menu_Saisie_Operations;
        private MenuItem menuItem2;
        private MenuItem Menu_Affichage_Journaux;
        private MenuItem Menu_Livres;
        private MenuItem Menu_Affichage_GrandLivre;
        private MenuItem menuItem1;
        private MenuItem Menu_Affichage_Balance;
        private MenuItem Menu_Donnees;
        private MenuItem Menu_Affichage_Importations; 
        
        private MenuItem menu_apropos;
        private Label SoftwareInfo;
        private Label AuthorInfo;
        private Label ContactInfo;

        private IContainer components;

        CoucheAcceeDonnees.CAD db;
        SqlConnection SqlServerConnection;
        OleDbConnection AcessConnection;
        private string an;
        private MenuItem menu_dossier;
        private MenuItem menuItem6;

       
        private string RaisonSocial;
        

        public SharpComptaUI()
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			//
			// TODO : ajoutez le code du constructeur après l'appel à InitializeComponent
			//
		}

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.Menu_PlanComptable = new System.Windows.Forms.MenuItem();
            this.Menu_Saisie_PlanComptable = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.Menu_Listing_PlanComptable = new System.Windows.Forms.MenuItem();
            this.Menu_JournauxAuxiliaires = new System.Windows.Forms.MenuItem();
            this.Menu_Saisie_JournauxAuxilliaires = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.Menu_Listing_JournauxAuxilliaires = new System.Windows.Forms.MenuItem();
            this.Menu_LibellesAutomatiques = new System.Windows.Forms.MenuItem();
            this.Menu_Saisie_LibellésAutomatiques = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.Menu_Listing_LibellesAutomatiques = new System.Windows.Forms.MenuItem();
            this.Menu_Operations = new System.Windows.Forms.MenuItem();
            this.Menu_Saisie_Operations = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.Menu_Affichage_Journaux = new System.Windows.Forms.MenuItem();
            this.Menu_Livres = new System.Windows.Forms.MenuItem();
            this.Menu_Affichage_GrandLivre = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.Menu_Affichage_Balance = new System.Windows.Forms.MenuItem();
            this.Menu_Donnees = new System.Windows.Forms.MenuItem();
            this.Menu_Affichage_Importations = new System.Windows.Forms.MenuItem();
            this.menu_apropos = new System.Windows.Forms.MenuItem();
            this.SoftwareInfo = new System.Windows.Forms.Label();
            this.AuthorInfo = new System.Windows.Forms.Label();
            this.ContactInfo = new System.Windows.Forms.Label();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menu_dossier = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_PlanComptable,
            this.Menu_JournauxAuxiliaires,
            this.Menu_LibellesAutomatiques,
            this.Menu_Operations,
            this.Menu_Livres,
            this.Menu_Donnees,
            this.menu_apropos});
            // 
            // Menu_PlanComptable
            // 
            this.Menu_PlanComptable.Index = 0;
            this.Menu_PlanComptable.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_Saisie_PlanComptable,
            this.menuItem5,
            this.Menu_Listing_PlanComptable});
            this.Menu_PlanComptable.Text = "Plan Comptable";
            // 
            // Menu_Saisie_PlanComptable
            // 
            this.Menu_Saisie_PlanComptable.Index = 0;
            this.Menu_Saisie_PlanComptable.Text = "Saisie";
            this.Menu_Saisie_PlanComptable.Click += new System.EventHandler(this.Menu_Saisie_PlanComptable_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "-";
            // 
            // Menu_Listing_PlanComptable
            // 
            this.Menu_Listing_PlanComptable.Index = 2;
            this.Menu_Listing_PlanComptable.Text = "Listing";
            this.Menu_Listing_PlanComptable.Click += new System.EventHandler(this.Menu_Affichage_PlanComptable_Click);
            // 
            // Menu_JournauxAuxiliaires
            // 
            this.Menu_JournauxAuxiliaires.Index = 1;
            this.Menu_JournauxAuxiliaires.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_Saisie_JournauxAuxilliaires,
            this.menuItem4,
            this.Menu_Listing_JournauxAuxilliaires});
            this.Menu_JournauxAuxiliaires.Text = "Journaux Auxilliaires";
            // 
            // Menu_Saisie_JournauxAuxilliaires
            // 
            this.Menu_Saisie_JournauxAuxilliaires.Index = 0;
            this.Menu_Saisie_JournauxAuxilliaires.Text = "Saisie";
            this.Menu_Saisie_JournauxAuxilliaires.Click += new System.EventHandler(this.Menu_Saisie_JournauxAuxilliaires_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // Menu_Listing_JournauxAuxilliaires
            // 
            this.Menu_Listing_JournauxAuxilliaires.Index = 2;
            this.Menu_Listing_JournauxAuxilliaires.Text = "Listing";
            this.Menu_Listing_JournauxAuxilliaires.Click += new System.EventHandler(this.Menu_Affichage_JournauxAuxilliaires_Click);
            // 
            // Menu_LibellesAutomatiques
            // 
            this.Menu_LibellesAutomatiques.Index = 2;
            this.Menu_LibellesAutomatiques.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_Saisie_LibellésAutomatiques,
            this.menuItem3,
            this.Menu_Listing_LibellesAutomatiques});
            this.Menu_LibellesAutomatiques.Text = "Libellés Automatique";
            // 
            // Menu_Saisie_LibellésAutomatiques
            // 
            this.Menu_Saisie_LibellésAutomatiques.Index = 0;
            this.Menu_Saisie_LibellésAutomatiques.Text = "Saisie";
            this.Menu_Saisie_LibellésAutomatiques.Click += new System.EventHandler(this.Menu_Saisie_LibellésAutomatiques_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // Menu_Listing_LibellesAutomatiques
            // 
            this.Menu_Listing_LibellesAutomatiques.Index = 2;
            this.Menu_Listing_LibellesAutomatiques.Text = "Listing";
            this.Menu_Listing_LibellesAutomatiques.Click += new System.EventHandler(this.Menu_Affichage_LibellesAutomatiques_Click);
            // 
            // Menu_Operations
            // 
            this.Menu_Operations.Index = 3;
            this.Menu_Operations.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_Saisie_Operations,
            this.menuItem2,
            this.Menu_Affichage_Journaux});
            this.Menu_Operations.Text = "Ecritures";
            // 
            // Menu_Saisie_Operations
            // 
            this.Menu_Saisie_Operations.Index = 0;
            this.Menu_Saisie_Operations.Text = "Saisie";
            this.Menu_Saisie_Operations.Click += new System.EventHandler(this.Menu_Saisie_Operations_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // Menu_Affichage_Journaux
            // 
            this.Menu_Affichage_Journaux.Index = 2;
            this.Menu_Affichage_Journaux.Text = "Affichage Journaux";
            this.Menu_Affichage_Journaux.Click += new System.EventHandler(this.Menu_Affichage_Journaux_Click);
            // 
            // Menu_Livres
            // 
            this.Menu_Livres.Index = 4;
            this.Menu_Livres.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_Affichage_GrandLivre,
            this.menuItem1,
            this.Menu_Affichage_Balance});
            this.Menu_Livres.Text = "Livres";
            // 
            // Menu_Affichage_GrandLivre
            // 
            this.Menu_Affichage_GrandLivre.Index = 0;
            this.Menu_Affichage_GrandLivre.Text = "Grand Livre";
            this.Menu_Affichage_GrandLivre.Click += new System.EventHandler(this.Menu_Affichage_GrandLivre_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "-";
            // 
            // Menu_Affichage_Balance
            // 
            this.Menu_Affichage_Balance.Index = 2;
            this.Menu_Affichage_Balance.Text = "Balance";
            this.Menu_Affichage_Balance.Click += new System.EventHandler(this.Menu_Affichage_Balance_Click);
            // 
            // Menu_Donnees
            // 
            this.Menu_Donnees.Index = 5;
            this.Menu_Donnees.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menu_dossier,
            this.menuItem6,
            this.Menu_Affichage_Importations});
            this.Menu_Donnees.Text = "Données";
            // 
            // Menu_Affichage_Importations
            // 
            this.Menu_Affichage_Importations.Index = 2;
            this.Menu_Affichage_Importations.Text = "Importations";
            this.Menu_Affichage_Importations.Click += new System.EventHandler(this.Menu_Affichage_Importations_Click);
            // 
            // menu_apropos
            // 
            this.menu_apropos.Index = 6;
            this.menu_apropos.Text = "A propos !";
            this.menu_apropos.Click += new System.EventHandler(this.menu_apropos_Click);
            // 
            // SoftwareInfo
            // 
            this.SoftwareInfo.AutoSize = true;
            this.SoftwareInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareInfo.ForeColor = System.Drawing.Color.LightCyan;
            this.SoftwareInfo.Location = new System.Drawing.Point(245, 146);
            this.SoftwareInfo.Name = "SoftwareInfo";
            this.SoftwareInfo.Size = new System.Drawing.Size(0, 24);
            this.SoftwareInfo.TabIndex = 0;
            // 
            // AuthorInfo
            // 
            this.AuthorInfo.AutoSize = true;
            this.AuthorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorInfo.ForeColor = System.Drawing.Color.LightCyan;
            this.AuthorInfo.Location = new System.Drawing.Point(245, 206);
            this.AuthorInfo.Name = "AuthorInfo";
            this.AuthorInfo.Size = new System.Drawing.Size(0, 24);
            this.AuthorInfo.TabIndex = 1;
            // 
            // ContactInfo
            // 
            this.ContactInfo.AutoSize = true;
            this.ContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactInfo.ForeColor = System.Drawing.Color.LightCyan;
            this.ContactInfo.Location = new System.Drawing.Point(245, 270);
            this.ContactInfo.Name = "ContactInfo";
            this.ContactInfo.Size = new System.Drawing.Size(0, 24);
            this.ContactInfo.TabIndex = 2;
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "-";
            // 
            // menu_dossier
            // 
            this.menu_dossier.Index = 0;
            this.menu_dossier.Text = "Dossier";
            this.menu_dossier.Click += new System.EventHandler(this.menu_dossier_Click);
            // 
            // SharpComptaUI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(736, 383);
            this.Controls.Add(this.ContactInfo);
            this.Controls.Add(this.AuthorInfo);
            this.Controls.Add(this.SoftwareInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu = this.mainMenu1;
            this.Name = "SharpComptaUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Compta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.SuperCompta_Closing);
            this.Load += new System.EventHandler(this.SuperCompta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
				

		private void SuperCompta_Load(object sender, System.EventArgs e)
		{
            try
            { 
                string ConnString = "";
                IAdapters Adapters = null;

                string DataBase = System.Configuration.ConfigurationManager.AppSettings.Get("DataBase");

                if (DataBase == "SqlServer")
                {
                    ConnString = System.Configuration.ConfigurationManager.AppSettings.Get("SqlServer_ConnectionString");
                    SqlServerConnection = new SqlConnection(ConnString);
                    SqlServerConnection.Open();
                    Adapters = new SqlServerAdapters(SqlServerConnection);
                    Adapters.Build_Adapters();
                    db = new CAD(Adapters);
                }

                else if (DataBase == "Access")
                {
                    ConnString = System.Configuration.ConfigurationManager.AppSettings.Get("Access_ConnectionString");
                    AcessConnection = new OleDbConnection(ConnString);
                    AcessConnection.Open();
                    Adapters = new AcessAdapters(AcessConnection);
                    Adapters.Build_Adapters();
                    db = new CAD(Adapters);
                }

                else return;

                DossierLogic Dossier_Logic = new DossierLogic(db);
                DossierModel model = new DossierModel();
                model.IDDossier = "1";
                Dossier_Logic.Consulter(ref model);
                RaisonSocial = model.RaisonSocial;
                an = model.Annee;
                                          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
			
		}
        
		
		private void SuperCompta_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
                if (SqlServerConnection != null)
                    if (SqlServerConnection.State != ConnectionState.Closed) SqlServerConnection.Close();
                if (AcessConnection != null)
                    if (AcessConnection.State != ConnectionState.Closed) AcessConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Exit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

        private void Menu_Saisie_PlanComptable_Click(object sender, EventArgs e)
        {
            try
            {
                SaisieCompta.SaisiePlanUI view = new SaisieCompta.SaisiePlanUI(db);
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        private void Menu_Affichage_PlanComptable_Click(object sender, EventArgs e)
        {
            try
            {
                EditionCompta.ListingPlanComptableUI view = new EditionCompta.ListingPlanComptableUI(db);
                view.RaisonSocial = RaisonSocial;
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Menu_Saisie_LibellésAutomatiques_Click(object sender, EventArgs e)
        {
            try
            {
                SaisieCompta.SaisieLibellesAutomatiqueUI view = new SaisieCompta.SaisieLibellesAutomatiqueUI(db);
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   
        private void Menu_Affichage_LibellesAutomatiques_Click(object sender, EventArgs e)
        {
            try
            {
                EditionCompta.ListingLibellesAutUI view = new EditionCompta.ListingLibellesAutUI(db);
                view.RaisonSocial = RaisonSocial;
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Menu_Saisie_JournauxAuxilliaires_Click(object sender, EventArgs e)
        {
            try
            {
                SaisieCompta.SaisieJournauxUI view = new SaisieCompta.SaisieJournauxUI(db);
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }  
        
        private void Menu_Affichage_JournauxAuxilliaires_Click(object sender, EventArgs e)
        {
            try
            {
                EditionCompta.ListingJournauxUI view = new EditionCompta.ListingJournauxUI(db);
                view.RaisonSocial = RaisonSocial;
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Menu_Saisie_Operations_Click(object sender, EventArgs e)
        {
            try
            {
                SaisieCompta.SaisieEcrituresUI view = new SaisieCompta.SaisieEcrituresUI(db, an);
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

 

        private void Menu_Affichage_Journaux_Click(object sender, EventArgs e)
        {
            try
            {
                LivresCompta.AffichageJourauxUI view = new LivresCompta.AffichageJourauxUI(db, an);
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Menu_Affichage_GrandLivre_Click(object sender, EventArgs e)
        {
            try
            {
                LivresCompta.AffichageGrandLivreUI view = new LivresCompta.AffichageGrandLivreUI(db, an);
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Menu_Affichage_Balance_Click(object sender, EventArgs e)
        {
            try
            {
                LivresCompta.AffichageBalanceUI view = new LivresCompta.AffichageBalanceUI(db, an);
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        
        private void menu_dossier_Click(object sender, EventArgs e)
        {
            try
            {
                CoucheAcceeDonnees.DossierUI view = new CoucheAcceeDonnees.DossierUI(db);
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Menu_Affichage_Importations_Click(object sender, EventArgs e)
        {
            try
            {
                CoucheAcceeDonnees.ImportationDonneesUI view = new CoucheAcceeDonnees.ImportationDonneesUI(db);
                view.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void menu_apropos_Click(object sender, EventArgs e)
        {
            SoftwareInfo.Text = "Software : SharpCompta version 1.0";
            AuthorInfo.Text = "Author : Samir Bouftass";
            ContactInfo.Text = "Contact : crypticator@gmail.com";
        }

       

    

     

		

	


		
	

	}
}
