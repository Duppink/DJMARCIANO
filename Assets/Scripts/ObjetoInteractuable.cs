using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoInteractuable : MonoBehaviour
{
    public Textos textos;
    public Transform controlDialogos;
    

    private void OnMouseDown()
    {
        controlDialogos.position = new Vector3(100, 300, 0);
        FindObjectOfType<ControlDialogos>().ActivarCartel(textos);
        Debug.Log("caca"); 
    }

    

    

}
