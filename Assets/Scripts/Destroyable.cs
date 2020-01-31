using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    Transform intact;
    Transform destroyed;

    bool isDestroyed = false;

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
        if(!isDestroyed)
        {
            intact.gameObject.SetActive(false);
            destroyed.gameObject.SetActive(true);
            print("destroyed set active");
            foreach (Fragment fragment in destroyed.GetComponentsInChildren<Fragment>())
            {
                Vector3 offset = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
                fragment.Shatter(direction + offset);
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
