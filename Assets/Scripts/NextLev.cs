using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class NextLev : MonoBehaviour {

    public GameObject NextLevName;
    public GameObject ThisLevName;
    //private GameObject 

    void OnMouseDown()
    {

        NextLevName.SetActive(true);
        ThisLevName.SetActive(false);
        
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