using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesStyle2 : MonoBehaviour
{
   public GameManager gm;
    public Sprite styleOn;
    public Sprite styleOff;

    
    void Update()
    {
        if (gm.style2 == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = styleOn;
        }

        if (gm.style2 == false)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = styleOff;
        }
    }
}
