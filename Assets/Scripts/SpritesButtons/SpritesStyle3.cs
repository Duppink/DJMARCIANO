using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesStyle3 : MonoBehaviour
{
    public GameManager gm;
    public InteractableButton ib;
    public Sprite styleOn;
    public Sprite styleOff;
    public Sprite buttonDisabled;

    
    void Update()
    {
        if (gm.style3 == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = styleOn;
        }

        if (gm.style3 == false)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = styleOff;
        }
        
        if (ib.enabledButton == false)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = buttonDisabled;
        }

    }
}
