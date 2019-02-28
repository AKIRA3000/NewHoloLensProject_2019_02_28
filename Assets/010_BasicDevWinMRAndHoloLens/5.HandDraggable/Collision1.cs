using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision1 : MonoBehaviour {


    //オブジェクトが衝突したとき
    void OnCollisionEnter(Collision collision)
    {
        Quaternion quaternion = this.transform.rotation;
        Debug.Log(quaternion);

        float y = quaternion.eulerAngles.y;
        float z = quaternion.eulerAngles.z;

        this.transform.rotation = Quaternion.Euler(0.0f, y, z);
    }

    //オブジェクトが離れた時
    void OnCollisionExit(Collision collision)
    {
        

    }

}
