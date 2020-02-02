using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Gun"))
        {
            Debug.Log("Hit " + other.name);
            Fragment d = other.GetComponentInParent<Fragment>();
            if(d)
            {
                d.Repair();
            }
            GameObject o = Instantiate(explosion, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            Destroy(o, 2);
        }
    }
}
