// using System;
using Metier.Communs;

namespace Metier.Classes
{
    public class Element
    {
        #region proprietes
        public TypeElement Type { protected set; get; }
        public string Nom { set; get; }
        public TypeNiveau Niveau { set; get; }
        public int Rang { set; get; }
        #endregion

        // --------------------------------------------------------------------
        public Element(TypeElement pType, string pNom, TypeNiveau pNiveau, int pRang)
        {
            Type = pType;
            Nom = pNom;
            Niveau = pNiveau;
            Rang = pRang;
        }

        public Element(string pNom, TypeNiveau pNiveau, int pRang)
        {
            Type = TypeElement.Element;
            Nom = pNom;
            Niveau = pNiveau;
            Rang = pRang;
        }

        #region procedures_fonctions_publique
        // --------------------------------------------------------------------
        public void AugmenterRang(int pRang)
        {
            GererRang(pRang);
        }
        #endregion

        #region protected, private 
        // --------------------------------------------------------------------
        protected virtual void GererRang(int pRang)
        {
            Rang += pRang;
        }
        #endregion
    }
}
