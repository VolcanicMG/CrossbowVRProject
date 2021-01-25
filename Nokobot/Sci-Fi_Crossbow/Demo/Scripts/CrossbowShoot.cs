using UnityEngine;
using System.Collections;
using Valve.VR;
using Valve.VR.InteractionSystem;

namespace Nokobot.Assets.Crossbow
{
    public class CrossbowShoot : MonoBehaviour
    {
        public SteamVR_Action_Boolean actionBrake = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("buggy", "Brake");
        public SteamVR_Action_Boolean actionReset = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("buggy", "Reset");

        public Interactable interactable;

        public GameObject resetObject;
        private Vector3 originalPos;

        public GameObject arrowPrefab;
        public Transform arrowLocation;

        public float shotPower = 100f;

        public int maxArrows = 10;

        void Start()
        {
            originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

            if (arrowLocation == null)
                arrowLocation = transform;
        }

        void Update()
        {
            if (interactable.attachedToHand)
            {
                SteamVR_Input_Sources hand = interactable.attachedToHand.handType;

                if ((maxArrows == 0 && actionBrake.GetState(hand) == true) || (maxArrows == 0 && Input.GetKeyDown("space")))
                {
                    print("You are out of ammo!");
                }
                else
                {
                    if (actionBrake.GetState(hand) == true || Input.GetKeyDown("space"))
                    {
                        Instantiate(arrowPrefab, arrowLocation.position, arrowLocation.rotation).GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * shotPower);
                        maxArrows--;
                    }
                }
                if(actionReset.GetState(hand) == true)
                {
                    maxArrows = 10;
                    resetObject.transform.position = originalPos;
                }
            }
        }

    }
}





