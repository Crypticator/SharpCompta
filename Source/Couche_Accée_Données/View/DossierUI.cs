using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilitaire;

namespace CoucheAcceeDonnees
{
    public partial class DossierUI : Form
    {
        CAD db;

        public DossierLogic Logic;
        DossierModel model;
        bool model_ok;

        public DossierUI()
        {
            InitializeComponent();
        }

        public DossierUI(CAD db1)
        {
            InitializeComponent();

            db = db1;
            Logic = new DossierLogic(db);

        }
        
        private void DossierUI_Load(object sender, EventArgs e)
        {
            model = new DossierModel();
            model.IDDossier = "1";
            Logic.Consulter(ref model);
            RaisonSocialTxt.Text = model.RaisonSocial;
            AnneeTxt.Text = model.Annee;
            model_ok = true;

            RaisonSocialTxt.Focus();
            RaisonSocialTxt.SelectAll();

        }

        private void RaisonSocialTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Down) || (e.KeyData == Keys.Enter))
            {
                AnneeTxt.Focus();
                AnneeTxt.SelectAll();

            }


        }

        private void AnneeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Down) || (e.KeyData == Keys.Enter)) ModifierButton.Focus();
            if (e.KeyData == Keys.Up) RaisonSocialTxt.Focus();

        }

        private void RaisonSocialTxt_Validating(object sender, CancelEventArgs e)
        {
            model.RaisonSocial = RaisonSocialTxt.Text;

        }

        private void AnneeTxt_Validating(object sender, CancelEventArgs e)
        {
            model.Annee = AnneeTxt.Text;
            bool b = Validator.valide_N(AnneeTxt.Text);
            if (b == false)
            {
                AnneeTxt.ForeColor = Color.Red;
                ep.SetError(AnneeTxt, "Format numerique invalide");
                warn.Text = ""; 
                model_ok = false;
            }
            else
            {
                AnneeTxt.ForeColor = Color.Black;
                ep.SetError(AnneeTxt, "");
                warn.Text = ""; 
                model_ok = true;
            }

        }

        private void ModifierButton_Click(object sender, EventArgs e)
        {
            if (model_ok == true)
            {
                Logic.Modifier(model);
                warn.Text = "Données Dossier modifié avec succee"; 
            }
            else warn.Text = "Données saisies invalides"; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
