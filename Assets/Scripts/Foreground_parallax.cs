using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreground_parallax : MonoBehaviour {

    private Vector3 mousePos;
	

	// Update is called once per frame
	void Update () {
        mousePos = Input.mousePosition;
	}
}
