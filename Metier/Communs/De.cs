using System;
using System.Runtime.InteropServices;

namespace Metier.Classes
{
    public static class De
    {
        public static int LancerDe(int pNbFaces)
        {
            return new Random().Next(1, pNbFaces+1);
        } 
    }
}
