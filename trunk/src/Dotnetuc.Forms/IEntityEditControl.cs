using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnetuc.Forms
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

        /// <summary>
        /// Ermittelt, ob die übergebene Entität in dem
        /// Steuerelement angezeigt wird.
        /// </summary>
        /// <param name="entity">Entität, die geprüft werden soll</param>
        /// <returns>True, wenn das Objekt in dem Steuerelement dargestellt wird.</returns>
        bool IsPresenting(Object entity);
    }
}
