using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delayer : MonoBehaviour {

    public float TimeOfDelay;
    public GameObject ObjectToDelay;
    public bool SetActive;
    public bool OnClick;

    private bool Done;
    private float DelayTime;

    void Start()
    {
        if (!OnClick)
            Done = false;
        else
            Done = true;
        DelayTime = TimeOfDelay;
    }

    void Update ()
    {
        if(!Done)
            Delay();
	}

    void OnMouseDown()
    {
        if(OnClick)
            Done = false;
    }

    void Delay()
    {
        if (!Done)
            DelayTime = DelayTime - Time.deltaTime;

        if (DelayTime < 0)
        {
            ObjectToDelay.SetActive(SetActive);
            DelayTime = TimeOfDelay;
            Done = true;
        }
    }
}
