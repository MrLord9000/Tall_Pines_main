using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreground_parallax : MonoBehaviour {

    public GameObject Obiekt;

    private Transform Tr;
    private Vector3 MouseMov;

    float x;
   // float y;
   // float z;

    private void Start()
    {
        Tr = Obiekt.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update () {
       x = Input.GetAxis("Mouse X");
        MouseMov = new Vector3(x, 0, 0);

        Tr.position = MouseMov + Tr.position;
    }
}
