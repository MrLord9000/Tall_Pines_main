using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour {

    private bool change;
    private GameObject time;
    public GameObject kropka;

    void Start()
    {
        change = true;
        time = GameObject.Find("Canvas");
    }

	void Update () {
        kropka.SetActive(change);
        change = !change;
        //yield WaitForSeconds(2);


        if ( (int)time.GetComponentInChildren<Countdown_timer>().MainGameTimer % 2 == 0)
        {
            if (change) change = false;
            else change = true;
            
        }
    }
}
