using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;
using System;


/// <summary>
/// Versteckt die Scrollbar wenn sie nicht benötigt wird.
/// </summary>
[RequireComponent(typeof(Scrollbar))]
public class ScrollbarHide : MonoBehaviour {

    Scrollbar _myScrollbar;
    bool _hide = false;

    void Start()
    {
        _myScrollbar = gameObject.GetComponent<Scrollbar>();
    }

    void FixedUpdate () 
    {
        if(_myScrollbar)
        {
            if (_myScrollbar.size > 0.9f && !_hide)
            {
                foreach (var c in _myScrollbar.gameObject.GetComponentsInChildren<CanvasRenderer>())
                {
                    c.SetAlpha(0);
                }
                _hide = true;
            }
            else if (_myScrollbar.size < 0.9f && _hide)
            {
                foreach (var c in _myScrollbar.gameObject.GetComponentsInChildren<CanvasRenderer>())
                {
                    c.SetAlpha(1);
                }
                _hide = false;
            } 
        }
    }
}
