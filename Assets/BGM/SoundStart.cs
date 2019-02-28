using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundStart : MonoBehaviour {


    public float StartTime = 0.0f;


    // Use this for initialization
    void Start() {
        StartMusic();
    }


    public void StartMusic(){

        GetComponent<AudioSource>().time = StartTime;
        GetComponent<AudioSource>().Play();

    }


}
