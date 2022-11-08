using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableButton : MonoBehaviour
{
    public Button button;    
    public float seconds;
    public GameManager gm;

    public bool enabledButton = false;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().interactable = false;        
    }

    // Update is called once per frame
    void Update()
    {
        if (seconds >= gm.timeSong)
        {
            gameObject.GetComponent<Button>().interactable = true;
            enabledButton = true;
        }
    }
}
