using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackScreen : MonoBehaviour {

    public GameObject ObjectWithAnimation;
    public float TimeOfAnimation;

    private float Timer;
    private bool ToDo;

	void Start ()
    {
        //ObjectWithAnimation = GameObject.Find("Czarne");
        Timer = 0;
        ToDo = false;
	}

    void FixedUpdate()
    {
        if (Timer > 0 && ToDo)
            Timer = Timer - Time.deltaTime;
        else
        {
            ObjectWithAnimation.SetActive(false);
            ToDo = false;
        }
        Debug.Log(Timer);
    }
    
    void OnMouseDown()
    {
        ObjectWithAnimation.SetActive(true);
        Timer = TimeOfAnimation;
        ToDo = true;
        ObjectWithAnimation.SetActive(false);
    }


}
