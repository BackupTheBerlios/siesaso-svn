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

        #region Methoden zum Verwalten der TabPages

        public void Edit(Object p, Type control, String header)
        {
            // Durchsuchen aller TabPages, ob das Objekt bereits dargestellt wird
            bool isShown = false;
            foreach (TabPage tp in this.TabPages)
            {
                if (!(tp is EntityEditTabPage)) continue;
                EntityEditTabPage etp = (EntityEditTabPage)tp;

                if (etp.EditControl.Entity == p)
                {
                    this.SelectedTab = etp;
                    isShown = true;
                    break;
                }
            }

            // Anlegen, falls das Objekt noch nicht angezeigt wird
            if (!isShown) this.CreateTabPage(p, control, header);
        }

        /// <summary>
        /// Methode zum Anzeigen eines Steuerelementes in einem neuen Register.
        /// </summary>
        /// <param name="p">Entit�t oder Liste, die angezeigt werden soll</param>
        /// <param name="control">Steuerelement, das angezeigt werden soll</param>
        /// <param name="header">�berschrift des Registers</param>
        private void CreateTabPage(Object p, Type control, String header)
        {
            Control ctl = (Control)Activator.CreateInstance(control);
          
            IEntityEditControl eeCtl = (IEntityEditControl)ctl;
            if (!eeCtl.CanPresent(p)) throw new InvalidOperationException("Objekt kann nicht dargestellt werden.");
            eeCtl.Present(p);

            EntityEditTabPage tp = new EntityEditTabPage(eeCtl, header);

            tp.Controls.Add(ctl);

            this.TabPages.Add(tp);
            this.SelectedTab = tp;
        }

        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EntityEditTabControl
            // 
            this.Multiline = true;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EntityEditTabControl_MouseClick);
            this.ResumeLayout(false);

        }

        public EntityEditTabControl()
        {
            this.InitializeComponent();
        }

        private void EntityEditTabControl_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    MessageBox.Show("ContextMen� einbinden");
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
        }
    }
}
