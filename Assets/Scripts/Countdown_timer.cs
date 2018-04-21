using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Countdown_timer : MonoBehaviour {

    public float MainGameTimer = 30;
    public Text timerText;

    public GameObject GameOver;


    // Use this for initialization
    void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        if(MainGameTimer<=0)
            GameOver.SetActive(true);

        MainGameTimer -= Time.deltaTime;
        timerText.text = MainGameTimer.ToString("f0");
        
    }

    
}


