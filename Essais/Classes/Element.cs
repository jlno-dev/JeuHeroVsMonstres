using System;
using System.Collections.Generic;
using System.Text;
using Essais.TypesDefinis;

namespace Essais
{
    
    public class Element
    {
        // ++++ Proprietes
        public TypeElement Type { protected set; get; }
        public string Nom { protected set; get; }

        // +++++ Constructeurs
        public Element (TypeElement pType, string pNom)
        {
            Type = pType;
            Nom = pNom;
        }

        // +++++ Methodes publiques

        // +++++ Methodes privées

        // +++++ Methodes interfaces
    }
}
