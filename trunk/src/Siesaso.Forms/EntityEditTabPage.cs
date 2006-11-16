using System;
using System.Collections.Generic;
using System.Text;

namespace Softwarekueche.Siesaso.Forms
{
    /// <summary>
    /// TabPage mit einer Entity-Edit-Control Eigenschaft
    /// </summary>
    public class EntityEditTabPage : System.Windows.Forms.TabPage
    {
        public EntityEditTabPage(IEntityEditControl initEntity)
            : base(initEntity.Entity.ToString())
        {
            editControl = initEntity;
        }

        public EntityEditTabPage(IEntityEditControl initEntity, String text)
            : base(text)
        {
            editControl = initEntity;
        }

        private IEntityEditControl editControl = null;

        public IEntityEditControl EditControl
        {
            get { return editControl; }
        }
    }
}
