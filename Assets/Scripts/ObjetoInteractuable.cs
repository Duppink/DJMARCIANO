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
    public bool IsClicked; 
    public GameObject ClickedEffect;
    public NotImportantSecret nis = null;
    
    
    private void Start()
    {
        //cloud = GetComponent<Image>();
    }

    private void OnMouseDown()
    {
        
        if (nis != null)
        {
            nis.CheckForNotImportantMessage();
        }
        
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

        if (IsClicked == false)
        {
            ClickedEffect.SetActive(true);
            ClickedEffect.transform.position = this.gameObject.transform.position;
            IsClicked = true;
            return;
        }

        if (IsClicked == true)
        {
            ClickedEffect.SetActive(false);
            IsClicked = false;
            return;
        }

        
        
        
           
    }

    

    

}
