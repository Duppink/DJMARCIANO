using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoInteractuable : MonoBehaviour
{
    public Textos textos;
    public Transform controlDialogos;
    //public Image cloud;
    public ImportantSecret ImpoSecre = null;
    public ImportantSecret2 ImpoSecre2 = null;
    public ImportantSecret3 ImpoSecre3 = null;
    
    
    private void Start()
    {
        //cloud = GetComponent<Image>();
    }

    private void OnMouseDown()
    {
        if (ImpoSecre != null)
        {
            ImpoSecre.CheckForImportantMessage();
        }
        

        if (ImpoSecre2 != null)
        {
            ImpoSecre2.CheckForImportantMessage();
        }
        

        if (ImpoSecre3 != null)
        {
            ImpoSecre3.CheckForImportantMessage();
        }
        
        
        controlDialogos.position = new Vector3(1000, 365, 0);
        //cloud.enabled = !cloud.enabled;
        FindObjectOfType<ControlDialogos>().ActivarCartel(textos);        
    }

    

    

}
