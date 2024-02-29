using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleController_B : MonoBehaviour
{
    public int dayIndicator;
    public int secondsCount;
    public bool timeTicking = true;

    // Start is called before the first frame update
    void Start()
    {
        dayIndicator = 0;
        StartCoroutine(SecondTick()); 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Estamos en el dia:" + dayIndicator);
        /*if(secondsCount % 10 = 0)
        {
            dayIndicator ++;
        }*/
    }

    IEnumerator SecondTick()
    {
        while(true)
        {
            yield return new WaitUntil(() => timeTicking); 
            yield return new WaitForSeconds(1f);
            secondsCount ++; 
        }
    }
    

    

    
    
}
