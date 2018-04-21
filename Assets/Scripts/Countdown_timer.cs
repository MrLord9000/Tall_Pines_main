using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown_timer : MonoBehaviour {

    public float MainGameTimer = 99;
    public Text timerText;

    public GameObject GameOver;

    private int FramesCount;

    // Use this for initialization
    void Start () {
        timerText = GetComponent<Text>();
        FramesCount = 0;
	}
	
	// Update is called once per frame
	void Update () {

        //if(MainGameTimer>=50)
        
        //else if(MainGameTimer>=50)

        if(MainGameTimer<=0)
            GameOver.SetActive(true);

        MainGameTimer -= Time.deltaTime;
        timerText.text = MainGameTimer.ToString("f0");
	}
}
