using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class NextLev : MonoBehaviour {

    public GameObject NextLevName;
    public GameObject ThisLevName;
    public bool Dodatnie;

    private GameObject Time;

    void Start()
    {
        Time = GameObject.Find("Canvas");
    }

    void OnMouseDown()
    {

        
        NextLevName.SetActive(true);
        ThisLevName.SetActive(false);
        
        if(Dodatnie)
            Time.GetComponentInChildren<Countdown_timer>().MainGameTimer += 30;
        else
            Time.GetComponentInChildren<Countdown_timer>().MainGameTimer -= 45;
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