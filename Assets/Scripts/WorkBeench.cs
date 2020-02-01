using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class WorkBeench : MonoBehaviour
{

    public bool clockWasFound;
    public bool sodaWasFound;
    public bool erlenmeyerWasFound;
    public bool doorHandleWasFound;
    public bool pipeWasFound;
    public bool alreadyBuilt;
    public GameObject finishedGlueGun;
    public SteamVR_Action_Boolean buildingAction = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("default", "BuildTheGunAction");
    private bool pressingTrigger;


    // Start is called before the first frame update
    void Start()
    {
        clockWasFound = false;
        sodaWasFound = false;
        erlenmeyerWasFound = false;
        doorHandleWasFound = false;
        pipeWasFound = false;
        alreadyBuilt = false;
    }

    void Update()
    {
        pressingTrigger = buildingAction.stateDown;

        
        if (clockWasFound && sodaWasFound && erlenmeyerWasFound && doorHandleWasFound && pipeWasFound && !alreadyBuilt && pressingTrigger)
        {
            alreadyBuilt = true;
            Instantiate(finishedGlueGun, transform.position, finishedGlueGun.transform.rotation);
        }
    }
}
