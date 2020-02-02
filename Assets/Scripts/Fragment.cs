using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragment : MonoBehaviour
{
    float recordTime = 1.5f;
    bool isShattering = false;
    bool isRepairing = false;
    int repairIndex = 0;
    bool isRepaired = true;

    List<Vector3> positions = new List<Vector3>();
    List<Quaternion> rotations = new List<Quaternion>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isShattering)
        {
            positions.Add(transform.position);
            rotations.Add(transform.rotation);
            recordTime -= Time.deltaTime;

            if(recordTime < 0)
            {
                Debug.Log("Finished shattering");
                isShattering = false;
            }
        }
        if(isRepairing)
        {
            repairIndex--;
            if (repairIndex < 0)
            {
                isRepairing = false;
                recordTime = 1.5f;
                positions = new List<Vector3>();
                rotations = new List<Quaternion>();

                isRepaired = true;
                GetComponentInParent<Destroyable>().CheckIfRepaired();
            } else
            {
                print(repairIndex);
                transform.position = positions[repairIndex];
                transform.rotation = rotations[repairIndex];
            }
        }
    }

    public void Shatter(Vector3 direction)
    {
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().AddForce(direction * 10, ForceMode.Impulse);
        isShattering = true;
        isRepaired = false;
    }

    public void Repair()
    {
        if(!isRepaired && !isRepairing)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            isShattering = false;
            isRepairing = true;
            repairIndex = positions.Count;
        }
    }

    public bool IsRepaired()
    {
        return isRepaired;
    }
}
