using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver_restart : MonoBehaviour {


	void OnMouseDown () {
        SceneManager.LoadScene("Piotrek");
    }
}
