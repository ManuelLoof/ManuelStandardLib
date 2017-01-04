using UnityEngine;
using System.Collections;


/// <summary>
/// Static debug class to log informations on the screen.
/// </summary>
public static class DebugConsole
{
    #region class variables

    static DebugWindow _window;
    static bool _firstTime = true;

    #endregion

    #region public static methods

    /// <summary>
    /// Printing messages on the screen.
    /// </summary>
    /// <param name="key">The name of the value.</param>
    /// <param name="value">The value;</param>
    public static void Print(string key, string value)
    {
        if (_firstTime)
            Init();

        if (_window)
            _window.Print(key, value); 


    }

    /// <summary>
    /// Printing messages on the screen.
    /// </summary>
    /// <param name="key">The name of the value.</param>
    /// <param name="value">The value;</param>
    public static void Print(object key, object value)
    {
        if (_firstTime)
            Init();

        if (_window)
            _window.Print(key.ToString(), value.ToString());


    }

    #endregion


    #region private static methods

    static void Init()
    {
        if(Application.isEditor)
            _window = GameObject.FindObjectOfType<DebugWindow>();

        _firstTime = false;
    }

    #endregion

}
