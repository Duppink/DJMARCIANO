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
    void Start()
    {
       Spotlight1.GetComponent<Light2D>(); 
       Spotlight2.GetComponent<Light2D>(); 
       Spotlight3.GetComponent<Light2D>(); 
       Spotlight4.GetComponent<Light2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeColorToNeutralWhite()
    {
       Spotlight1.color = Color.white;
       Spotlight2.color = Color.white;
       Spotlight3.color = Color.white;
       Spotlight4.color = Color.white;
    }

    public void ChangeColorToRed()
    {
       Spotlight1.color = Color.red;
       Spotlight2.color = Color.red;
       Spotlight3.color = Color.red;
       Spotlight4.color = Color.red;
    }
    public void ChangeColorToBlue()
    {
       Spotlight1.color = Color.blue;
       Spotlight2.color = Color.blue;
       Spotlight3.color = Color.blue;
       Spotlight4.color = Color.blue;
    }
    public void ChangeColorToYellow()
    {
       Spotlight1.color = Color.yellow;
       Spotlight2.color = Color.yellow;
       Spotlight3.color = Color.yellow;
       Spotlight4.color = Color.yellow;
    }
    public void ChangeColorToGreen()
    {
       Spotlight1.color = Color.green;
       Spotlight2.color = Color.green;
       Spotlight3.color = Color.green;
       Spotlight4.color = Color.green;
    }
}
