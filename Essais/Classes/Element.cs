using Essais.TypesDefinis;

namespace Essais.Classes
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
        public override string ToString()
        {
            return "[Element]"; //base.ToString();
        }
        // +++++ Methodes privées

        // +++++ Methodes interfaces
    }
}
