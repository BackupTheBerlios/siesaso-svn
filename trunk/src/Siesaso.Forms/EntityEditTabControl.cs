using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Siesaso.Forms;

namespace Siesaso.Forms
{
    [System.Drawing.ToolboxBitmap(typeof(TabControl))]
    public class EntityEditTabControl : TabControl
    {
        public void Edit(Object p, Type control)
        {
            bool isShown = false;
            foreach (TabPage tp in this.TabPages)
            {
                if (!(tp is EntityEditTabPage)) continue;
                EntityEditTabPage etp = (EntityEditTabPage)tp;

                if (etp.Entity == p)
                {
                    this.SelectedTab = etp;
                    isShown = true;
                    break;
                }
            }

            if (!isShown) this.CreateTabPage(p, control);
        }

        private void CreateTabPage(Object p, Type control)
        {
            EntityEditTabPage tp = new EntityEditTabPage(p);

            Control ctl = (Control)Activator.CreateInstance(control);

            tp.Controls.Add(ctl);

            this.TabPages.Add(tp);
            this.SelectedTab = tp;
        }
    }
}
