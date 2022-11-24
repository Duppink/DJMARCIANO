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
   
   // Funciones de Percusión

    IEnumerator PercOn1()
    {
        while (perc1.volume < 1)
        {
            perc1.volume += Time.deltaTime;
            yield return null;
        }

        while (perc2.volume > 0)
        {
            perc2.volume -= Time.deltaTime;
            yield return null;
        }

        while (perc3.volume > 0)
        {
            perc3.volume -= Time.deltaTime;
            yield return null;
        }

        while (perc4.volume > 0)
        {
            perc4.volume -= Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator PercOn2()
    {
        while (perc2.volume < 1)
        {
            perc2.volume += Time.deltaTime;
            yield return null;
        }

        while (perc1.volume > 0)
        {
            perc1.volume -= Time.deltaTime;
            yield return null;
        }

        while (perc3.volume > 0)
        {
            perc3.volume -= Time.deltaTime;
            yield return null;
        }

        while (perc4.volume > 0)
        {
            perc4.volume -= Time.deltaTime;
            yield return null;
        }
    }

     IEnumerator PercOn3()
    {
        while (perc3.volume < 1)
        {
            perc3.volume += Time.deltaTime;
            yield return null;
        }

        while (perc1.volume > 0)
        {
            perc1.volume -= Time.deltaTime;
            yield return null;
        }

        while (perc2.volume > 0)
        {
            perc2.volume -= Time.deltaTime;
            yield return null;
        }

        while (perc4.volume > 0)
        {
            perc4.volume -= Time.deltaTime;
            yield return null;
        }
    }

     IEnumerator PercOn4()
    {
        while (perc4.volume < 1)
        {
            perc4.volume += Time.deltaTime;
            yield return null;
        }

        while (perc1.volume > 0)
        {
            perc1.volume -= Time.deltaTime;
            yield return null;
        }

        while (perc3.volume > 0)
        {
            perc3.volume -= Time.deltaTime;
            yield return null;
        }

        while (perc2.volume > 0)
        {
            perc2.volume -= Time.deltaTime;
            yield return null;
        }
    }


    // Funciones de Styles
    
    IEnumerator StyleOn1()
    {
        while (style1.volume < 1)
        {
            style1.volume += Time.deltaTime;
            yield return null;
        }        
    }
  

    IEnumerator StyleOff1()
    {
        while (style1.volume > 0)
        {
            style1.volume -= Time.deltaTime;
            yield return null;
        }      
    }

    //

    IEnumerator StyleOn2()
    {
        while (style2.volume < 1)
        {
            style2.volume += Time.deltaTime;
            yield return null;
        }        
    }
  

    IEnumerator StyleOff2()
    {
        while (style2.volume > 0)
        {
            style2.volume -= Time.deltaTime;
            yield return null;
        }      
    }

    //

    IEnumerator StyleOn3()
    {
        while (style3.volume < 1)
        {
            style3.volume += Time.deltaTime;
            yield return null;
        }        
    }
  

    IEnumerator StyleOff3()
    {
        while (style3.volume > 0)
        {
            style3.volume -= Time.deltaTime;
            yield return null;
        }      
    }

    //

    IEnumerator StyleOn4()
    {
        while (style4.volume < 1)
        {
            style4.volume += Time.deltaTime;
            yield return null;
        }        
    }
  

    IEnumerator StyleOff4()
    {
        while (style4.volume > 0)
        {
            style4.volume -= Time.deltaTime;
            yield return null;
        }      
    }

    //

    IEnumerator StyleOn5()
    {
        while (style5.volume < 1)
        {
            style5.volume += Time.deltaTime;
            yield return null;
        }        
    }
  

    IEnumerator StyleOff5()
    {
        while (style5.volume > 0)
        {
            style5.volume -= Time.deltaTime;
            yield return null;
        }      
    }

    //

    IEnumerator StyleOn6()
    {
        while (style6.volume < 1)
        {
            style6.volume += Time.deltaTime;
            yield return null;
        }        
    }
  

    IEnumerator StyleOff6()
    {
        while (style6.volume > 0)
        {
            style6.volume -= Time.deltaTime;
            yield return null;
        }      
    }



}
