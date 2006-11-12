using System;
using System.Collections.Generic;
using System.Text;

namespace Siesaso.Forms
{
    /// <summary>
    /// Schnittstelle f�r alle UserControls, die in der Lage sind, eine Entit�t 
    /// darzustellen und zu bearbeiten.
    /// </summary>
    public interface IEntityEditControl
    {
        /// <summary>
        /// Entit�t, die durch das Steuerelement dargestellt wird.
        /// </summary>
        Object Entity { get; }

        /// <summary>
        /// Gibt zur�ck, ob das Steuerelement die Entit�t bearbeiten 
        /// bzw. anzeigenkann
        /// </summary>
        /// <param name="entity">Entit�t zum Testen</param>
        bool CanPresent(Object entity);

        /// <summary>
        /// Stellt in dem Control die Entit�t dar.
        /// </summary>
        /// <param name="entity">Entit�t zum Darstellen</param>
        void Present(Object entity);
    }
}
