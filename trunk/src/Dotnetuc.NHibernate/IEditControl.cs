using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnetuc.NHibernate
{
    /// <summary>
    /// Schnittstelle für alle UserControls, die in der Lage sind, eine Entität 
    /// darzustellen und zu bearbeiten.
    /// </summary>
    public interface IEditControl
    {
        /// <summary>
        /// Steuerelement, dass die Entität darstellt.
        /// </summary>
        System.Windows.Forms.Control Control { get; }

        /// <summary>
        /// Entität, die durch das Steuerelement dargestellt wird.
        /// </summary>
        IEntity Entity { get; set; }
    }
}
