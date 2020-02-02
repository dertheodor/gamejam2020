using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorhandleTeleport : MonoBehaviour
{
    public Transform vaseRoom1;
    public Transform kitchenRoom2;
    public Transform workBenchRoom3;

    public float teleportOffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TeleportPlayer()
    {
        vaseRoom1.transform.position = new Vector3(vaseRoom1.transform.position.x + teleportOffset, vaseRoom1.transform.position.y, vaseRoom1.transform.position.z);
        kitchenRoom2.transform.position = new Vector3(kitchenRoom2.transform.position.x + teleportOffset, kitchenRoom2.transform.position.y, kitchenRoom2.transform.position.z);
        workBenchRoom3.transform.position = new Vector3(workBenchRoom3.transform.position.x + teleportOffset, workBenchRoom3.transform.position.y, workBenchRoom3.transform.position.z);
    }
}