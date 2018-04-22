using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Noise : MonoBehaviour
{
    float TimeM;
    public GameObject Anim;


    public bool Petla;
    public float OKtorej;
    public float CoIle;
    public float Ile;

    private GameObject GameTime;

    void Start()
    {
        TimeM = 0f;
        GameTime = GameObject.Find("Canvas");

    }

    void FixedUpdate()
    {
        if (Petla)
        {
            TimeM += Time.deltaTime;

            if (TimeM > CoIle - Ile)
                Anim.SetActive(true);
            else
                Anim.SetActive(false);

        }
        else
        {
            if (GameTime.GetComponentInChildren<Countdown_timer>().MainGameTimer > OKtorej - 0.05 - Ile && GameTime.GetComponentInChildren<Countdown_timer>().MainGameTimer < OKtorej + 0.05)
                Anim.SetActive(true);
            else
                Anim.SetActive(false);
        }

        if (TimeM > CoIle)
            TimeM = 0;
    }

}