using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class OnUnityLoad
{

    static OnUnityLoad()
    {

        EditorApplication.playmodeStateChanged = () =>
        {

            if (EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying)
            {
                if (CommonToolsWindow.MustSave)
                {
                    var time = DateTime.Now;
                    Debug.Log("Auto-Saving scene before entering Play mode: " + EditorApplication.currentScene);

                    EditorApplication.SaveScene();
                    AssetDatabase.SaveAssets();

                    Debug.Log(String.Format("Auto-Saving complete ({0} sec)", (DateTime.Now - time).Seconds));
                }
            }

        };

    }

}