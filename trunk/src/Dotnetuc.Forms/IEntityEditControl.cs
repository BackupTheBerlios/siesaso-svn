using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnetuc.Forms
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

        /// <summary>
        /// Ermittelt, ob die �bergebene Entit�t in dem
        /// Steuerelement angezeigt wird.
        /// </summary>
        /// <param name="entity">Entit�t, die gepr�ft werden soll</param>
        /// <returns>True, wenn das Objekt in dem Steuerelement dargestellt wird.</returns>
        bool IsPresenting(Object entity);
    }
}
