using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritesPercussion : MonoBehaviour
{
    public GameManager gm;

    public Sprite perc1;
    public Sprite perc2;
    public Sprite perc3;
    public Sprite perc4;

    // Update is called once per frame
    void Update()
    {
        // Sprites Percussion

        if (gm.percussionSelected == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = perc1;
        }

        if (gm.percussionSelected == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = perc2;
        }

        if (gm.percussionSelected == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = perc3;
        }

        if (gm.percussionSelected == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = perc4;
        }
    }


}
