using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class DiesesHeizungsteil : MonoBehaviour
{
    private WorkBeench workbench;
    private Interactable heizungInteractabale;
    // Start is called before the first frame update
    void Start()
    {
        workbench = FindObjectOfType<WorkBeench>();
        heizungInteractabale = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (heizungInteractabale.isHovering)
        {
            workbench.pipeWasFound = true;
        }
    }
}
