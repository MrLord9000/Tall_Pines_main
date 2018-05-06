using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitUntilKey : MonoBehaviour {

    public string Key;
    public GameObject Obj;
    public bool SetActive;

    void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            Obj.SetActive(SetActive);
        }
    }
}
