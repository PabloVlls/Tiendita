using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupplierManager_BL : MonoBehaviour
{
    public int modSupplierA = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SupplierArrives();
    }

    public void SupplierArrives()
    {
        modSupplierA = CycleController_B.singletonCC.dayIndicator % 3;
        if(modSupplierA == 0)
        {
        CycleController_B.singletonCC.timeTicking = false;
        }
    }
}
