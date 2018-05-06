using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionWithObjectScript : MonoBehaviour {

    public int Tree_Bush = 0;
    public float ExecutionTime = 6.0f;

    private float relTime = 0f;

    bool WaitForInteraction = false;
    bool Chopping = false;

    private bool Axe_Bool = false;
    private bool Machete_Bool = false;

    public GameObject Aktywacja;
    public SpriteRenderer rend;

    private AudioSource audio;
    public GameObject particles;
	
	// Update is called once per frame

    void Start()
    {
        audio = GetComponent<AudioSource>();
        if(Aktywacja != null)
            Aktywacja.SetActive(false);
        rend.enabled = true;
        relTime = 0f;
    }

    void Update()
    {
        if ( GameObject.Find("GameObjectsController").GetComponent<ObjectsSytemController>().BOOL_Axe && Tree_Bush == 1 )
        {
            Axe_Bool = true;
            WaitForInteraction = true;
        }

        if (GameObject.Find("GameObjectsController").GetComponent<ObjectsSytemController>().BOOL_Machete && Tree_Bush == 2 )
        {
            Machete_Bool = true;
            WaitForInteraction = true;
        }


        if (Chopping && (Time.time - relTime >= ExecutionTime))
        {
            rend.enabled = false;
            this.GetComponent<SpriteRenderer>().enabled = false;
            Aktywacja.SetActive(true);
            Debug.Log("juz");
            audio.Stop();
            particles.SetActive(false);
            Chopping = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    void OnMouseDown()
    {
        Debug.Log("onmousedown");
        if (!WaitForInteraction)
            Debug.Log("wait");
        if (WaitForInteraction)
        {
            particles.SetActive(true);
            audio.Play();
            Chopping = true;
            relTime = Time.time;
            Debug.Log("scinam");
        }
    }

}
