using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionWithObjectScript : MonoBehaviour {

    public int Tree_Bush = 0;
    public float ExecutionTime = 2.0f;

    private float relTime = 0f;

    bool WaitForInteraction = false;
    bool Chopping = false;

    public GameObject Aktywacja;
    public SpriteRenderer rend;
	
	// Update is called once per frame

    void Start()
    {
        Aktywacja.SetActive(false);
        rend.enabled = true;
    }

    void Update()
    {
        if (Chopping && (Time.time - relTime >= ExecutionTime))
        {
            rend.enabled = false;
            this.GetComponent<SpriteRenderer>().enabled = false;
            Aktywacja.SetActive(true);
            Debug.Log("juz");
            Chopping = false;
        }
    }

    public void GotTheRightObject( int _34axe_machete )
    {
        if (_34axe_machete == 3 && Tree_Bush == 1 || _34axe_machete == 4 && Tree_Bush == 2)
        {
            WaitForInteraction = true;
        }

    }

    void OnMouseDown()
    {
        if (WaitForInteraction)
        {
            Chopping = true;
            relTime = Time.time;
            Debug.Log("scinam");
        }
    }

}
