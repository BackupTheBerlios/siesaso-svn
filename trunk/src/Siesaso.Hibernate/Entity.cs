using System;
using System.Collections.Generic;
using System.Text;

namespace Siesaso.Hibernate
{
    public class Entity
    {
        /// <summary>
        /// Löscht das Objekt aus Hibernate / der Datenbank
        /// </summary>
        public virtual void Delete()
        {
            Session.Instance.Get.Delete(this);
            Session.Instance.Get.Flush();
        }

        /// <summary>
        /// Speichert das Objekt in Hibernate / der Datenbank
        /// </summary>
        public virtual void Save()
        {
            Session.Instance.Get.SaveOrUpdate(this);
            Session.Instance.Get.Flush();
        }
    }
}
