using System;
using System.Collections.Generic;
using System.Text;
using Metier.Communs;
using Metier.Interfaces;

namespace Metier.Classes
{
    public class Hero : Personnage
    {

        // --------------------------------------------------------------------
        public Hero(string pNom, TypeNiveau pNiveau, int pRang) : base(pNom, pNiveau, pRang)
        {

        }
        protected override int LancerAttaque(IArmable pArmes)
        {
            return pArmes.Attaquer();
        }
        protected override int LancerEsquive(IArmable pArmes)
        {
            return pArmes.Esquiver();
        }
    }
}
