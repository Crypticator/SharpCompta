using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace CoucheAcceeDonnees
{
    public class CAD
    {
        private DbDataAdapter Dossier_Adapter;
        private DbDataAdapter Comptes_Adapter;
        private DbDataAdapter Journaux_Adapter;
        private DbDataAdapter LibellesAutomatiques_Adapter;
        private DbDataAdapter Ecritures_Adapter;

        
        public DataSet Ds;

        public CAD(IAdapters adapters)
        {
            adapters.Get_Adapters(ref Dossier_Adapter, ref Comptes_Adapter, ref Journaux_Adapter, ref LibellesAutomatiques_Adapter, ref Ecritures_Adapter);   
            Ds = new DataSet();
        }

        public void Fill_Dossier()
        {
            Dossier_Adapter.Fill(Ds, "Dossier");
        }

        public void Update_Dossier()
        {
            Dossier_Adapter.Update(Ds, "Dossier");
        }
        
        private void Refresh_Comptes()
        {
            Ds.Tables["Comptes"].Clear();
            Comptes_Adapter.Fill(Ds, "Comptes");
        }

        private void Refresh_LibellesAutomatiques()
        {
            Ds.Tables["LibellesAutomatiques"].Clear();
            LibellesAutomatiques_Adapter.Fill(Ds, "LibellesAutomatiques");
        }

        private void Refresh_Journaux()
        {
            Ds.Tables["Journaux"].Clear();
            Journaux_Adapter.Fill(Ds, "Journaux");
        }

        private void Refresh_Ecritures()
        {
            Ds.Tables["Ecritures"].Clear();
            Ecritures_Adapter.Fill(Ds, "Ecritures");
        }

        public void Fill_Comptes()
        {
            if (Ds.Tables["Comptes"] == null)
                Comptes_Adapter.Fill(Ds, "Comptes");
            else Refresh_Comptes();
            
        }
        
        public void Fill_LibellesAutomatiques()
        {
            if (Ds.Tables["LibellesAutomatiques"] == null)
                LibellesAutomatiques_Adapter.Fill(Ds, "LibellesAutomatiques");
            else Refresh_LibellesAutomatiques();
        }

        public void Fill_Journaux()
        {
            if (Ds.Tables["Journaux"] == null)
                Journaux_Adapter.Fill(Ds, "Journaux");
            else Refresh_Journaux();
        }

        public void Fill_Ecritures()
        {
            if (Ds.Tables["Ecritures"] == null)
                Ecritures_Adapter.Fill(Ds, "Ecritures");
            else Refresh_Ecritures();

        }

        public void Update_Comptes()
        {
            Comptes_Adapter.Update(Ds, "Comptes");
        }

        public void Update_LibellesAutomatiques()
        {
            LibellesAutomatiques_Adapter.Update(Ds, "LibellesAutomatiques");
        }

        public void Update_Journaux()
        {
            Journaux_Adapter.Update(Ds, "Journaux");
        }

        public void Update_Ecritures()
        {
            Ecritures_Adapter.Update(Ds, "Ecritures");
        }

        public DbTransaction load_tran()
        {
            DbTransaction tran = Ecritures_Adapter.InsertCommand.Connection.BeginTransaction();
            Ecritures_Adapter.DeleteCommand.Transaction = tran;
            Ecritures_Adapter.InsertCommand.Transaction = tran;
            Ecritures_Adapter.UpdateCommand.Transaction = tran;
            return tran;
        }

       



       
     





    }
}
