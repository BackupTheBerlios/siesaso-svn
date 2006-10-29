using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnetuc.NHibernate
{
    public interface IEntity
    {
        void Save();

        void Delete();
    }
}
