using System;
using System.Collections.Generic;
using System.Text;

namespace Siesaso.Forms
{
    public class EntityEditTabPage : System.Windows.Forms.TabPage
    {
        public EntityEditTabPage()
            : base()
        {
        }

        public EntityEditTabPage(string text)
            : base(text)
        {
        }

        public EntityEditTabPage(Object initEntity)
            : base(initEntity.ToString())
        {
            entity = initEntity;
        }

        private Object entity = null;

        public Object Entity
        {
            get { return entity; }
            set { entity = value; }
        }
    }
}
