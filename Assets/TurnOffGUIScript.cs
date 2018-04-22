using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffGUIScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        GameObject.Find("GUI_main").GetComponent<SpriteRenderer>().enabled = false;
	}
	
}
