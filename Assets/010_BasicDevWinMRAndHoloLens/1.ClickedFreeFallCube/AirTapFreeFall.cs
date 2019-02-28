using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class AirTapFreeFall : MonoBehaviour , IInputClickHandler{

    public GameObject GeneratedCube;
    public GameObject GeneratedCube2;
    public GameObject GeneratedCube3;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        //TODO:このGameObjectにRigidbodyのコンポーネントを追加する。
        //gameObject.AddComponent<Rigidbody>();

        var num = Random.Range(0, 9);
        GameObject instantiate;

        if (num <= 3)
        {
             instantiate = GameObject.Instantiate(GeneratedCube);
        }
        else if(num <= 6)
        {
            instantiate = GameObject.Instantiate(GeneratedCube2);
        }
        else
        {
             instantiate = GameObject.Instantiate(GeneratedCube3);
        }

        //var instantiate = GameObject.Instantiate(GeneratedCube);

        instantiate.transform.position = Camera.main.transform.position
            + Camera.main.transform.forward * 1.5f;
    }
}
