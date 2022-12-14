using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotImportantSecret : MonoBehaviour
{
    public GameManager gm;
    public int identificadorMensaje;

    public void CheckForNotImportantMessage()
    {
        gm.identificador = identificadorMensaje;
    }
}
