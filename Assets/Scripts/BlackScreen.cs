using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackScreen : MonoBehaviour {

    GameObject Black;

	// Use this for initialization
	void Start () {
        Black = GameObject.Find("Czarny");
	}

    // Update is called once per frame

    void OnMouseDown()
    {
        Black.SetActive(true);
        Black.SetActive(false);
    }
}
