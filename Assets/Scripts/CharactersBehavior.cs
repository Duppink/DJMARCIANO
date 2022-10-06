using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharactersBehavior : MonoBehaviour
{
    public GameManager gm;      // Referencia al script Game Manager.
    public GameObject interactable1; 
    
    [Header("Favorites")]
    public int favPercussion;       // Variable que contiene la percusión favorita del personaje.
    public int favStyle;        // Variable que contiene el estilo favorito del personaje.
    public int favLights;       // Variable que contiene la luz favorita del personaje.

    [Header("Satisfaction")]
    public bool satisfiedPercussion = false;        // Variable que evalúa si la percusión favorita del personaje está sonando o no.
    public bool satisfiedStyle = false;     // Variable que evalúa si el estilo favorito del personaje está sonando o no.
    public bool satisfiedLights = false;        // Variable que evalúa si la luz favorita del personaje está visible o no.
    public int satisfactionLevel = 0;       // Variable que contiene el valor de la satisfacción personal del personaje.

    [Header("Texts")]
    public TextMeshProUGUI personalSatisfaction;        // Referencia al texto que muestra la satisfacción personal del personaje.
    


    void Update()
    {
       personalSatisfaction.text = satisfactionLevel.ToString();        // Actualización del texto "personalSatisfaction" para que muestre el valor de la variable "satisfactionLevel".     
       
        if (satisfactionLevel == 3)
        {
            interactable1.SetActive(true);
        }

        else
        {
            interactable1.SetActive(false);
        }

    }


    public void FavPerc()       // Función que evalúa si está sonando la percusión favorita del personaje o no.     

    {        
        if (gm.percussionSelected == favPercussion && satisfiedPercussion == false) 
        {
            satisfiedPercussion = true;
            satisfactionLevel = satisfactionLevel + 1;  

                     
        }

        else 
        
        {
            if (satisfiedPercussion == true)

            {
                satisfiedPercussion = false;
                satisfactionLevel = satisfactionLevel - 1;
            }
              
        }
        

    }

    public void FavSty()        // Función que evalúa si está sonando el estilo favorito del personaje o no.  

    {
        if (!satisfiedStyle) 
        
        {
            if (gm.currentStyle == favStyle || gm.lastStyle == favStyle) 
        
             {
                satisfiedStyle = true;
                satisfactionLevel = satisfactionLevel + 1;            
             }
             
        }

        

        else 

        {              

            if (satisfiedStyle == true) 

            {
                if (gm.currentStyle != favStyle && gm.lastStyle != favStyle) 

                {
                satisfiedStyle = false;
                satisfactionLevel = satisfactionLevel - 1;
                }
            }
             
            
        }
    }

    public void FavLig()        // Función que evalúa si está visible la luz favorita del personaje o no.  

    {
        if (!satisfiedLights) 
        
        {
            if (favLights == gm.lightsValue1 || favLights == gm.lightsValue2 || favLights == gm.lightsValue3 || favLights == gm.lightsValue4)

                {
                    satisfiedLights = true;
                    satisfactionLevel = satisfactionLevel + 1;
                }
                
        }

        

        else

        {
            if(satisfiedLights == true)

            {
                if (favLights != gm.lightsValue1 && favLights != gm.lightsValue2 && favLights != gm.lightsValue3 && favLights != gm.lightsValue4)

                {
                    satisfiedLights = false;
                    satisfactionLevel = satisfactionLevel - 1;
                }
                
            }
            
        }
       

    }
    
        
           

}
