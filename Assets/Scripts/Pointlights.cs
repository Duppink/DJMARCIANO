using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Pointlights : MonoBehaviour
{
    public int xcoordinateToMove;
    public int ycoordinateToMove;
    public int zcoordinateToMove;
    public int timeBetweenMove;


    private void Start() 
    {
        MovePointlight();
    }
    public void MovePointlight()
    {
        transform.DOMove(new Vector3(xcoordinateToMove, ycoordinateToMove, zcoordinateToMove), timeBetweenMove).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        
    }
}
