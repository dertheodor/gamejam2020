using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Vector3 direction = transform.TransformDirection(Vector3.forward);
            if (Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity))
            {
                if(hit.collider)
                {
                    Destroyable destroyable = hit.collider.GetComponentInParent<Destroyable>();
                    if(destroyable)
                    {
                        destroyable.Shatter(direction);
                    }
                }
            }
        }
        if(Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Vector3 direction = transform.TransformDirection(Vector3.forward);
            if (Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity))
            {
                if (hit.collider)
                {
                    Destroyable destroyable = hit.collider.GetComponentInParent<Destroyable>();
                    if (destroyable)
                    {
                        destroyable.Repair();
                    }
                }
            }
        }
    }
}
