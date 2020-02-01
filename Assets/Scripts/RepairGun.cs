using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class RepairGun : MonoBehaviour
{
    public GameObject projectile;
    public Transform muzzleOffset;

    public SteamVR_Action_Boolean jumpAction = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("platformer", "Jump");

    private SteamVR_Input_Sources hand;
    private Interactable interactable;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interactable.attachedToHand)
        {
            hand = interactable.attachedToHand.handType;
            if(jumpAction[hand].stateDown)
            {
                GameObject o = Instantiate(projectile, muzzleOffset.position, Quaternion.identity);
                o.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward * 10), ForceMode.Impulse);
                audioSource.Play();
            }
        }
    }
}
