using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientTest_Bl : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Client1();
    }

    public void Client1()
    {
       if(CycleController_B.singletonCC.dayIndicator == 1 && CycleController_B.singletonCC.secondsCount == 16)
       {
        Debug.Log("Primer Cliente LLega");
        CycleController_B.singletonCC.timeTicking = false;
        Debug.Log("Hola soy el cliente");
        StartCoroutine(ClientWaitTest());
       }

    }

    IEnumerator ClientWaitTest()
    {
        yield return new WaitForSeconds(4f);
        Debug.Log("Chao soy el cliente");
        CycleController_B.singletonCC.timeTicking = true;

    }

}
