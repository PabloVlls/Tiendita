using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShelveSlot : MonoBehaviour
{
    public RectTransform rt;

    public Draggable objectOccupied;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum ObjectsTypes
{
    none, 
    whiteBox,
    redBox
}
