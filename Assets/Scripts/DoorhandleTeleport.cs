using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class DoorhandleTeleport : MonoBehaviour
{
    public Transform boiPlayer;

    private Hand attached;

    public Interactable ayayay;

    public bool canTeleport;

    public float teleportOffset;
    // Start is called before the first frame update
    void Start()
    {
        ayayay = GetComponent<Interactable>();
        boiPlayer = GameObject.Find("BoiPlayer").transform;
    }

    // Update is called once per frame
    void Update()
    {
        attached = ayayay.attachedToHand;
        if(attached && canTeleport)
        {
            TeleportPlayer();
            canTeleport = false;
        }
        if(!attached)
        {
            canTeleport = true;
        }
    }

    void TeleportPlayer()
    {
        boiPlayer.transform.position = new Vector3(boiPlayer.transform.position.x + teleportOffset, boiPlayer.transform.position.y, boiPlayer.transform.position.z);
    }
}