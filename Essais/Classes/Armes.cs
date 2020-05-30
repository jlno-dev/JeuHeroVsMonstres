using Essais.Interfaces;
using Essais.TypesDefinis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Essais.Classes
{
    public class Arme : Element, IArmable, IEquipable
    {
        public int Niveau { get ; set; }

        public Arme (string pNom) : base (TypeElement.Armes, pNom)
        {

        }
        public void AugmenterNiveau(int pAugmentation)
        {
            throw new NotImplementedException();
        }

        public int Attaquer()
        {
            throw new NotImplementedException();
        }

        public int Defendre()
        {
            throw new NotImplementedException();
        }
    }
}
