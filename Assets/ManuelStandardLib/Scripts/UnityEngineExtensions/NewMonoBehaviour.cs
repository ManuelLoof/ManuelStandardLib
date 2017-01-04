using UnityEngine;

public class MyMonoBehaviour : MonoBehaviour
{

    /// <summary>
    /// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
    /// </summary>
    public virtual void Start() { }


    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    public virtual void Update() { }

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    public virtual void Awake() { }


    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    public virtual void FixedUpdate() { }


    /// <summary>
    /// LateUpdate is called every frame, if the Behaviour is enabled.
    /// </summary>
    public virtual void LateUpdate() { }


    /// <summary>
    /// Callback for setting up animation IK (inverse kinematics).
    /// </summary>
    public virtual void OnAnimatorIK() { }


    /// <summary>
    /// Callback for processing animation movements for modifying root motion.
    /// </summary>
    public virtual void OnAnimatorMove() { }


    /// <summary>
    /// Sent to all game objects when the player gets or loses focus.
    /// </summary>
    public virtual void OnApplicationFocus() { }


    /// <summary>
    /// Sent to all game objects when the player pauses.
    /// </summary>
    public virtual void OnApplicationPause() { }


    /// <summary>
    /// Sent to all game objects before the application is quit.
    /// </summary>
    public virtual void OnApplicationQuit() { }


    /// <summary>
    /// If OnAudioFilterRead is implemented, Unity will insert a custom filter into the audio DSP chain.
    /// </summary>
    public virtual void OnAudioFilterRead() { }


    /// <summary>
    /// OnBecameInvisible is called when the renderer is no longer visible by any camera.
    /// </summary>
    public virtual void OnBecameInvisible() { }


    /// <summary>
    /// OnBecameVisible is called when the renderer became visible by any camera.
    /// </summary>
    public virtual void OnBecameVisible() { }


    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
    /// </summary>
    public virtual void OnCollisionEnter() { }


    /// <summary>
    /// Sent when an incoming collider makes contact with this object's collider (2D physics only).
    /// </summary>
    public virtual void OnCollisionEnter2D() { }


    /// <summary>
    /// OnCollisionExit is called when this collider/rigidbody has stopped touching another rigidbody/collider.
    /// </summary>
    public virtual void OnCollisionExit() { }


    /// <summary>
    /// Sent when a collider on another object stops touching this object's collider (2D physics only).
    /// </summary>
    public virtual void OnCollisionExit2D() { }


    /// <summary>
    /// OnCollisionStay is called once per frame for every collider/rigidbody that is touching rigidbody/collider.
    /// </summary>
    public virtual void OnCollisionStay() { }


    /// <summary>
    /// Sent each frame where a collider on another object is touching this object's collider (2D physics only).
    /// </summary>
    public virtual void OnCollisionStay2D() { }


    /// <summary>
    /// Called on the client when you have successfully connected to a server.
    /// </summary>
    public virtual void OnConnectedToServer() { }


    /// <summary>
    /// OnControllerColliderHit is called when the controller hits a collider while performing a Move.
    /// </summary>
    public virtual void OnControllerColliderHit() { }


    /// <summary>
    /// This function is called when the MonoBehaviour will be destroyed.
    /// </summary>
    public virtual void OnDestroy() { }


    /// <summary>
    /// This function is called when the behaviour becomes disabled () or inactive.
    /// </summary>
    public virtual void OnDisable() { }


    /// <summary>
    /// Called on the client when the connection was lost or you disconnected from the server.
    /// </summary>
    public virtual void OnDisconnectedFromServer() { }


    /// <summary>
    /// Implement OnDrawGizmos if you want to draw gizmos that are also pickable and always drawn.
    /// </summary>
    public virtual void OnDrawGizmos() { }


    /// <summary>
    /// Implement this OnDrawGizmosSelected if you want to draw gizmos only if the object is selected.
    /// </summary>
    public virtual void OnDrawGizmosSelected() { }


    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    public virtual void OnEnable() { }


    /// <summary>
    /// Called on the client when a connection attempt fails for some reason.
    /// </summary>
    public virtual void OnFailedToConnect() { }


    /// <summary>
    /// Called on clients or servers when there is a problem connecting to the MasterServer.
    /// </summary>
    public virtual void OnFailedToConnectToMasterServer() { }


    /// <summary>
    /// OnGUI is called for rendering and handling GUI events.
    /// </summary>
    public virtual void OnGUI() { }


    /// <summary>
    /// Called when a joint attached to the same game object broke.
    /// </summary>
    public virtual void OnJointBreak() { }


    /// <summary>
    /// This function is called after a new level was loaded.
    /// </summary>
    public virtual void OnLevelWasLoaded() { }


    /// <summary>
    /// Called on clients or servers when reporting events from the MasterServer.
    /// </summary>
    public virtual void OnMasterServerEvent() { }


    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or Collider.
    /// </summary>
    public virtual void OnMouseDown() { }


    /// <summary>
    /// OnMouseDrag is called when the user has clicked on a GUIElement or Collider and is still holding down the mouse.
    /// </summary>
    public virtual void OnMouseDrag() { }


    /// <summary>
    /// Called when the mouse enters the GUIElement or Collider.
    /// </summary>
    public virtual void OnMouseEnter() { }


    /// <summary>
    /// Called when the mouse is not any longer over the GUIElement or Collider.
    /// </summary>
    public virtual void OnMouseExit() { }


    /// <summary>
    /// Called every frame while the mouse is over the GUIElement or Collider.
    /// </summary>
    public virtual void OnMouseOver() { }


    /// <summary>
    /// OnMouseUp is called when the user has released the mouse button.
    /// </summary>
    public virtual void OnMouseUp() { }


    /// <summary>
    /// OnMouseUpAsButton is only called when the mouse is released over the same GUIElement or Collider as it was pressed.
    /// </summary>
    public virtual void OnMouseUpAsButton() { }


    /// <summary>
    /// Called on objects which have been network instantiated with Network.Instantiate.
    /// </summary>
    public virtual void OnNetworkInstantiate() { }


    /// <summary>
    /// OnParticleCollision is called when a particle hits a collider.
    /// </summary>
    public virtual void OnParticleCollision() { }


    /// <summary>
    /// Called on the server whenever a new player has successfully connected.
    /// </summary>
    public virtual void OnPlayerConnected() { }


    /// <summary>
    /// Called on the server whenever a player disconnected from the server.
    /// </summary>
    public virtual void OnPlayerDisconnected() { }


    /// <summary>
    /// OnPostRender is called after a camera finished rendering the scene.
    /// </summary>
    public virtual void OnPostRender() { }


    /// <summary>
    /// OnPreCull is called before a camera culls the scene.
    /// </summary>
    public virtual void OnPreCull() { }


    /// <summary>
    /// OnPreRender is called before a camera starts rendering the scene.
    /// </summary>
    public virtual void OnPreRender() { }


    /// <summary>
    /// OnRenderImage is called after all rendering is complete to render image.
    /// </summary>
    public virtual void OnRenderImage() { }


    /// <summary>
    /// OnRenderObject is called after camera has rendered the scene.
    /// </summary>
    public virtual void OnRenderObject() { }


    /// <summary>
    /// Used to customize synchronization of variables in a script watched by a network view.
    /// </summary>
    public virtual void OnSerializeNetworkView() { }


    /// <summary>
    /// Called on the server whenever a Network.InitializeServer was invoked and has completed.
    /// </summary>
    public virtual void OnServerInitialized() { }


    /// <summary>
    /// This function is called when the list of children of the transform of the GameObject has changed.
    /// </summary>
    public virtual void OnTransformChildrenChanged() { }


    /// <summary>
    /// This function is called when the parent property of the transform of the GameObject has changed.
    /// </summary>
    public virtual void OnTransformParentChanged() { }


    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    public virtual void OnTriggerEnter() { }


    /// <summary>
    /// Sent when another object enters a trigger collider attached to this object (2D physics only).
    /// </summary>
    public virtual void OnTriggerEnter2D() { }


    /// <summary>
    /// OnTriggerExit is called when the Collider other has stopped touching the trigger.
    /// </summary>
    public virtual void OnTriggerExit() { }


    /// <summary>
    /// Sent when another object leaves a trigger collider attached to this object (2D physics only).
    /// </summary>
    public virtual void OnTriggerExit2D() { }


    /// <summary>
    /// OnTriggerStay is called once per frame for every Collider other that is touching the trigger.
    /// </summary>
    public virtual void OnTriggerStay() { }


    /// <summary>
    /// Sent each frame where another object is within a trigger collider attached to this object (2D physics only).
    /// </summary>
    public virtual void OnTriggerStay2D() { }


    /// <summary>
    /// This function is called when the script is loaded or a value is changed in the inspector (Called in the editor only).
    /// </summary>
    public virtual void OnValidate() { }


    /// <summary>
    /// OnWillRenderObject is called once for each camera if the object is visible.
    /// </summary>
    public virtual void OnWillRenderObject() { }


    /// <summary>
    /// Reset to default values.
    /// </summary>
    public virtual void Reset() { }




}
