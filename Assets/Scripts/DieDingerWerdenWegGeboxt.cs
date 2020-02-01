using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieDingerWerdenWegGeboxt : MonoBehaviour
{

void OnTriggerEnter (Collider other)
    {
        print("Hit " + other.name);
        float rnd = Random.Range(0.2f, 0.8f);
        Vector3 shatterObjectPosition = other.transform.position;
        Vector3 relativePosition = shatterObjectPosition - transform.position;
        Vector3 relativePositionNormalized = Vector3.Normalize(relativePosition) * rnd;
        Destroyable d = other.GetComponentInParent<Destroyable>();
        if (d)
        {
            d.Shatter(relativePositionNormalized);
        }
    }
}
