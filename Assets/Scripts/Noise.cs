using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Noise : MonoBehaviour
{
    float TimeM;
    public GameObject Anim;

    void Start()
    {
        TimeM = 0f;
    }

    void FixedUpdate()
    {
        TimeM += Time.deltaTime;

        if (TimeM> 9.0f )
            Anim.SetActive(true);
        else
            Anim.SetActive(false);
        if (TimeM > 10.0f)
            TimeM = 0;

    }

}