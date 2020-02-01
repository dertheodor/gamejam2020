using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class WorkBeench : MonoBehaviour
{
    public GameObject checkmark; // our checkmark prefab

    public bool clockWasFound;
    public bool sodaWasFound;
    public bool erlenmeyerWasFound;
    public bool doorHandleWasFound;
    public bool pipeWasFound;
    /*public bool batteryWasFound;
    public bool prismWasFound;
    public bool potWasFound;
    public bool cableWasFound;*/

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
        /*batteryWasFound = false;
        prismWasFound = false;
        potWasFound = false;
        cableWasFound = false;*/

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

        if (clockWasFound)
        {
            GameObject checkmark = Instantiate(checkmark, checkmark.position);
            checkmark.transform.position + new Vector3(17.854f, 0, 1.511f);
        }

        if (sodaWasFound)
        {
            GameObject checkmark = Instantiate(checkmark, checkmark.position);
            checkmark.transform.position + new Vector3(18.3446f, 0, 1.3818f);
        }

        if (erlenmeyerWasFound)
        {
            GameObject checkmark = Instantiate(checkmark, checkmark.position);
            checkmark.transform.position + new Vector3(18.0409f, 0, 1.4707f);
        }

        if (doorHandleWasFound)
        {
            GameObject checkmark = Instantiate(checkmark, checkmark.position);
            checkmark.transform.position + new Vector3(17.7911f, 0, 1.0704f);
        }

        if (pipeWasFound)
        {
            GameObject checkmark = Instantiate(checkmark, checkmark.position);
            checkmark.transform.position + new Vector3(17.8435f, 0, 1.3742f);
        }
        /*
        if (prismWasFound)
        {
            GameObject checkmark = Instantiate(checkmark, checkmark.position);
            checkmark.transform.position + new Vector3(17.6937f, 0, 1.2254f);
        }

        if (potWasFound)
        {
            GameObject checkmark = Instantiate(checkmark, checkmark.position);
            checkmark.transform.position + new Vector3(17.9772f, 0, 1.1956f);
        }

        if (cableWasFound)
        {
            GameObject checkmark = Instantiate(checkmark, checkmark.position);
            checkmark.transform.position + new Vector3(18.3484f, 0, 1.391f);
        }
        */
        if (clockWasFound && sodaWasFound && erlenmeyerWasFound && doorHandleWasFound && pipeWasFound)
        {
            alreadyBuilt = true;
            SpawnGun();
            
        }
    }

    void spawnGun()
    {

    }
}
