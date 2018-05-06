using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NextLev : MonoBehaviour
{

    public GameObject NextLevName;
    public GameObject ThisLevName;

    public bool Dodatnie;

    private float TimeOfAnimation;
    private bool Done;

    private GameObject GTime;

    void Start()
    {
        GTime = GameObject.Find("Canvas");
        Done = true;
        TimeOfAnimation = 0.5f;
    }

    void FixedUpdate()
    {
        if(!Done && TimeOfAnimation >=0)
            TimeOfAnimation = TimeOfAnimation - Time.deltaTime;
        else if(!Done && TimeOfAnimation < 0)
        {
            
            NextLevName.SetActive(true);

            if (Dodatnie)
                GTime.GetComponentInChildren<Countdown_timer>().MainGameTimer += 10;
            else
                GTime.GetComponentInChildren<Countdown_timer>().MainGameTimer -= 15;

            Done = true;
            TimeOfAnimation = 0.5f;
            ThisLevName.SetActive(false);
        }
            
    }

    void OnMouseDown()
    {
        Done = false;
    }


}