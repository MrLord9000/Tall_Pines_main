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
        //change = !change;
        //yield WaitForSeconds(2);


        if ( time.GetComponentInChildren<Countdown_timer>().MainGameTimer % 4 < 2)
            change = false;
        else change = true;
    }
}
