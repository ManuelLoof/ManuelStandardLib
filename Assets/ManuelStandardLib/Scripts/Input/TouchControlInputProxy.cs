using UnityEngine;
using System.Collections;
using TouchControl;
using Assets.ManuelStandardLib.Scripts.Input;

/// <summary>
/// Der InputProxy fuer mein TouchControl Steuerelement.
/// </summary>
public class TouchControlInputProxy : IUserInputProxy {

    const string CDeviceNameJoyStick = "Stick";


    // Use this for initialization
    public TouchControlInputProxy(Canvas canvas, TouchInputControls touchInputControls)
    {
        TouchInput.ControlCanvas = canvas;
        TouchInput.Controls = touchInputControls;
        TouchInput.SetVisible();

    }

    public void SetVisible()
    {
        TouchInput.SetVisible();
    }

    public void SetInvisible()
    {
        TouchInput.SetInvisible();
    }

    public float GetAxis(string axisName)
    {
        if (axisName == "Horizontal")
            return TouchInput.JoystickValue(CDeviceNameJoyStick).x;

        if (axisName == "Vertical")
            return TouchInput.JoystickValue(CDeviceNameJoyStick).y;

        return 0.0f;
    }

    public bool GetButtonDown(string buttonName)
    {
        return TouchInput.GetButtonDown(buttonName);
    }

    public bool GetButton(string buttonName)
    {
        return TouchInput.GetButtonDown(buttonName);
    }

    public bool AnyKey()
    {

        return false;
    }
}
