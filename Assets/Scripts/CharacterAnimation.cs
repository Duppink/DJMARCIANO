using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CharacterAnimation : MonoBehaviour
{
    public Animator characterAnimator;
    public CharactersBehavior characterImage;
    public GameManager gm;
    private void Awake() 
   {
        characterAnimator = GetComponent<Animator>();
   }

    private void Update()
    {
        characterAnimator.SetInteger("Stage", gm.stage);
        characterAnimator.SetInteger("SatisfactionLevel", characterImage.satisfactionLevel);
    }

}
