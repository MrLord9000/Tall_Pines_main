using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WINTHEGAME : MonoBehaviour {


    // Update is called once per frame
    void OnMouseDown()
    {
        SceneManager.LoadScene("Win!");
    }

}
