using System;
using System.Collections.Generic;
using System.Text;
using Metier.Communs;
using Metier.Interfaces;

namespace Metier.Classes
{
    public class ArmeDe : Element, IArmable
    {
        public ArmeDe(string pNom, TypeNiveau pNiveau, int pRang)
            : base(TypeElement.Armes, pNom, pNiveau, pRang)
        {
        }

        #region interface IArmable
        public int Attaquer()
        {
            return LancerAttaque();
        }

        public int Esquiver()
        {
            return LancerEsquive();
        }
        #endregion
        // --------------------------------------------------------------------
        protected virtual int LancerAttaque()
        {
            return De.LancerDe(Rang);
        }
        protected virtual int LancerEsquive()
        {
            return De.LancerDe(Rang);
        }
    }
}
