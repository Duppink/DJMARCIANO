using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource perc1;
    public AudioSource perc2;
    public AudioSource perc3;
    public AudioSource perc4;
    public AudioSource style1;
    public AudioSource style2;
    public AudioSource style3;
    public AudioSource style4;
    public AudioSource style5;
    public AudioSource style6;

    
    private void Start()
    {
        perc1.volume = 10;
        perc2.volume = 0;
        perc3.volume = 0;
        perc4.volume = 0;

        style1.volume = 0;
        style2.volume = 0;
        style3.volume = 0;
        style4.volume = 0;
        style5.volume = 0;
        style6.volume = 0;
    }


    // Funciones de Percusiones
    public void Perc1On()
    {
        perc1.volume = 10;
        perc2.volume = 0;
        perc3.volume = 0;
        perc4.volume = 0;
    }

    public void Perc2On()
    {
        perc1.volume = 0;
        perc2.volume = 10;
        perc3.volume = 0;
        perc4.volume = 0;
    }

    public void Perc3On()
    {
        perc1.volume = 0;
        perc2.volume = 0;
        perc3.volume = 10;
        perc4.volume = 0;
    }

    public void Perc4On()
    {
        perc1.volume = 0;
        perc2.volume = 0;
        perc3.volume = 0;
        perc4.volume = 10;
    }
}
