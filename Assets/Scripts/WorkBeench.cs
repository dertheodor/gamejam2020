using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class WorkBeench : MonoBehaviour
{
    public GameObject Checkmark; // our checkmark prefab

    public bool clockWasFound;
    public bool clockAlreadyBuilt;
    public bool sodaWasFound;
    public bool sodaAlreadyBuilt;
    public bool erlenmeyerWasFound;
    public bool erlenmeyerAlreadyBuilt;
    public bool doorHandleWasFound;
    public bool doorHandleAlreadyBuilt;
    public bool pipeWasFound;
    public bool pipeAlreadyBuilt;
    public bool batteryWasFound;
    public bool batteryWasBuilt;
    public bool prismWasFound;
    public bool prismAlreadyBuilt;
    public bool potWasFound;
    public bool potAlreadyBuilt;
    public bool cableWasFound;
    public bool cableAlreadyBuilt;

    public bool alreadyBuilt;
    public SteamVR_Action_Boolean buildingAction = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("default", "BuildTheGunAction");
    private bool pressingTrigger;

    public GameObject Clock;
    public GameObject ClockPointer1;
    public GameObject ClockPointer2;

    public GameObject Soda;
    public GameObject ErlenMeyer;
    public GameObject DoorHandle;
    public GameObject Pipe;
    public GameObject Battery;
    public GameObject Prism;
    public GameObject Pot;
    public GameObject Cable;
    public GameObject CableConnectors;
    public GameObject RepairGun;
    public GameObject CompleteRepairGun;


    // Start is called before the first frame update
    void Start()
    {
        Checkmark.transform.position -= new Vector3(-Checkmark.transform.position.x, 0, -Checkmark.transform.position.z);

        clockWasFound = false;
        clockAlreadyBuilt = false;
        sodaAlreadyBuilt = false;
        sodaWasFound = false;
        erlenmeyerWasFound = false;
        erlenmeyerAlreadyBuilt = false;
        doorHandleWasFound = false;
        doorHandleAlreadyBuilt = false;
        pipeWasFound = false;
        pipeAlreadyBuilt = false;
        batteryWasFound = false;
        batteryWasBuilt = false;
        prismWasFound = false;
        prismAlreadyBuilt = false;
        potWasFound = false;
        potAlreadyBuilt = false;
        cableWasFound = false;
        cableAlreadyBuilt = false;

        alreadyBuilt = false;
    }

    void Update()
    {
        pressingTrigger = buildingAction.stateDown;

        if (clockWasFound && sodaWasFound && erlenmeyerWasFound && doorHandleWasFound && pipeWasFound && !alreadyBuilt) //alreadyBuilt
        {
            alreadyBuilt = true;
            Destroy(RepairGun);
            CompleteRepairGun.SetActive(true);
                
        }

        if (clockWasFound && !clockAlreadyBuilt)
        {
            clockAlreadyBuilt = true;
            GameObject checkmark = Instantiate(Checkmark, Checkmark.transform);
            checkmark.transform.position += new Vector3(17.854f, 0, 1.511f);
            Clock.SetActive(true);
            ClockPointer1.SetActive(true);
            ClockPointer2.SetActive(true);
        }

        if (sodaWasFound && !sodaAlreadyBuilt)
        {
            sodaAlreadyBuilt = true;
            GameObject checkmark = Instantiate(Checkmark, Checkmark.transform);
            checkmark.transform.position += new Vector3(18.3446f, 0, 1.3818f);
            Soda.SetActive(true);
        }

        if (erlenmeyerWasFound && !erlenmeyerAlreadyBuilt)
        {
            erlenmeyerAlreadyBuilt = true;
            GameObject checkmark = Instantiate(Checkmark, Checkmark.transform);
            checkmark.transform.position += new Vector3(18.0409f, 0, 1.4707f);
            ErlenMeyer.SetActive(true);
        }

        if (doorHandleWasFound && !doorHandleAlreadyBuilt)
        {
            GameObject checkmark = Instantiate(Checkmark, Checkmark.transform);
            checkmark.transform.position += new Vector3(17.7911f, 0, 1.0704f);
            doorHandleAlreadyBuilt = true;
            DoorHandle.SetActive(true);
        }

        if (pipeWasFound && !pipeAlreadyBuilt)
        {
            pipeAlreadyBuilt = true;
            GameObject checkmark = Instantiate(Checkmark, Checkmark.transform);
            checkmark.transform.position += new Vector3(17.8435f, 0, 1.3742f);
            Pipe.SetActive(true);
        }
        
        if (prismWasFound && !prismAlreadyBuilt)
        {
            prismAlreadyBuilt = true;
            GameObject checkmark = Instantiate(Checkmark, Checkmark.transform);
            checkmark.transform.position += new Vector3(17.6937f, 0, 1.2254f);
            Prism.SetActive(true);
            
        }

        if (potWasFound && !potAlreadyBuilt)
        {
            potAlreadyBuilt = true;
            GameObject checkmark = Instantiate(Checkmark, Checkmark.transform);
            checkmark.transform.position += new Vector3(17.9772f, 0, 1.1956f);
            Pot.SetActive(true);
            
        }

        if (cableWasFound && !cableAlreadyBuilt)
        {
            cableAlreadyBuilt = true;
            GameObject checkmark = Instantiate(Checkmark, Checkmark.transform);
            checkmark.transform.position += new Vector3(18.3484f, 0, 1.391f);
            Cable.SetActive(true);
            CableConnectors.SetActive(true);
        }
        if (batteryWasFound && !batteryWasBuilt)
        {
            batteryWasBuilt = true;
            GameObject checkmark = Instantiate(Checkmark, Checkmark.transform);
            checkmark.transform.position += new Vector3(18.3484f, 0, 1.391f);
            Battery.SetActive(true);
        }


        /*if (clockWasFound && sodaWasFound && erlenmeyerWasFound && doorHandleWasFound && pipeWasFound)
        {
            alreadyBuilt = true;
            SpawnGun();
            
        }*/
    }

    void SpawnGun()
    {

    }
}
