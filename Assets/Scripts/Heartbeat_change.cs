using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartbeat_change : MonoBehaviour {

    public AudioSource heartbeat;
    private GameObject time;
    private float timeLeft;

    void Start()
    {
        time = GameObject.Find("Canvas");
    }

    void Update () {

        timeLeft = time.GetComponentInChildren<Countdown_timer>().MainGameTimer;

        if ( timeLeft > 25f )
        {
            heartbeat.pitch = 0.55f;
        }
        else if ( timeLeft > 10f )
        {
            heartbeat.pitch = (1f/(0.5f *timeLeft)) * 8f;
        }


    }
}
