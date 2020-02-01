using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class SodaStreamSammelstück : MonoBehaviour
{
    private WorkBeench workbench;
    private Interactable sodaInteractabale;
    // Start is called before the first frame update
    void Start()
    {
        workbench = FindObjectOfType<WorkBeench>();
        sodaInteractabale = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sodaInteractabale.isHovering)
        {
            workbench.sodaWasFound = true;
        }
    }
}
