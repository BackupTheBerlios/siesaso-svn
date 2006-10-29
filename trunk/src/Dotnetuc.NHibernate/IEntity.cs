using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnetuc.NHibernate
{
    public interface IEntity
    {
        bool IsUnsaved{ get; }

        void Save();

        void Delete();
    }
}
