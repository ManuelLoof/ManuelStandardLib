using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.ManuelStandardLib.Scripts.Input
{
    /// <summary>
    /// Standard Unity Eingabe wird durchgeschliffen.
    /// </summary>
    public class StandardInputProxy : IUserInputProxy
    {

        public float GetAxis(string axisName)
        {
            return UnityEngine.Input.GetAxis(axisName);
        }

        public bool GetButtonDown(string buttonName)
        {
            return UnityEngine.Input.GetButtonDown(buttonName);
        }

        public bool GetButton(string buttonName)
        {
            return UnityEngine.Input.GetButton(buttonName);
        }

        public bool AnyKey()
        {
            return UnityEngine.Input.anyKey;
        }
    }
}
