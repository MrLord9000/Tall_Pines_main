using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver_restart : MonoBehaviour {

    public Sprite buttonNormal;
    public Sprite buttonHover;
    public Sprite buttonPressed;
    public SpriteRenderer currentSprite;

    void OnMouseDown()
    {
        currentSprite.sprite = buttonPressed;
    }

    void OnMouseUp()
    {
        SceneManager.LoadScene("Piotrek 11 - 38");
        Debug.Log("Restart");
    }
    void OnMouseEnter()
    {
        currentSprite.sprite = buttonHover;
    }
    void OnMouseExit()
    {
        currentSprite.sprite = buttonNormal;
    }
}

