using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Animation : MonoBehaviour
{
    public CharactersBehavior cb;
    public Sprite step01;
    public Sprite step02;
    public Sprite step11;
    public Sprite step12;
    public Sprite step21;
    public Sprite step22;
    public Sprite step31;
    public Sprite step32;    

    
    // Start is called before the first frame update
    void Start()
    {
       
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (cb.satisfactionLevel == 0)
        {
            PlayDance0();
        }

        if (cb.satisfactionLevel == 1)
        {
            PlayDance1();
            transform.DOMoveY(50, 1f).SetEase(Ease.InOutSine).SetLoops(12, LoopType.Yoyo);
        }

        if (cb.satisfactionLevel == 2)
        {
            PlayDance2();
        }

        if (cb.satisfactionLevel == 3)
        {
            PlayDance3();
        }
        
    }


    public void PlayDance0() // Funciones para los pasos de satisfacción 0
    {
        if (gameObject.GetComponent<SpriteRenderer>().sprite == step01)
        {
            Invoke("PlayStep02",1f);
        }
        if (gameObject.GetComponent<SpriteRenderer>().sprite == step02)
        {
            Invoke("PlayStep01",1f);
        }
        if (gameObject.GetComponent<SpriteRenderer>().sprite != step02 && gameObject.GetComponent<SpriteRenderer>().sprite != step01)
        {
            Invoke("PlayStep01",1f);
        }        
    }

    public void PlayStep01()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = step01;
    }

    public void PlayStep02()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = step02;
    }
   


    public void PlayDance1() // Funciones para los pasos de satisfacción 1
    {
        if (gameObject.GetComponent<SpriteRenderer>().sprite == step11)
        {
            Invoke("PlayStep12",1f);
        }
        if (gameObject.GetComponent<SpriteRenderer>().sprite == step12)
        {
            Invoke("PlayStep11",1f);
        }
        if (gameObject.GetComponent<SpriteRenderer>().sprite != step12 && gameObject.GetComponent<SpriteRenderer>().sprite != step11)
        {
            Invoke("PlayStep11",1f);
        }            
    }

    public void PlayStep11()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = step11;
    }

    public void PlayStep12()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = step12;
    }

    public void PlayDance2() // Funciones para los pasos de satisfacción 2
    {
        if (gameObject.GetComponent<SpriteRenderer>().sprite == step21)
        {
            Invoke("PlayStep22",1f);
        }
        if (gameObject.GetComponent<SpriteRenderer>().sprite == step22)
        {
            Invoke("PlayStep21",1f);
        }
        if (gameObject.GetComponent<SpriteRenderer>().sprite != step22 && gameObject.GetComponent<SpriteRenderer>().sprite != step21)
        {
            Invoke("PlayStep21",1f);
        }            
    }

    public void PlayStep21()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = step21;
    }

    public void PlayStep22()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = step22;
    }

    public void PlayDance3() // Funciones para los pasos de satisfacción 3
    {
        if (gameObject.GetComponent<SpriteRenderer>().sprite == step31)
        {
            Invoke("PlayStep32",1f);
        }
        if (gameObject.GetComponent<SpriteRenderer>().sprite == step32)
        {
            Invoke("PlayStep31",1f);
        }
        if (gameObject.GetComponent<SpriteRenderer>().sprite != step32 && gameObject.GetComponent<SpriteRenderer>().sprite != step31)
        {
            Invoke("PlayStep31",1f);
        }            
    }

    public void PlayStep31()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = step31;
    }

    public void PlayStep32()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = step32;
    }
}
