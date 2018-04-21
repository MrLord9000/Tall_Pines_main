using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown_timer : MonoBehaviour {

    public float MainGameTimer = 99;
    public Text timerText;

	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        MainGameTimer -= Time.deltaTime;
        timerText.text = MainGameTimer.ToString("f0");
	}
}
