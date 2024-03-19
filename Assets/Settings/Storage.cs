using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    public static Storage singletonS;

    //Inventario Posible
    public int whiteBox = 1;

    void Awake()
    {
        if(singletonS != null)
        {
            DestroyImmediate(this);
        }
        else
        {
            singletonS = this;
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
