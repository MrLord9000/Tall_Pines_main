using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackScreen : MonoBehaviour {

    GameObject Black;
    int TimeOfAnimation;

	// Use this for initialization
	void Start () {
        Black = GameObject.Find("Czarne");
        TimeOfAnimation = 0;
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        if (TimeOfAnimation > 0)
        {
        TimeOfAnimation--;
        }
        else
        {
            Black.SetActive(false);
        }
    }

    void OnMouseDown()
    {
        Black.SetActive(true);
        TimeOfAnimation = 60;
    }


}
