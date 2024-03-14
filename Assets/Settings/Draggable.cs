using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IPointerDownHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    public RectTransform [] objectsSnap;
    public float closeTo = 500;
    public Vector2 initialPos;


    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
    }
    // Start is called before the first frame update
    void Start()
    {
        initialPos = rectTransform.anchoredPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Opcional: Agregar efectos visuales o lógica cuando se presiona el elemento.
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Opcional: Lógica para cuando se suelta el elemento.
        bool snapped = false;
    
        for(int i = 0; i < objectsSnap.Length; i++)
        {
            if((rectTransform.anchoredPosition - objectsSnap[i].anchoredPosition).magnitude < closeTo)
            {
                rectTransform.anchoredPosition = objectsSnap[i].anchoredPosition;
                snapped = true;
                Storage.singletonS.whiteBox = Storage.singletonS.whiteBox - 1;
                ShelveInventory.singletonSI.whiteBox =  ShelveInventory.singletonSI.whiteBox + 1;
            }

        }

        if (snapped == false)
        {
            rectTransform.anchoredPosition = initialPos;
        }
    }
}
