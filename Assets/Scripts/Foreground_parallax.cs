using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreground_parallax : MonoBehaviour {

    public GameObject Obiekt;
    public float XParallaxMultipler;
    public float YParallaxMultipler;

    private Transform Tr;
    private Vector3 MouseMov;
    private Vector3 MousePos;

    float x;
    float y;

    private void Start()
    {
        Tr = Obiekt.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update () {
        x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");
        MousePos=Input.mousePosition;

        if (MousePos.x >= 0 && MousePos.y <= Screen.width)
        {
            MouseMov = new Vector3(-x * XParallaxMultipler, 0,0);
            Tr.position = MouseMov + Tr.position;
        }

        if (MousePos.y >= 0 && MousePos.y <= Screen.height)
        {
            MouseMov = new Vector3(0, -y * YParallaxMultipler, 0);
            Tr.position = MouseMov + Tr.position;
        }
        
    }
}
