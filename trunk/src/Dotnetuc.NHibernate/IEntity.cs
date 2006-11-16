using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnetuc.NHibernate
{
    /// <summary>
    /// Schnittstelle f�r Entit�ten, die �ber den Entity-Persister 
    /// verwaltet werden sollen.
    /// </summary>
    public interface IEntity
    {
        bool IsUnsaved{ get; }

        void Save();

        void Delete();
    }
}
