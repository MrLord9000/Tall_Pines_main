using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_exit : MonoBehaviour {

    public Sprite buttonNormal;
    public Sprite buttonHover;
    public Sprite buttonPressed;
    public SpriteRenderer currentSprite;

    void OnMouseDown () {
        
        currentSprite.sprite = buttonPressed;
    }

    void OnMouseUp()
    {
        Application.Quit();
        Debug.Log("Wyjście");
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
