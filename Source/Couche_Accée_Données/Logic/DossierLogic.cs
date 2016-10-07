using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Utilitaire;
using CoucheAcceeDonnees;

namespace CoucheAcceeDonnees
{
    public class DossierLogic
    {
        Dossier Doss;

        public DossierLogic(CAD db)
        {
            db.Fill_Dossier();
            Doss = new Dossier(db);
        }

        public int Modifier(DossierModel model)
        {
            return Doss.Modifier(model);

        }

        public int Consulter(ref DossierModel model)
        {
            return Doss.Consulter(ref model);

        }


         


    }
}
