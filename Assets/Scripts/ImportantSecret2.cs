using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantSecret2 : MonoBehaviour
{
    public CharactersBehavior cb;
    public GameManager gm;
    public int SP; 
    public int Stage;
    public int identificadorMensaje;

    public void CheckForImportantMessage()
    {
        if(gm.stage == Stage && cb.satisfactionLevel == SP)
        {
           gm.identificador = identificadorMensaje;
        }
    }   
}
