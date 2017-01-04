using UnityEngine;
using System.Collections;

/// <summary>
/// For objects that should only be view in the editor. In play mode is the object invisible. 
/// </summary>
public class EditorObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<MeshRenderer>().enabled = false; 
	}
	
	
}
