using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo : MonoBehaviour
{
    public MonoBehaviour dialogo;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)){
            dialogo.SendMessage("Casa");
        }
    }
}
