﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    Transform intact;
    Transform destroyed;

    // Start is called before the first frame update
    void Start()
    {
        Transform[] children = GetComponentsInChildren<Transform>();
        print(children.Length);
        intact = children[1];
        destroyed = children[2];
        destroyed.gameObject.SetActive(false);
    }

    public void Shatter(Vector3 direction)
    {
        intact.gameObject.SetActive(false);
        destroyed.gameObject.SetActive(true);
        print("destroyed set active");

        foreach(Fragment fragment in destroyed.GetComponentsInChildren<Fragment>())
        {
            fragment.Shatter(direction);
        }
    }

    public void Repair()
    {
        if(destroyed.gameObject.activeSelf)
        {
            Debug.Log("Repairing " + gameObject.name);
            foreach (Fragment fragment in destroyed.GetComponentsInChildren<Fragment>())
            {
                fragment.Repair();
            }
        }
    }
}
