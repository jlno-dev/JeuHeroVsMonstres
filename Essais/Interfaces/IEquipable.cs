using System;
using System.Collections.Generic;
using System.Text;

namespace Essais.Interfaces
{
    public interface IEquipable
    {
        int Niveau { set; get; }
        void AugmenterNiveau(int pAugmentation);
    }
}
