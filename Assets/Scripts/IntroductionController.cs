using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionController : MonoBehaviour
{
    public int currentPage;
    public int currentDrawings;
    public GameSceneManager gsm;
    
    [Header("Drawings")]
    public GameObject drawing01;
    public GameObject drawing02;
    public GameObject drawing03;
    public GameObject drawing04;
    public GameObject drawing05;
    public GameObject drawing06;
    public GameObject drawing07;
    public GameObject drawing08;
    public GameObject drawing09;
    public GameObject drawing10;
    public GameObject drawing11;
    public GameObject drawing12;
    public GameObject drawing13;
    public GameObject drawing14;
    public GameObject drawing15;
    public GameObject drawing16;
    public GameObject drawing17;
    public GameObject drawing18;
    public GameObject drawing19;
    public GameObject drawing20;
    public GameObject drawing21;
    public GameObject drawing22;
    public GameObject drawing23;
    public GameObject drawing24;
    public GameObject drawing25;
    public GameObject drawing26;


    public void ChangeDrawing ()
    {
       if (currentPage == 1)
       {
            if(currentDrawings == 0)
            {
                drawing01.SetActive(true);
                currentDrawings = 1;
                return;
            }
            if(currentDrawings == 1)
            {
                drawing02.SetActive(true);
                currentDrawings = 2;
                return;
            }
            if(currentDrawings == 2)
            {
                drawing03.SetActive(true);
                currentDrawings = 3;
                return;
            }
            if(currentDrawings == 3)
            {
                drawing04.SetActive(true);
                currentDrawings = 4;
                return;
            }
            if(currentDrawings == 4)
            {
                drawing01.SetActive(false);
                drawing02.SetActive(false);
                drawing03.SetActive(false);
                drawing04.SetActive(false);
                currentDrawings = 0;
                currentPage = 2;
                return;
            }
       }

       if (currentPage == 2)
       {
            if(currentDrawings == 0)
            {
                drawing05.SetActive(true);
                currentDrawings = 1;
                return;
            }
            if(currentDrawings == 1)
            {
                drawing06.SetActive(true);
                currentDrawings = 2;
                return;
            }
            if(currentDrawings == 2)
            {
                drawing05.SetActive(false);
                drawing06.SetActive(false);
                currentDrawings = 0;
                currentPage = 3;
                return;
            }
            
       }

       if (currentPage == 3)
       {
            if(currentDrawings == 0)
            {
                drawing07.SetActive(true);
                currentDrawings = 1;
                return;
            }
            if(currentDrawings == 1)
            {
                drawing08.SetActive(true);
                currentDrawings = 2;
                return;
            }
            if(currentDrawings == 2)
            {
                drawing09.SetActive(true);
                currentDrawings = 3;
                return;
            }
            if(currentDrawings == 3)
            {
                drawing07.SetActive(false);
                drawing08.SetActive(false);
                drawing09.SetActive(false);
                currentDrawings = 0;
                currentPage = 4;
                return;
            }
       }

       if (currentPage == 4)
       {
            if(currentDrawings == 0)
            {
                drawing10.SetActive(true);
                currentDrawings = 1;
                return;
            }
            if(currentDrawings == 1)
            {
                drawing11.SetActive(true);
                currentDrawings = 2;
                return;
            }
            if(currentDrawings == 2)
            {
                drawing12.SetActive(true);
                currentDrawings = 3;
                return;
            }
            if(currentDrawings == 3)
            {
                drawing10.SetActive(false);
                drawing11.SetActive(false);
                drawing12.SetActive(false);
                currentDrawings = 0;
                currentPage = 5;
                return;
            }
       }

       if (currentPage == 5)
       {
            if(currentDrawings == 0)
            {
                drawing13.SetActive(true);
                currentDrawings = 1;
                return;
            }
            if(currentDrawings == 1)
            {
                drawing13.SetActive(false);
                currentDrawings = 0;
                currentPage = 6;
                return;
            }
       }

       if (currentPage == 6)
       {
            if(currentDrawings == 0)
            {
                drawing14.SetActive(true);
                currentDrawings = 1;
                return;
            }
            if(currentDrawings == 1)
            {
                drawing14.SetActive(false);
                currentDrawings = 0;
                currentPage = 7;
                return;
            }
       }

       if (currentPage == 7)
       {
            if(currentDrawings == 0)
            {
                drawing15.SetActive(true);
                currentDrawings = 1;
                return;
            }
            if(currentDrawings == 1)
            {
                drawing16.SetActive(true);
                currentDrawings = 2;
                return;
            }
            if(currentDrawings == 2)
            {
                drawing17.SetActive(true);
                currentDrawings = 3;
                return;
            }
            if(currentDrawings == 3)
            {
                drawing18.SetActive(true);
                currentDrawings = 4;
                return;
            }
            if(currentDrawings == 4)
            {
                drawing19.SetActive(true);
                currentDrawings = 5;
                return;
            }
            if(currentDrawings == 5)
            {
                drawing15.SetActive(false);
                drawing16.SetActive(false);
                drawing17.SetActive(false);
                drawing18.SetActive(false);
                drawing19.SetActive(false);
                currentDrawings = 0;
                currentPage = 8;
                return;
            }
       }

       if (currentPage == 8)
       {
            if(currentDrawings == 0)
            {
                drawing20.SetActive(true);
                currentDrawings = 1;
                return;
            }
            if(currentDrawings == 1)
            {
                drawing21.SetActive(true);
                currentDrawings = 2;
                return;
            }
            if(currentDrawings == 2)
            {
                drawing22.SetActive(true);
                currentDrawings = 3;
                return;
            }
            if(currentDrawings == 3)
            {
                drawing23.SetActive(true);
                currentDrawings = 4;
                return;
            }
            if(currentDrawings == 4)
            {
                drawing24.SetActive(true);
                currentDrawings = 5;
                return;
            }
            if(currentDrawings == 5)
            {
                drawing25.SetActive(true);
                currentDrawings = 6;
                return;
            }
            if(currentDrawings == 6)
            {
                drawing26.SetActive(true);
                currentDrawings = 7;
                return;
            }
            if(currentDrawings == 7)
            {
                gsm.GoToBriefing();
                /*drawing20.SetActive(false);
                drawing21.SetActive(false);
                drawing22.SetActive(false);
                drawing23.SetActive(false);
                drawing24.SetActive(false);
                drawing25.SetActive(false);
                drawing26.SetActive(false);
                currentDrawings = 0;
                currentPage = 8;*/
                return;
            }
       }
    }
}
