using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class DraggableCube : MonoBehaviour {

    private HandDraggable _handDraggable;
    private Rigidbody _rigidbody;
    public float Rotationing;

    // Use this for initialization
    void Start () {
	    _handDraggable = GetComponent<HandDraggable>();
	    _handDraggable.StartedDragging += HandDraggableOnStartedDragging;
	    _handDraggable.StoppedDragging += HandDraggableOnStoppedDragging;
	    _rigidbody = GetComponent<Rigidbody>();
    }


    private void HandDraggableOnStoppedDragging()
    {
        //TODO:ドラック完了時に重力制御を有効にします。
        _rigidbody.useGravity = true;
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    }

    private void HandDraggableOnStartedDragging()
    {
        //TODO:ドラック完了時に重力制御を無効にします。
        _rigidbody.useGravity = false;
        this.transform.rotation = Quaternion.Euler(0.0f, Rotationing, 0.0f );
    }
}
