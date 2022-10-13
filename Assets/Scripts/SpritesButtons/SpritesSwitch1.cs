using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesSwitch1 : MonoBehaviour
{
    public GameManager gm;

    public Sprite leftOn;
    public Sprite rightOn;
    

    // Update is called once per frame
    void Update()
    {
        // Sprites Switches

        if (gm.lightsValue3 == 5)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = leftOn;
        }

        if (gm.lightsValue3 == 6)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = rightOn;
        }
       
    }
}
