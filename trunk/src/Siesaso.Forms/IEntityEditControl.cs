using System;
using System.Collections.Generic;
using System.Text;

namespace Siesaso.Forms
{
    /// <summary>
    /// Schnittstelle für alle UserControls, die in der Lage sind, eine Entität 
    /// darzustellen und zu bearbeiten.
    /// </summary>
    public interface IEntityEditControl
    {
        /// <summary>
        /// Entität, die durch das Steuerelement dargestellt wird.
        /// </summary>
        Object Entity { get; }

        /// <summary>
        /// Gibt zurück, ob das Steuerelement die Entität bearbeiten 
        /// bzw. anzeigenkann
        /// </summary>
        /// <param name="entity">Entität zum Testen</param>
        bool CanPresent(Object entity);

        /// <summary>
        /// Stellt in dem Control die Entität dar.
        /// </summary>
        /// <param name="entity">Entität zum Darstellen</param>
        void Present(Object entity);
    }
}
