using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.ManuelStandardLib.Scripts.Input
{
    /// <summary>
    /// Schnittstelle für dynamische Benutzereingaben.
    /// </summary>
    public interface IUserInputProxy
    {
        float GetAxis(string axisName);
        bool GetButtonDown(string buttonName);
        bool GetButton(string buttonName);
        bool AnyKey(); 
    }
}
