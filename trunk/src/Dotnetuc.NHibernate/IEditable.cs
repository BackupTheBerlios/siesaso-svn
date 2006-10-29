using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnetuc.NHibernate
{
    /// <summary>
    /// Schnittstelle f�r alle Entit�ten, die in der Lage sind, bearbeitet
    /// zu werden.
    /// </summary>
    public interface IEditable
    {
        /// <summary>
        /// Gibt das Steuerelement zur�ck, das die Entit�t bearbeitet.
        /// </summary>
        IEditControl EditControl();
    }
}
