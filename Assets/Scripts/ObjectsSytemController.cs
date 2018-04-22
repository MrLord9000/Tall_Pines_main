using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSytemController : MonoBehaviour {

    private GameObject FlashlightSPRITE;
    public float FlashlightTime = 15.0f;

    private GameObject TrapSPRITE;
    public float TrapDelayTime = 10.0f;

    private GameObject AxeSPRITE;
    public int LimitOfUsesAxe = 2;
    public int ActualUses = 0;

    private GameObject MacheteSPRITE;

    private GameObject Flashlight_cookie;

    private float FlashlightTimeElapsed = 0.0f;
    private float TrapTimeElapsed = 15.0f;

    public bool BOOL_Flashlight = false;
    public bool BOOL_Trap = false;
    public bool BOOL_Axe = false;
    public bool BOOL_Machete = false;

    public float trapTimeBonus = 4.0f;

    public bool poszlo = false;

    // Use this for initialization
    void Start ()
    {
        FlashlightSPRITE = GameObject.Find("FlashlightSPRITE");
        TrapSPRITE = GameObject.Find("TrapSPRITE");
        AxeSPRITE = GameObject.Find("AxeSPRITE");
        MacheteSPRITE = GameObject.Find("MacheteSPRITE");
        Flashlight_cookie = GameObject.Find("Flashlight_cookie");

        Flashlight_cookie.SetActive(false);
        FlashlightSPRITE.SetActive(false);
        TrapSPRITE.SetActive(false);
        AxeSPRITE.SetActive(false);
        MacheteSPRITE.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if ( BOOL_Flashlight )
        {
            if ( Time.time - FlashlightTimeElapsed >= FlashlightTime )
            {
                Debug.Log(Time.time - FlashlightTimeElapsed);
                Debug.Log("zgasła.");
                FlashlightSPRITE.SetActive(false);
                Flashlight_cookie.SetActive(false);
                BOOL_Flashlight = false;
            }
        }
        
        if ( BOOL_Trap )
        {
            if ( Input.GetKeyDown(KeyCode.E) )
            {
                Debug.Log("stawiasz pułapkę.");
                TrapTimeElapsed = Time.time;
                poszlo = true;
                TrapSPRITE.SetActive(false);
                Debug.Log("posszło");
            }

            if ( poszlo )
            {
                
                if ( Time.time - TrapTimeElapsed >= TrapDelayTime )
                {
                    float x = Random.Range(0f, 2.0f);
                    if ( x > 1.0f )
                    {
                        Debug.Log("ałaaaa!");
                        GameObject.Find("Canvas").GetComponentInChildren<Countdown_timer>().MainGameTimer += trapTimeBonus;
                    }
                    else
                    {
                        Debug.Log("pułapka nie poskutkowała.");
                    }
                    poszlo = false;
                    BOOL_Trap = false;
                    
                }
            }
        }
    }

    public void GotObject( int number )
    {
        if ( number == 1 )
        {
            BOOL_Flashlight = true;
            Debug.Log("masz przedmiot.latarka świeci");
            FlashlightSPRITE.SetActive(true);
            Flashlight_cookie.SetActive(true);
            FlashlightTimeElapsed = Time.time;
            GameObject.Find("Canvas").GetComponentInChildren<Countdown_timer>().SetTimeMultiplication(0.9f);
            
        }
        else if ( number == 2 )
        {
            BOOL_Trap = true;
            Debug.Log("masz pułapkę. użyj E");
            TrapSPRITE.SetActive(true);
        }
        else if ( number == 3 )
        {
            BOOL_Axe = true;
            Debug.Log("podniesłeś sikire");
            //GameObject.Find("LyingTree").GetComponent<InteractionWithObjectScript>().GotTheRightObject(3);
            AxeSPRITE.SetActive(true);
        }
        else if (number == 4)
        {
            BOOL_Machete = true;
            Debug.Log("podniesłeś meszete");
            //GameObject.Find("Bushes").GetComponent<InteractionWithObjectScript>().GotTheRightObject(4);
            MacheteSPRITE.SetActive(true);
        }
    }
}
