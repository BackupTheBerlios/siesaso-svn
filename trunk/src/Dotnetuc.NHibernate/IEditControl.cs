using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnetuc.NHibernate
{
    /// <summary>
    /// Schnittstelle f�r alle UserControls, die in der Lage sind, eine Entit�t 
    /// darzustellen und zu bearbeiten.
    /// </summary>
    public interface IEditControl
    {
        /// <summary>
        /// Steuerelement, dass die Entit�t darstellt.
        /// </summary>
        System.Windows.Forms.Control Control { get; }

        /// <summary>
        /// Entit�t, die durch das Steuerelement dargestellt wird.
        /// </summary>
        IEntity Entity { get; set; }
    }
}
