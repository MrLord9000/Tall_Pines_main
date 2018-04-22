using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnGUI : MonoBehaviour {

    //public GameObject gui;

	// Use this for initialization
	void Start ()
    {
        GameObject.Find("GUI_main").GetComponent<SpriteRenderer>().enabled = true;
    }

}
