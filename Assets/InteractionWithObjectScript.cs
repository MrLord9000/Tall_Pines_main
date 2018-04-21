using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionWithObjectScript : MonoBehaviour {

    public int Tree_Bush = 0;

    bool WaitForInteraction = false;

    public SpriteRenderer rend;
	
	// Update is called once per frame

    void Start()
    {
        rend.enabled = false;
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
            rend.enabled = true;
            this.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

}
