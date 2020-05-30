using Essais.Interfaces;
using Essais.TypesDefinis;
using System.Collections.Generic;
using System.Text;

namespace Essais.Classes
{
    public class Equipement : Element
    {
        protected List<IArmable> Armes;
        
        public Equipement()
            :base(TypeElement.Equipement, "Set Armure")
        {
            Armes = new List<IArmable>();
        }
        public void AjouterArme(IArmable pArme)
        {
            Armes.Add(pArme);
        }
    }
}
