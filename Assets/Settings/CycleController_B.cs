using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleController_B : MonoBehaviour
{
    public static CycleController_B singletonCC;

    public int dayIndicator;

    public int secondsCount;
    public int modChangeDays;

    public bool itsDay = true;
    public int modDnN;

    public bool timeTicking = true;
    // Start is called before the first frame update
    void Awake()
    {
        if(singletonCC != null)
        {
            DestroyImmediate(this);
        }
        else
        {
            singletonCC = this;
        }
    }

    void Start()
    {
        dayIndicator = 0;
        StartCoroutine(SecondTick()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SecondTick()
    {
        while(true)
        {
            yield return new WaitUntil(() => timeTicking); 
            yield return new WaitForSeconds(1f);
            secondsCount ++; 
            DaysCounter();
        }
    }
    
    public void DaysCounter()
    {
        modChangeDays = secondsCount % 10;
        modDnN = secondsCount % 5;
        if(modChangeDays == 0)
        {
            dayIndicator ++;
            Debug.Log("Estamos en el dia:" + dayIndicator);
        }
        if(modDnN == 0)
        {
            itsDay = !itsDay;
        }

    }
    

    
    
}
