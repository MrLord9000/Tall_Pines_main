﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown_timer : MonoBehaviour {

    public float MainGameTimer = 25;
    public Text timerText;

    public GameObject GameOver;

    private float Mult;

    private int FramesCount;

    // Use this for initialization
    void Start () {
        timerText = GetComponent<Text>();
        FramesCount = 0;
        Mult = 1;
	}
	
	// Update is called once per frame
	void Update () {
        MainGameTimer -= Time.deltaTime;
        timerText.text = MainGameTimer.ToString("f0");
	}

    public void SetTimeMultiplication(float Multiplicator)
    {
        Mult = Multiplicator;
    }

    void LateUpdate()
    {
        
    }
}

    public GameObject GameOver;

    private float Mult;

    // Use this for initialization
    void Start () {

        Mult = 1;


    public void SetTimeMultiplication(float Multiplicator)
    {
        Mult = Multiplicator;
    }




      