using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering.Universal;

public class LightsController : MonoBehaviour
{
    public GameManager gm;      // Referencia al script Game Manager.
    public UnityEngine.Rendering.Universal.Light2D Spotlight1;
    public UnityEngine.Rendering.Universal.Light2D Spotlight2;
    public UnityEngine.Rendering.Universal.Light2D Spotlight3;
    public UnityEngine.Rendering.Universal.Light2D Spotlight4; 
    public UnityEngine.Rendering.Universal.Light2D Spotlight5;
    public UnityEngine.Rendering.Universal.Light2D Spotlight6;
    public UnityEngine.Rendering.Universal.Light2D Spotlight7;
    public UnityEngine.Rendering.Universal.Light2D Spotlight8;

    public bool activeSpotlights;  
    void Start()
    {
       Spotlight1.GetComponent<Light2D>(); 
       Spotlight2.GetComponent<Light2D>(); 
       Spotlight3.GetComponent<Light2D>(); 
       Spotlight4.GetComponent<Light2D>();
       Spotlight5.GetComponent<Light2D>(); 
       Spotlight6.GetComponent<Light2D>(); 
       Spotlight7.GetComponent<Light2D>(); 
       Spotlight8.GetComponent<Light2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        AnticipationSpotlights();
    }
    public void ChangeColorToNeutralWhite()
    {
       Spotlight1.color = Color.white;
       Spotlight2.color = Color.white;
       Spotlight3.color = Color.white;
       Spotlight4.color = Color.white;
       Spotlight5.color = Color.white;
       Spotlight6.color = Color.white;
       Spotlight7.color = Color.white;
       Spotlight8.color = Color.white;
    }

    public void ChangeColorToRed()
    {
       Spotlight1.color = Color.red;
       Spotlight2.color = Color.red;
       Spotlight3.color = Color.red;
       Spotlight4.color = Color.red;
       Spotlight5.color = Color.red;
       Spotlight6.color = Color.red;
       Spotlight7.color = Color.red;
       Spotlight8.color = Color.red;
    }
    public void ChangeColorToBlue()
    {
       Spotlight1.color = Color.blue;
       Spotlight2.color = Color.blue;
       Spotlight3.color = Color.blue;
       Spotlight4.color = Color.blue;
       Spotlight5.color = Color.blue;
       Spotlight6.color = Color.blue;
       Spotlight7.color = Color.blue;
       Spotlight8.color = Color.blue;
    }
    public void ChangeColorToYellow()
    {
       Spotlight1.color = Color.yellow;
       Spotlight2.color = Color.yellow;
       Spotlight3.color = Color.yellow;
       Spotlight4.color = Color.yellow;
       Spotlight5.color = Color.yellow;
       Spotlight6.color = Color.yellow;
       Spotlight7.color = Color.yellow;
       Spotlight8.color = Color.yellow;
    }
    public void ChangeColorToGreen()
    {
       Spotlight1.color = Color.green;
       Spotlight2.color = Color.green;
       Spotlight3.color = Color.green;
       Spotlight4.color = Color.green;
       Spotlight5.color = Color.green;
       Spotlight6.color = Color.green;
       Spotlight7.color = Color.green;
       Spotlight8.color = Color.green;
    }

    public void AnticipationSpotlights()
    {
       if(activeSpotlights == true && gm.lightsValue3 == 5)
       {
           
           Invoke("ActiveAnticipationSpotlights1", 1f);
           
       }

       if(activeSpotlights == false && gm.lightsValue3 == 5)
       {
           
           Invoke("ActiveAnticipationSpotlights2", 1f);
           
       }
    }

    public void ActiveAnticipationSpotlights1()
    {
         Spotlight2.intensity = 1f;
         Spotlight4.intensity = 1f;
         Spotlight6.intensity = 1f;
         Spotlight8.intensity = 1f;

         Spotlight1.intensity = 0.1f;
         Spotlight3.intensity = 0.1f;
         Spotlight5.intensity = 0.1f;
         Spotlight7.intensity = 0.1f;

         activeSpotlights = false;
    }

    public void ActiveAnticipationSpotlights2()
    {
         Spotlight2.intensity = 0.1f;
         Spotlight4.intensity = 0.1f;
         Spotlight6.intensity = 0.1f;
         Spotlight8.intensity = 0.1f;

         Spotlight1.intensity = 1f;
         Spotlight3.intensity = 1f;
         Spotlight5.intensity = 1f;
         Spotlight7.intensity = 1f;

         activeSpotlights = true;
    }


}