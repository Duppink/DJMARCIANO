using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesLightsColors : MonoBehaviour
{
    public GameManager gm;

    public Sprite lights0;
    public Sprite lights1;
    public Sprite lights2;
    public Sprite lights3;
    public Sprite lights4;

    
    void Update()
    {
        // Sprites Colors Lights

        if (gm.lightsValue1 == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = lights0;
        }

        if (gm.lightsValue1 == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = lights1;
        }

        if (gm.lightsValue1 == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = lights2;
        }

        if (gm.lightsValue1 == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = lights3;
        }

        if (gm.lightsValue1 == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = lights4;
        }

        
    }
}
