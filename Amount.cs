using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class Amount : MonoBehaviour
{
    public SteamVR_Action_Boolean actionBrake = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("buggy", "Brake");
    public SteamVR_Action_Boolean actionReset = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("buggy", "Reset");

    public Interactable interactable;
    public Text TextObject;
    private int Arrows = 10;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (interactable.attachedToHand)
        {
            SteamVR_Input_Sources hand = interactable.attachedToHand.handType;

            if ((actionBrake.GetState(hand) == true || Input.GetKeyDown("space")) && Arrows > 0)
            {
                Arrows--;
                changeText();
            }

            if (actionReset.GetState(hand) == true)
            {
                Arrows = 10;
            }

        }
    }

    public void changeText()
    {

        TextObject.text = Arrows + "/10";
    }
}





/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amount : MonoBehaviour
{
    public Text TextObject;
    private int Arrows = 10;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetButtonDown("Fire1") || Input.GetKeyDown("space")) && Arrows > 0)
        {
            Arrows--;
            changeText();
            
        }
    }

    public void changeText()
    {

        TextObject.text = Arrows + "/10";
    }
}
*/