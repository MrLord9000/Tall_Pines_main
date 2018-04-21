using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSytemController : MonoBehaviour {

    private GameObject FlashlightSPRITE;
    public float FlashlightTime = 2.0f;

    private GameObject TrapSPRITE;
    public float TrapDelayTime = 10.0f;

    private GameObject AxeSPRITE;
    public int LimitOfUsesAxe = 2;

    private GameObject MacheteSPRITE;

    private float FlashlightTimeElapsed = 0.0f;
    private float TrapTimeElapsed = -10.0f;

    private bool BOOL_Flashlight = false;
    private bool BOOL_Trap = false;
    private bool BOOL_Axe = false;
    private bool BOOL_Machete = false;

    // Use this for initialization
    void Start ()
    {
        FlashlightSPRITE = GameObject.Find("FlashlightSPRITE");
        TrapSPRITE = GameObject.Find("TrapSPRITE");
        AxeSPRITE = GameObject.Find("AxeSPRITE");
        MacheteSPRITE = GameObject.Find("MacheteSPRITE");

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
            if ( Time.time - TrapTimeElapsed >= FlashlightTime )
            {
                Debug.Log("zgasła.");
                FlashlightSPRITE.SetActive(false);
                BOOL_Flashlight = false;
            }
        }
        
        if ( BOOL_Trap )
        {
            if ( Input.GetKeyDown(KeyCode.E) )
            {
                Debug.Log("stawiasz pułapkę.");
                TrapTimeElapsed = Time.time;
            }

            if ( TrapTimeElapsed > -10.0f )
            {
                Debug.Log("posszło");
                if ( Time.time - TrapTimeElapsed >= TrapDelayTime )
                {
                    float x = Random.Range(0f, 2.0f);
                    if ( x > 1.0f )
                    {
                        Debug.Log("ałaaaa!");
                    }
                    else
                    {
                        Debug.Log("pułapka nie poskutkowała.");
                    }

                    BOOL_Trap = false;
                    TrapSPRITE.SetActive(false);
                    TrapTimeElapsed = -20.0f;
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
            TrapTimeElapsed = Time.time;
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
            Debug.Log("podniesłeś sikire");
            GameObject.Find("LyingTree").GetComponent<InteractionWithObjectScript>().GotTheRightObject(3);
            AxeSPRITE.SetActive(true);
        }
        else if (number == 4)
        {
            Debug.Log("podniesłeś meszete");
            GameObject.Find("Bushes").GetComponent<InteractionWithObjectScript>().GotTheRightObject(4);
            MacheteSPRITE.SetActive(true);
        }
    }
}
