using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Text;
using System.Collections.Generic;

/// <summary>
/// my custom debug Window.
/// </summary>
public class DebugWindow : MonoBehaviour
{


    #region class members

    StringBuilder _debugText;
    Dictionary<string, string> _debugEntries;

    #endregion

    #region properties

    public Text TextControl;

    #endregion


    #region unity

    /// <summary>
    /// Use this for initialization 
    /// </summary>
    void Start()
    {

        if (!Application.isEditor)
            gameObject.SetActive(false);

        _debugText = new StringBuilder();
        _debugEntries = new Dictionary<string, string>();

        if (!TextControl)
            throw new Exception("Text control required");

    }


    /// <summary>
    /// Fixed Update call
    /// </summary>
    void FixedUpdate()
    {
        foreach (var key in _debugEntries.Keys)
        {
            _debugText.AppendLine(string.Format("{0}: {1}", key, _debugEntries[key]));
        }


        if (TextControl)
        {
            TextControl.text = _debugText.ToString();
        }

        _debugText.Length = 0; // clear Stringbuilder

    }


    #endregion


    #region public mothods

    /// <summary>
    /// Printing a message in the debug window.
    /// </summary>
    /// <param name="key">The name of the value.</param>
    /// <param name="value">The value;</param>
    public void Print(string key, string value)
    {
        if (_debugEntries.ContainsKey(key))
        {
            _debugEntries[key] = value;
        }
        else
        {
            _debugEntries.Add(key, value);
        }
    }

    #endregion


}