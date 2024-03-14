using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Ejemplo : MonoBehaviour
{
    public Flowchart dialogo;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)){
            dialogo.SendFungusMessage("Casa");
        }
    }
}
