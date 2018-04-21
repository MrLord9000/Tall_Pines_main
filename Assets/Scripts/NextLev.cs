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

        ThisLevName.SetActive(false);
        NextLevName.SetActive(true);

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