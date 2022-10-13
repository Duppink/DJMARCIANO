using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControlDialogos : MonoBehaviour
{
    private Queue <string> colaDialogos;
    Textos texto; 
    //public GameObject cartel;
    [SerializeField] TextMeshProUGUI textoPantalla;

    //public Image cloud;

    void Start()
    {
        colaDialogos = new Queue<string> ();
        //cloud = GetComponent<Image>();
    }

    public void ActivarCartel(Textos textoObjeto)
    {
        gameObject.SetActive(true);
        texto = textoObjeto;
        ActivaTexto();
        
    }

    public void ActivaTexto()
    {
        colaDialogos.Clear();
        foreach (string textoGuardar in texto.arrayTextos)
        {
           colaDialogos.Enqueue(textoGuardar); 
        }
        SiguienteFrase();
    }

    public void SiguienteFrase()
    {
        if (colaDialogos.Count == 0)
        {
            CierraCartel();
            return;
        }

        string fraseActual = colaDialogos.Dequeue();
        textoPantalla.text = fraseActual;
    }

    public void CierraCartel()
    {
        gameObject.transform.position = new Vector3 (0,-138,0);
        //cloud.enabled = false;
    }
}
