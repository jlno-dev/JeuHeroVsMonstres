using Essais.Classes;
using Essais.TypesDefinis;
using System;

namespace Essais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Element element = new Element(TypeElement.Element,"Element de base");
            Console.WriteLine(element.Nom);
            Console.WriteLine(element.ToString());
            
            Element element1 = new Equipement("Set d'armure");
            Console.WriteLine(element1.Nom);
            Console.WriteLine(element1.ToString());
            Console.ReadLine();
                        
        }
    }
}
