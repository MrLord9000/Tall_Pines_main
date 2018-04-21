using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsObtainingController : MonoBehaviour {

    public GameObject ObjectsSystem;
    public int ObjectNumber = 1;

    private int flashlight = 1;
    private int object2 = 2;

	// Use this for initialization
	void Start ()
    {
        ObjectsSystem = GameObject.Find("GameObjectsController");
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnMouseDown()
    {
        ObjectsSystem.GetComponent<ObjectsSytemController>().GotObject( ObjectNumber );
        this.gameObject.SetActive(false);
    }
}
