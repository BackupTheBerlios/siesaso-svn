using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnetuc.NHibernate
{
    /// <summary>
    /// Schnittstelle für alle Entitäten, die in der Lage sind, bearbeitet
    /// zu werden.
    /// </summary>
    public interface IEditable
    {
        /// <summary>
        /// Gibt das Steuerelement zurück, das die Entität bearbeitet.
        /// </summary>
        IEditControl EditControl();
    }
}
