using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandle : MonoBehaviour {

    public GameObject obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        //gameObject.AddComponent<Rigidbody>();
        var instantiate = GameObject.Instantiate(obj);
        instantiate.transform.position = Camera.main.transform.position
            + Camera.main.transform.forward * 2f;
        Debug.Log("成功");
    }
}
