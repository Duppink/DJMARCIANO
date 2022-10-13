using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesStyle5 : MonoBehaviour
{
    public GameManager gm;
    public Sprite styleOn;
    public Sprite styleOff;

    
    void Update()
    {
        if (gm.style5 == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = styleOn;
        }

        if (gm.style5 == false)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = styleOff;
        }
    }
}
