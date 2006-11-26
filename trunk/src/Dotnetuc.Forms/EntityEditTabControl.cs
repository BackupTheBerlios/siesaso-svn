using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Dotnetuc.Forms
{
    /// <summary>
    /// TabControl mit einer Methode zum Bearbeiten von Entitäten.
    /// </summary>
    [System.Drawing.ToolboxBitmap(typeof(TabControl))]
    public class EntityEditTabControl : TabControl
    {
        private ImageList images;
        private System.ComponentModel.IContainer components;

        #region Methoden zum Verwalten der TabPages

        /// <summary>
        /// Bearbeitet das Objekt p mit dem Steuerelement control und 
        /// zeigt das neue Tab mit der Überschrift header an.
        /// </summary>
        /// <param name="p">Entität zum Bearbeiten</param>
        /// <param name="control">Steuerelement zum Bearbeiten/Anzeigen</param>
        /// <param name="header">Überschrift des Registers</param>
        public void Edit(Object p, Type control, String header)
        {
            // Durchsuchen aller TabPages, ob das Objekt bereits dargestellt wird
            bool isShown = false;
            foreach (TabPage tp in this.TabPages)
            {
                if (!(tp is EntityEditTabPage)) continue;
                EntityEditTabPage etp = (EntityEditTabPage)tp;

                if (etp.EditControl.IsPresenting(p))
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
        /// <param name="p">Entität oder Liste, die angezeigt werden soll</param>
        /// <param name="control">Steuerelement, das angezeigt werden soll</param>
        /// <param name="header">Überschrift des Registers</param>
        private void CreateTabPage(Object p, Type control, String header)
        {
            Control ctl = (Control)Activator.CreateInstance(control);
            ctl.Dock = DockStyle.Fill;
          
            IEntityEditControl eeCtl = (IEntityEditControl)ctl;
            if (!eeCtl.CanPresent(p)) throw new InvalidOperationException("Objekt kann nicht dargestellt werden.");
            eeCtl.Present(p);

            EntityEditTabPage tp = new EntityEditTabPage(eeCtl, header);

            tp.Controls.Add(ctl);
            tp.ImageIndex = 0;

            this.TabPages.Add(tp);
            this.SelectedTab = tp;
        }

        #endregion

        #region Designer Code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityEditTabControl));
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "X.png");
            // 
            // EntityEditTabControl
            // 
            this.ImageList = this.images;
            this.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.EntityEditTabControl_Selecting);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EntityEditTabControl_MouseMove);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EntityEditTabControl_MouseClick);
            this.ResumeLayout(false);

        }

        public EntityEditTabControl()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Control-Events

        MouseEventArgs moveEventArgs = null;

        private void EntityEditTabControl_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("TabControl Click bei: " + (new System.Drawing.Point(e.X, e.Y)).ToString());

            switch (e.Button)
            {
                case MouseButtons.Left:
                    for (int i = 0; i < this.TabPages.Count; i++)
                    {
                        Rectangle tabRect = this.GetTabRect(i);
                        if (e.X > tabRect.X + 2 && e.X < tabRect.X + 17 && e.Y > tabRect.Y && e.Y < tabRect.Y + 17)
                        {
                            this.TabPages.Remove(this.TabPages[i]);
                        }
                    }
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    MessageBox.Show("ContextMenü einbinden");
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
        }

        private void EntityEditTabControl_MouseMove(object sender, MouseEventArgs e)
        {
            moveEventArgs = e;
        }

        private void EntityEditTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Selection Action: " + e.Action.ToString());

            switch (e.Action)
            {
                case TabControlAction.Deselected:
                    break;
                case TabControlAction.Deselecting:
                    break;
                case TabControlAction.Selected:
                    break;
                case TabControlAction.Selecting:
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
