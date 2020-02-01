using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class DieUhr : MonoBehaviour
{
    private WorkBeench workbench;
    private Interactable clockInteractabale;
    // Start is called before the first frame update
    void Start()
    {
        workbench = FindObjectOfType<WorkBeench>();
        clockInteractabale = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if(clockInteractabale.isHovering)
        {
            workbench.clockWasFound = true;
        }
    }
}
