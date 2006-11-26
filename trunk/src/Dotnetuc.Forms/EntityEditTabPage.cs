using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Dotnetuc.Forms
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EntityEditTabPage
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EntityEditTabPage_MouseClick);
            this.ResumeLayout(false);

        }

        private void EntityEditTabPage_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("TabPage Click bei: " + (new System.Drawing.Point(e.X, e.Y)).ToString());
            
            switch (e.Button)
            {
                case MouseButtons.Left:
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
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
