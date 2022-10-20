using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSPLights : MonoBehaviour
{
    public CharactersBehavior cb;

    public Sprite sp0;
    public Sprite sp1;
    public Sprite sp2;
    public Sprite sp3;
    

    // Update is called once per frame
    void Update()
    {

         // Sprites SP Lights

        if (cb.satisfactionLevel == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sp0;
        }

        if (cb.satisfactionLevel == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sp1;
        }

        if (cb.satisfactionLevel == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sp2;
        }

        if (cb.satisfactionLevel == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sp3;
        }      


    }
}
