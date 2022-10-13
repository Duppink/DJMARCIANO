using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoInteractuable : MonoBehaviour
{
    public Textos textos;
    public Transform controlDialogos;
    //public Image cloud;
    
    private void Start()
    {
        //cloud = GetComponent<Image>();
    }

    private void OnMouseDown()
    {
        controlDialogos.position = new Vector3(1650, 200, 0);
        //cloud.enabled = !cloud.enabled;
        FindObjectOfType<ControlDialogos>().ActivarCartel(textos);
        Debug.Log("caca"); 
    }

    

    

}
