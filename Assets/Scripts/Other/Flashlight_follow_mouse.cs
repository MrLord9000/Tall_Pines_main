using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight_follow_mouse : MonoBehaviour {


	void Update () {
        Vector3 temp = Input.mousePosition;
        temp.z = 1f; // Set this to be the distance you want the object to be placed in front of the camera.
        this.transform.position = Camera.main.ScreenToWorldPoint(temp);
    }
}
