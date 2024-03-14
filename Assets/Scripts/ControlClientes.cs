using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class ControlClientes : MonoBehaviour
{
    public Cliente [] clientes;
    public Flowchart dialogo;
    public GameObject fondo;
    public Image imCliente;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarCliente(int num)
    {
        imCliente.sprite = clientes[num].imagen;
        dialogo.SendFungusMessage(clientes[num].mensaje);
        fondo.SetActive(true);
    }
}
