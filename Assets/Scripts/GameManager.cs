using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{   
    [Header("Scripts")]
    public AudioManager am;
    public LightsController lc;

    [Header("Characters")]
    public CharactersBehavior cb1;      // Referencia al script CharacterBehavior contenido por el GameObject del personaje correspondiente.
    public CharactersBehavior cb2;      // Referencia al script CharacterBehavior contenido por el GameObject del personaje correspondiente.
    public CharactersBehavior cb3;      // Referencia al script CharacterBehavior contenido por el GameObject del personaje correspondiente.
    public CharactersBehavior cb4;      // Referencia al script CharacterBehavior contenido por el GameObject del personaje correspondiente.
    public CharactersBehavior cb5;      // Referencia al script CharacterBehavior contenido por el GameObject del personaje correspondiente.
    public CharactersBehavior cb6;      // Referencia al script CharacterBehavior contenido por el GameObject del personaje correspondiente.
    public CharactersBehavior cb7;      // Referencia al script CharacterBehavior contenido por el GameObject del personaje correspondiente.
    public CharactersBehavior cb8;      // Referencia al script CharacterBehavior contenido por el GameObject del personaje correspondiente.

    [Header("Percussion Buttons")]
    public Button[] percussion;     // Referencia a los botones de la mesa de DJ relacionados a la percusión.
    [Header("Style Buttons")]
    public Button[] style;      // Referencia a los botones de la mesa de DJ relacionados al estilo.
    [Header("Lights Buttons")]
    public Button[] lights;     // Referencia a los botones de la mesa de DJ relacionados a las luces.
  
    [Header("Selected Percusion")]
    public int percussionSelected = 1;      // Variable que contiene el valor de la percusión seleccionada.

    [Header("Selected Style")]
    public bool style1 = false;     // Variable que contiene si el estilo 1 está activado o desactivado.
    public bool style2 = false;     // Variable que contiene si el estilo 2 está activado o desactivado.
    public bool style3 = false;     // Variable que contiene si el estilo 3 está activado o desactivado.
    public bool style4 = false;     // Variable que contiene si el estilo 4 está activado o desactivado.
    public bool style5 = false;     // Variable que contiene si el estilo 5 está activado o desactivado.
    public bool style6 = false;     // Variable que contiene si el estilo 6 está activado o desactivado.
    public int currentStyle = 0;        // Variable que contiene el estilo actual seleccionado.
    public int lastStyle = 0;       // Variable que contiene el penúltimo estilo seleccionado.
    public int stylesSelected = 0;      // Variable que contiene la cantidad de estilos seleccionados.

    [Header("Selected Lights")]
    public int lightsValue1 = 0;        // [alegría - tristeza] Variable que contiene los valores de la perilla para controlar la luz 1. 
    public int lightsValue2 = 0;        // [confianza - aversión] Variable que contiene los valores de la perilla para controlar la luz 2.
    public int lightsValue3 = 0;        // [anticipación - sorpresa] Variable que contiene los valores de la perilla para controlar la luz 3.
    public int lightsValue4 = 0;        // [ira - miedo] Variable que contiene los valores de la perilla para controlar la luz 4.
        
    [Header("Relationship Secrets")]
    public bool ParkourBoy_Friend_ArtChic;
    public bool ParkourBoy_Love_PopularGirl;
    public bool Sport_Friend_ClassPresident;
    public bool Sport_Love_BandMember;
    public bool Stoner_Friend_Esoteric;
    public bool Stoner_Friend_Sport;
    public bool PopularGirl_Friend_ClassPresident;
    public bool PopularGirl_Love_ArtChic;
    public bool BandMember_Friend_PopularGirl;
    public bool BandMember_Love_Sport;
    public bool ArtChic_Friend_ParkourBoy;
    public bool ArtChic_Love_PopularGirl;
    public bool ClassPresident_Friend_PopularGirl;
    public bool ClassPresident_Friend_Sport;
    public bool Esoteric_Friend_ArtChic;
    public bool Esoteric_Love_Stoner;

    [Header("Mision Secrets")]
    public bool Mision1_Meteoro;
    public bool Mision2_AgujeroNegro;
    public bool Mision3_UFO;

    [Header("Time Text")]
    public TextMeshProUGUI tiempo;
    private int timetotext;
    

    [Header("Modifiable Times")]
    public float timeSong;    
    public float timeLeftToStage2;
    public float timeLeftToStage3;

    [Header("Actual Stage")]
    public int stage = 1;


    void Update()
    {
        timeSong = timeSong - 1 * Time.deltaTime;        
        timetotext = (int)timeSong;
        tiempo.text = timetotext.ToString();

        if (timeLeftToStage2 >= timeSong)
        {
            stage = 2;
        } 

        if (timeLeftToStage3 >= timeSong)
        {
            stage = 3;
        } 
    }


    //PercussionSelected
    public void PercussionSelected1()       // Función que determina que se ha seleccionado la percusión 1.
    {
        percussionSelected = 1;
        am.Perc1On(); // AUDIO

        cb1.FavPerc();
        cb2.FavPerc();
        cb3.FavPerc();
        cb4.FavPerc();
        cb5.FavPerc();
        cb6.FavPerc();
        cb7.FavPerc();
        cb8.FavPerc();

    }

    public void PercussionSelected2()       // Función que determina que se ha seleccionado la percusión 2.
    {
        percussionSelected = 2;
        am.Perc2On(); // AUDIO

        cb1.FavPerc();
        cb2.FavPerc();
        cb3.FavPerc();
        cb4.FavPerc();
        cb5.FavPerc();
        cb6.FavPerc();
        cb7.FavPerc();
        cb8.FavPerc();
    }

    public void PercussionSelected3()       // Función que determina que se ha seleccionado la percusión 3.
    {
        percussionSelected = 3;
        am.Perc3On(); // AUDIO

        cb1.FavPerc();
        cb2.FavPerc();
        cb3.FavPerc();
        cb4.FavPerc();
        cb5.FavPerc();
        cb6.FavPerc();
        cb7.FavPerc();
        cb8.FavPerc();
    }
    public void PercussionSelected4()       // Función que determina que se ha seleccionado la percusión 4.
    {
        percussionSelected = 4;
        am.Perc4On(); // AUDIO

        cb1.FavPerc();
        cb2.FavPerc();
        cb3.FavPerc();
        cb4.FavPerc();
        cb5.FavPerc();
        cb6.FavPerc();
        cb7.FavPerc();
        cb8.FavPerc();
    }


    //StyleSelected
    public void ClickOnStyle1()     // Función que determina que se ha apretado el botón de estilo 1.

    {
        if (stylesSelected <= 1 && style1 == false)
        
        {
            style1 = true;
            am.Style1On(); // AUDIO
            
            if (currentStyle != 0) 
            {
                lastStyle = currentStyle;
            }             
         
            currentStyle = 1;

            stylesSelected = stylesSelected + 1;

            cb1.FavSty();
            cb2.FavSty();
            cb3.FavSty();
            cb4.FavSty();
            cb5.FavSty();
            cb6.FavSty();
            cb7.FavSty();
            cb8.FavSty();            
        }

        else
        {
            if (style1 == true)

            {
                stylesSelected = stylesSelected - 1;
                style1 = false;
                am.Style1Off(); // AUDIO

                if (currentStyle == 1) 
                
                {
                    currentStyle = 0;
                } 

                if (lastStyle == 1) 
                
                {
                    lastStyle = 0;
                }

                cb1.FavSty();
                cb2.FavSty();
                cb3.FavSty();
                cb4.FavSty();
                cb5.FavSty();
                cb6.FavSty();
                cb7.FavSty();
                cb8.FavSty(); 
                                              
            }
            
        }
        
    }


    public void ClickOnStyle2()     // Función que determina que se ha apretado el botón de estilo 2.

    {
        if (stylesSelected <= 1 && style2 == false)
        
        {
            style2 = true;
            am.Style2On(); // AUDIO

            if (currentStyle != 0) 
            {
                lastStyle = currentStyle;
            } 

            currentStyle = 2;            
            stylesSelected = stylesSelected + 1;    

            cb1.FavSty();
            cb2.FavSty();
            cb3.FavSty();
            cb4.FavSty();
            cb5.FavSty();
            cb6.FavSty();
            cb7.FavSty();
            cb8.FavSty();         
        }

        else
        {
            if (style2 == true)

            {
                stylesSelected = stylesSelected - 1;
                style2 = false;
                am.Style2Off(); // AUDIO  

                if (currentStyle == 2) 
                
                {
                    currentStyle = 0;
                }  

                if (lastStyle == 2) 
                
                {
                    lastStyle = 0;
                }

                cb1.FavSty();
                cb2.FavSty();
                cb3.FavSty();
                cb4.FavSty();
                cb5.FavSty();
                cb6.FavSty();
                cb7.FavSty();
                cb8.FavSty();           
            }
           
            
        }
    }

    public void ClickOnStyle3()     // Función que determina que se ha apretado el botón de estilo 3.     

    {
        if (stylesSelected <= 1 && style3 == false)
        
        {
            style3 = true;
            am.Style3On(); // AUDIO

            if (currentStyle != 0) 
            {
                lastStyle = currentStyle;
            } 

            currentStyle = 3;
            stylesSelected = stylesSelected + 1;

            cb1.FavSty();
            cb2.FavSty();
            cb3.FavSty();
            cb4.FavSty();
            cb5.FavSty();
            cb6.FavSty();
            cb7.FavSty();
            cb8.FavSty();
                        
        }

        else
        {
            if (style3 == true)

            {
                stylesSelected = stylesSelected - 1;
                style3 = false;
                am.Style3Off(); // AUDIO

                if (currentStyle == 3) 
                
                {
                    currentStyle = 0;
                } 

                if (lastStyle == 3) 
                
                {
                    lastStyle = 0;
                }
                
                cb1.FavSty();
                cb2.FavSty();
                cb3.FavSty();
                cb4.FavSty();
                cb5.FavSty();
                cb6.FavSty();
                cb7.FavSty();
                cb8.FavSty(); 
            }
            
            
        }
    }

    public void ClickOnStyle4()     // Función que determina que se ha apretado el botón de estilo 4.

    {
        if (stylesSelected <= 1 && style4 == false)
        
        {
            style4 = true;
            am.Style4On(); // AUDIO

            if (currentStyle != 0) 
            {
                lastStyle = currentStyle;
            } 

            currentStyle = 4;
            stylesSelected = stylesSelected + 1;

            cb1.FavSty();
            cb2.FavSty();
            cb3.FavSty();
            cb4.FavSty();
            cb5.FavSty();
            cb6.FavSty();
            cb7.FavSty();
            cb8.FavSty();             
        }

        else
        {
            if (style4 == true)

            {
                stylesSelected = stylesSelected - 1;
                style4 = false;
                am.Style4Off(); // AUDIO

                if (currentStyle == 4) 
                
                {
                    currentStyle = 0;
                } 

                if (lastStyle == 4) 
                
                {
                    lastStyle = 0;
                }

                cb1.FavSty();
                cb2.FavSty();
                cb3.FavSty();
                cb4.FavSty();
                cb5.FavSty();
                cb6.FavSty();
                cb7.FavSty();
                cb8.FavSty(); 

            }
            
        }
    }

    public void ClickOnStyle5()     // Función que determina que se ha apretado el botón de estilo 5.

    {
        if (stylesSelected <= 1 && style5 == false)
        
        {
            style5 = true;
            am.Style5On(); // AUDIO

            if (currentStyle != 0) 
            {
                lastStyle = currentStyle;
            } 

            currentStyle = 5;
            stylesSelected = stylesSelected + 1;

            cb1.FavSty();
            cb2.FavSty();
            cb3.FavSty();
            cb4.FavSty();
            cb5.FavSty();
            cb6.FavSty();
            cb7.FavSty();
            cb8.FavSty();             
        }

        else
        {
            if (style5 == true)

            {
                stylesSelected = stylesSelected - 1;
                style5 = false;
                am.Style5Off(); // AUDIO

                if (currentStyle == 5) 
                
                {
                    currentStyle = 0;
                } 

                if (lastStyle == 5) 
                
                {
                    lastStyle = 0;
                }

                cb1.FavSty();
                cb2.FavSty();
                cb3.FavSty();
                cb4.FavSty();
                cb5.FavSty();
                cb6.FavSty();
                cb7.FavSty();
                cb8.FavSty(); 
            }
            
        }
    }

    public void ClickOnStyle6()     // Función que determina que se ha apretado el botón de estilo 6.

    {
        if (stylesSelected <= 1 && style6 == false)
        
        {
            style6 = true;
            am.Style6On(); // AUDIO

            if (currentStyle != 0) 
            {
                lastStyle = currentStyle;
            } 

            currentStyle = 6;
            stylesSelected = stylesSelected + 1;

            cb1.FavSty();
            cb2.FavSty();
            cb3.FavSty();
            cb4.FavSty();
            cb5.FavSty();
            cb6.FavSty();
            cb7.FavSty();
            cb8.FavSty();            
        }

        else
        {
            if (style6 == true)

            {
                stylesSelected = stylesSelected - 1;
                style6 = false;
                am.Style6Off(); // AUDIO

                if (currentStyle == 6) 
                
                {
                    currentStyle = 0;
                } 

                if (lastStyle == 6) 
                
                {
                    lastStyle = 0;
                }

                cb1.FavSty();
                cb2.FavSty();
                cb3.FavSty();
                cb4.FavSty();
                cb5.FavSty();
                cb6.FavSty();
                cb7.FavSty();
                cb8.FavSty(); 
            }
            
            
        }
    }

    //Lights

    public void ClickOnLights1()        // Función que determina que se ha girado la perilla de luz 1.
    {
        if (lightsValue1 == 4) 
        {
            lightsValue1 = 0;

            cb1.FavLig();
            cb2.FavLig();
            cb3.FavLig();
            cb4.FavLig();
            cb5.FavLig();
            cb6.FavLig();
            cb7.FavLig();
            cb8.FavLig();
            lc.ChangeColorToNeutralWhite();
            return;
        }

        if (lightsValue1 == 3) 
        {
            lightsValue1 = 4;

            cb1.FavLig();
            cb2.FavLig();
            cb3.FavLig();
            cb4.FavLig();
            cb5.FavLig();
            cb6.FavLig();
            cb7.FavLig();
            cb8.FavLig();
            lc.ChangeColorToGreen();
            return;
        }

        if (lightsValue1 == 2) 
        {
            lightsValue1 = 3;

            cb1.FavLig();
            cb2.FavLig();
            cb3.FavLig();
            cb4.FavLig();
            cb5.FavLig();
            cb6.FavLig();
            cb7.FavLig();
            cb8.FavLig();
            lc.ChangeColorToYellow();
            return;
        }
        
        if (lightsValue1 == 1) 
        {
            lightsValue1 = 2;

            cb1.FavLig();
            cb2.FavLig();
            cb3.FavLig();
            cb4.FavLig();
            cb5.FavLig();
            cb6.FavLig();
            cb7.FavLig();
            cb8.FavLig();
            lc.ChangeColorToBlue();
            return;
        }

        if (lightsValue1 == 0) 
        {
            lightsValue1 = 1;

            cb1.FavLig();
            cb2.FavLig();
            cb3.FavLig();
            cb4.FavLig();
            cb5.FavLig();
            cb6.FavLig();
            cb7.FavLig();
            cb8.FavLig();
            lc.ChangeColorToRed();
            return;
        
        }

        

        

        

        

        /*else 
        {           

            if (lightsValue1 == -1) 
            {
                lightsValue1 = 0;
                lc.ChangeColorToNeutralWhite();
            }

            if (lightsValue1 == 1) 
            {
                lightsValue1 = -1;
                lc.ChangeColorToBlue();
            }

            cb1.FavLig();
            cb2.FavLig();
            cb3.FavLig();
            cb4.FavLig();
            cb5.FavLig();
            cb6.FavLig();
            cb7.FavLig();
            cb8.FavLig();
            
        } */

         
                
    }

    /*public void ClickOnLights2()        // Función que determina que se ha girado la perilla de luz 2.
    {
        if (lightsValue2 == 0) 
        {
            lightsValue2 = 2;

            cb1.FavLig();
            cb2.FavLig();
            cb3.FavLig();
            cb4.FavLig();
            cb5.FavLig();
            cb6.FavLig();
            cb7.FavLig();
            cb8.FavLig();
        }

        else 
        {           

            if (lightsValue2 == -2) 
            {
                lightsValue2 = 0;
            }

            if (lightsValue2 == 2) 
            {
                lightsValue2 = -2;
            }

            cb1.FavLig();
            cb2.FavLig();
            cb3.FavLig();
            cb4.FavLig();
            cb5.FavLig();
            cb6.FavLig();
            cb7.FavLig();
            cb8.FavLig();
        }
        
                
    }*/

    public void ClickOnLights3()        // Función que determina que se ha girado la perilla de luz 3.
    {
        if (lightsValue3 == 0) 
        {
            lightsValue3 = 5;

            cb1.FavLig();
            cb2.FavLig();
            cb3.FavLig();
            cb4.FavLig();
            cb5.FavLig();
            cb6.FavLig();
            cb7.FavLig();
            cb8.FavLig();
        }

        else 
        {           

            if (lightsValue3 == 6) 
            {
                lightsValue3 = 0;
            }

            if (lightsValue3 == 5) 
            {
                lightsValue3 = 6;
            }

            cb1.FavLig();
            cb2.FavLig();
            cb3.FavLig();
            cb4.FavLig();
            cb5.FavLig();
            cb6.FavLig();
            cb7.FavLig();
            cb8.FavLig();
        }   
                
    }

    public void ClickOnLights4()        // Función que determina que se ha girado la perilla de luz 4.
    {
        if (lightsValue4 == 0) 
        {
            lightsValue4 = 7;

            cb1.FavLig();
            cb2.FavLig();
            cb3.FavLig();
            cb4.FavLig();
            cb5.FavLig();
            cb6.FavLig();
            cb7.FavLig();
            cb8.FavLig();
        }

        else 
        {           

            if (lightsValue4 == 8) 
            {
                lightsValue4 = 0;
            }

            if (lightsValue4 == 7) 
            {
                lightsValue4 = 8;
            }

            cb1.FavLig();
            cb2.FavLig();
            cb3.FavLig();
            cb4.FavLig();
            cb5.FavLig();
            cb6.FavLig();
            cb7.FavLig();
            cb8.FavLig(); 
        }   
                
    }

}
