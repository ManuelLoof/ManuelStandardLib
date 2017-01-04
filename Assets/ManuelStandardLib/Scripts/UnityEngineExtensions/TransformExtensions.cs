using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.ManuelStandardLib.Scripts.UnityEngineExtensions
{
    /// <summary>
    /// Klasse erweitert die Standard Unity Engine.
    /// </summary>
    public static class TransformExtensions
    {

        #region Method Extensions

        /// <summary>
        /// Durchsucht rekursive nach dem Child.
        /// </summary>
        /// <param name="trans">Mein Methodextension Objekt.</param>
        /// <param name="name">Der Name des Kindes.</param>
        /// <returns>Das gesuchte Child. Null falls nicht gefunden.</returns>
        public static Transform FindRecurse(this Transform trans, string name)
        {
            return FindRecurseChild(trans, name); 

        }

        #endregion


        #region Private Methoden

        /// <summary>
        /// Durchsucht rekursive nach dem Child.
        /// </summary>
        /// <param name="trans">Mein Methodextension Objekt.</param>
        /// <param name="name">Der Name des Kindes.</param>
        /// <returns>Das gesuchte Child. Null falls nicht gefunden.</returns>
        private static Transform FindRecurseChild(Transform trans, string name)
        {
            foreach (Transform child in trans)
            {
                if (child.name == name)
                    return child;

                Transform erg = FindRecurseChild(child, name);
                if (erg != null)
                    return erg; 
            }

            return null;
        }


        #endregion

    }
}
