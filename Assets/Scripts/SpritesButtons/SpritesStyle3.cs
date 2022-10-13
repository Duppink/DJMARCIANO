using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesStyle3 : MonoBehaviour
{
    public GameManager gm;
    public Sprite styleOn;
    public Sprite styleOff;

    
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
    }
}
