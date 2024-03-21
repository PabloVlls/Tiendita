using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelveInventory : MonoBehaviour
{
    public static ShelveInventory singletonSI;

    //Inventario Posible
    public int whiteBox = 0;

    void Awake()
    {
        if(singletonSI != null)
        {
            DestroyImmediate(this);
        }
        else
        {
            singletonSI = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
