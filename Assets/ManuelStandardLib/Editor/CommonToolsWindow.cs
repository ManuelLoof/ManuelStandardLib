using UnityEngine;
using UnityEditor;

public class CommonToolsWindow : EditorWindow
{
    #region properties

    public static bool AutoSave { get; private set; }
    public static bool SceneDirty { get; private set; }
    public static bool MustSave
    {
        get
        {
            return AutoSave || SceneDirty; 
        }
    }

    #endregion

    // Add menu named "My Window" to the Window menu
    [MenuItem("Window/ManuelStandardLib/Common Tools")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        var window = GetWindow<CommonToolsWindow>();
        AutoSave = true; 
    }

    void OnGUI()
    {
        SceneDirty = GUILayout.Toggle(EditorApplication.isSceneDirty, "IsSceneDirty" );
        AutoSave = GUILayout.Toggle(AutoSave, "AutoSave");

    }
}