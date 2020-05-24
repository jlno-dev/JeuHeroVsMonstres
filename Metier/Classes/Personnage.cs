using System;
//using System.Collections.Generic;
//using System.Text;
using Metier.Communs;
using Metier.Interfaces;

namespace Metier.Classes
{
    public class Personnage : Element
    {

        // --------------------------------------------------------------------
        public Personnage(string pNom, TypeNiveau pNiveau, int pRang) 
            : base(TypeElement.Personnage, pNom, pNiveau, pRang)
        {

        }
        public int Attaquer(IArmable pArmes)
        {
            return LancerAttaque(pArmes);
        }
            
        public int Esquiver(IArmable pArmes)
        {
            return LancerEsquive(pArmes);
        }

        // --------------------------------------------------------------------
        protected virtual int LancerAttaque(IArmable pArmes)
        {
            return pArmes.Attaquer();
        }
        protected virtual int LancerEsquive(IArmable pArmes)
        {
            return pArmes.Esquiver();
        }

        // --------------------------------------------------------------------
    }
}
