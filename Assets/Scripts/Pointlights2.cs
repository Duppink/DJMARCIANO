using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Pointlights2 : MonoBehaviour
{
    public PathType pathsystem = PathType.CatmullRom;
    public Vector3[] pathval = new Vector3[4];


    private void Start() 
    {
        MovePointlight2();
    }
    public void MovePointlight2()
    {
        transform.DOPath(pathval, 5, pathsystem).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        
    }
}
