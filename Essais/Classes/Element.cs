using Essais.TypesDefinis;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Essais.Classes
{
    
    public class Element: IEquatable<Element>, IDisposable
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

        #region IEquatable
        public virtual bool Equals(Element pElem)
        {
            return (this.Nom == pElem.Nom && this.Type == pElem.Type);
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Element()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
        // +++++ Methodes privées

        // +++++ Methodes interfaces
    }
}
