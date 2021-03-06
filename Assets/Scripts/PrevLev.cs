﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PrevLev : MonoBehaviour {

    public Sprite buttonNormal;
    public Sprite buttonHover;
    public Sprite buttonPressed;
    public SpriteRenderer currentSprite;

    public GameObject prevScene;
    public GameObject currentScene;

    private GameObject Time;

    void Start()
    {
        Time = GameObject.Find("Canvas");
    }

    void OnMouseDown()
        {
        Time.GetComponentInChildren<Countdown_timer>().MainGameTimer -= 15;
        currentSprite.sprite = buttonPressed;
                 
        Debug.Log("Naciśnięto");
        }

        void OnMouseUp()
        {
        currentScene.SetActive(false);
        prevScene.SetActive(true);
        }

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
