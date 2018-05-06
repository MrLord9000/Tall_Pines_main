using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PrevLev : MonoBehaviour {

    public Sprite buttonNormal;
    public Sprite buttonHover;
    public Sprite buttonPressed;
    public SpriteRenderer currentSprite;

    public GameObject prevScene;
    public GameObject currentScene;

    private GameObject GTime;

    private float TimeOfAnimation;
    private bool Done;

    void Start()
    {
        GTime = GameObject.Find("Canvas");
        Done = true;
        TimeOfAnimation = 0.5f;
    }

    void FixedUpdate()
    {
        if (!Done && TimeOfAnimation >= 0)
            TimeOfAnimation = TimeOfAnimation - Time.deltaTime;
        else if (!Done && TimeOfAnimation < 0)
        {
            

            GTime.GetComponentInChildren<Countdown_timer>().MainGameTimer -= 15;

            Done = true;
            TimeOfAnimation = 0.5f;
            currentScene.SetActive(false);
            prevScene.SetActive(true);
        }
    }

    void OnMouseDown()
        {
        currentSprite.sprite = buttonPressed;
        Done = false;
    }
    /*
        void OnMouseUp()
        {
        currentScene.SetActive(false);
        prevScene.SetActive(true);
        }
        */
        void OnMouseEnter()
        {

        currentSprite.sprite = buttonHover;
            //If your mouse hovers over the GameObject with the script attached, output this message
            //Debug.Log("Mouse is over GameObject.");
            
        }

        void OnMouseExit()
        {
        currentSprite.sprite = buttonNormal;
            //The mouse is no longer hovering over the GameObject so output this message each frame
            //Debug.Log("Mouse is no longer on GameObject.");
        }

        
}
