using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anykey_exit : MonoBehaviour {


	void Update () {
		if (Input.anyKey)
            Application.Quit();
    }
}
