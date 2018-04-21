using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSytemController : MonoBehaviour {

    public GameObject Object1;
    public float FlashlightTime = 2.0f;
    private float timeElapsed = 0.0f;
    public GameObject Object2;

    public bool BOOLObject1 = false;
    public bool BOOLObject2 = false;

    // Use this for initialization
    void Start ()
    {
        BOOLObject1 = false;
        BOOLObject2 = false;

        Object1.SetActive(false);
        Object2.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if ( BOOLObject1 )
        {
            if ( Time.time - timeElapsed >= FlashlightTime )
            {
                Debug.Log("zgasła.");
                Object1.SetActive(false);
            }
        }
    }

    public void GotObject( int number )
    {
        if ( number == 1 )
        {
            BOOLObject1 = true;
            Debug.Log("masz przedmiot.latarka świeci");
            Object1.SetActive(true);
            timeElapsed = Time.time;
        }
    }
}
