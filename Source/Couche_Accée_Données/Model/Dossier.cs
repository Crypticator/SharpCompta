using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CoucheAcceeDonnees
{
    public class Dossier
    {
        private CAD db;

        public Dossier(CAD db1)
        {
            db = db1;
        }

        public int Enregistrer(DossierModel model)
        {

            DataTable dt = db.Ds.Tables["Dossier"];
            DataRow[] drs = dt.Select("IDDossier =" + model.IDDossier);
            if (drs.Length != 0) return 1;

            DataRow dr = dt.NewRow();
            dr["IDDossier"] = model.IDDossier;
            dr["RaisonSocial"] = model.RaisonSocial;
            dr["Annee"] = model.Annee;
           
            dt.Rows.Add(dr);
            db.Update_Dossier();
            db.Ds.AcceptChanges();

            return 0;

        }

        public int Consulter(ref DossierModel model)
        {

            DataTable dt = db.Ds.Tables["Dossier"];
            DataRow[] drs = dt.Select("IDDossier =" + model.IDDossier);
            if (drs.Length > 0)
            {
                model.IDDossier = drs[0]["IDDossier"].ToString();
                model.RaisonSocial = drs[0]["RaisonSocial"].ToString();
                model.Annee = drs[0]["Annee"].ToString();
              
                return 0;

            }
            else return 1;

        }

        public int Modifier(DossierModel model)
        {

            DataTable dt = db.Ds.Tables["Dossier"];
            DataRow[] drs = dt.Select("IDDossier =" + model.IDDossier);
            if (drs.Length > 0)
            {
                drs[0]["IDDossier"] = model.IDDossier;
                drs[0]["RaisonSocial"] = model.RaisonSocial;
                drs[0]["Annee"] = model.Annee;
              
                db.Update_Dossier();
                db.Ds.AcceptChanges();

                return 0;
            }
            else return 1;


        }

        public int Supprimer(DossierModel model)
        {

            DataTable dt = db.Ds.Tables["Dossier"];
            DataRow[] drs = dt.Select("IDDossier =" + model.IDDossier);
            if (drs.Length > 0)
            {

                drs[0].Delete();
                db.Update_Dossier();
                db.Ds.AcceptChanges();
                return 0;


            }
            else return 1;

        }

    }
}
