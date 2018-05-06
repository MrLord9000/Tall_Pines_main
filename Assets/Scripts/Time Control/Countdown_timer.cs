using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown_timer : MonoBehaviour {

    public float MainGameTimer = 99;
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

        //if(MainGameTimer>=50)
        
        //else if(MainGameTimer>=50)

        if(MainGameTimer<=0)
            SceneManager.LoadScene("Game Over");

        MainGameTimer -= Mult*Time.deltaTime;
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
