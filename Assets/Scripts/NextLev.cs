using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class NextLev : MonoBehaviour
{

    public GameObject NextLevName;
    public GameObject ThisLevName;
    public GameObject Transition;
    public string Description;

    public bool Dodatnie;
    private float czas;

    private GameObject Time;

    void Start()
    {
        Time = GameObject.Find("Canvas");
        Transition = GameObject.Find("Czarne");
    }

    void OnMouseDown()
    {
        //czas = Time.GetComponentInChildren<Countdown_timer>().MainGameTimer;
        Transition.SetActive(true);
        print("uwaga!");
        StartCoroutine(WaitForPlay(0.5f));

            


        if (Dodatnie)
            Time.GetComponentInChildren<Countdown_timer>().MainGameTimer += 10;
        else
            Time.GetComponentInChildren<Countdown_timer>().MainGameTimer -= 15;
    }

    IEnumerator WaitForPlay(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        ThisLevName.SetActive(false);
        NextLevName.SetActive(true);
        print("Odczekane 0.5sek");
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