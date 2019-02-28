using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishTurning2 : MonoBehaviour {

    // Use this for initialization
    public GameObject gObject;
    public float FishSpeed;

    private float speed = 0.1f;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(gObject.transform.position, Vector3.up, speed);
    }
}
