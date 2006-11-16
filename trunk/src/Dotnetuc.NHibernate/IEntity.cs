using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnetuc.NHibernate
{
    /// <summary>
    /// Schnittstelle für Entitäten, die über den Entity-Persister 
    /// verwaltet werden sollen.
    /// </summary>
    public interface IEntity
    {
        bool IsUnsaved{ get; }

        void Save();

        void Delete();
    }
}
