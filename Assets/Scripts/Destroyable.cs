using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    Transform intact;
    Transform destroyed;

    public float fickung = 1.0f;

    bool isDestroyed = false;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            if(!intact)
            {
                intact = child;
            } else
            {
                destroyed = child;
            }
        }
        destroyed.gameObject.SetActive(false);
    }

    public void Shatter(Vector3 direction)
    {
        if(!isDestroyed)
        {
            intact.gameObject.SetActive(false);
            destroyed.gameObject.SetActive(true);
            print("destroyed set active");
            foreach (Fragment fragment in destroyed.GetComponentsInChildren<Fragment>())
            {
                Vector3 offset = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
                fragment.Shatter((direction + offset) * fickung);
            }
            isDestroyed = true;
        }
    }

    public void Repair()
    {
        if(isDestroyed)
        {
            Debug.Log("Repairing " + gameObject.name);
            foreach (Fragment fragment in destroyed.GetComponentsInChildren<Fragment>())
            {
                fragment.Repair();
            }
            isDestroyed = false;
        }
    }
}
