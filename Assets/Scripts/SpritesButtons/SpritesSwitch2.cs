using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesSwitch2 : MonoBehaviour
{
    public GameManager gm;
    public InteractableButton ib;

    public Sprite leftOn;
    public Sprite rightOn;
    public Sprite neutro;

    public Sprite buttonDisabled;
    

    // Update is called once per frame
    void Update()
    {
        // Sprites Switches

        if (gm.lightsValue4 == 7)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = leftOn;
        }

        if (gm.lightsValue4 == 8)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = rightOn;
        }

        if (gm.lightsValue4 == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = neutro;
        }

        if (ib.enabledButton == false)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = buttonDisabled;
        }
       
    }
}
