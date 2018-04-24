using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class NextLev : MonoBehaviour
{

    public GameObject NextLevName;
    public GameObject ThisLevName;

    public string Description;

    public bool Dodatnie;


    private GameObject Time;

    int TimeOfAnimation;
    bool Flag;

    void Start()
    {
        Time = GameObject.Find("Canvas");
        Flag = false;
        TimeOfAnimation = 0;
    }

    
    void FixedUpdate()
    {
        if (TimeOfAnimation > 0)
        {
            TimeOfAnimation--;
        }

        else if (Flag == true)
        {
            Flag = false;
            NextLevName.SetActive(true);
            ThisLevName.SetActive(false);
        }
    }
    

    void OnMouseDown()
    {
        Flag = true;
        TimeOfAnimation = 25;

     //   ThisLevName.SetActive(false);
       // NextLevName.SetActive(true);

        if (Dodatnie)
            Time.GetComponentInChildren<Countdown_timer>().MainGameTimer += 10;
        else
            Time.GetComponentInChildren<Countdown_timer>().MainGameTimer -= 15;
    }



}


/*
public class NextLev : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {

        Debug.Log("dziala");
    }
}
*/