using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.ManuelStandardLib.Scripts.Pysics
{
    public static class RayCastsHelper
    {
        /// <summary>
        /// Guckt ob ich freies Schussfeld zwischen zwischen Gegner und Player habe.
        /// </summary>
        /// <returns>True, falls freies Schussfeld.</returns>
        public static bool FreeShootingField(Vector3 startpos, Vector3 target)
        {

            // Bit shift the index of the layer (10) to get a bit mask
            var layerMask = 1 << 8; // Layer 10 = Player Layer

            // This would cast rays only against colliders in layer 8.
            // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
            // layerMask = ~layerMask;

            Debug.DrawLine(startpos, target, Color.black);
            return !Physics.Linecast(startpos, target, layerMask);

        }

        /// <summary>
        /// Guckt ob ich freies Schussfeld zwischen Gegner und Player habe und überprüft dabei ob die Distance passt.
        /// </summary>
        /// <returns>True, falls freies Schussfeld.</returns>
        public static bool FreeShootingField(Vector3 startpos, Vector3 target, float distance)
        {

            // Testen ob der Player sich in der Nähe befindet.
            if(Vector3.Distance(startpos,target)<distance)
            {
                return FreeShootingField(startpos, target);
            }

            return false; 

        }
    }
}
