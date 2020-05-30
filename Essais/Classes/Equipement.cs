using Essais.Interfaces;
using Essais.TypesDefinis;


namespace Essais.Classes
{
    public class Equipement : Element, IEquipable
    {       
        public Equipement(string pNom)
            :base(TypeElement.Equipement, pNom)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "[Equipement]";
        }
        public int Niveau { get ; set ; }

        public virtual void AugmenterNiveau(int pAugmentation)
        {
            Niveau += pAugmentation;
        }
    }
}
