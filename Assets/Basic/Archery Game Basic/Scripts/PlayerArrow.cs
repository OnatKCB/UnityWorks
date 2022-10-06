using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityWorks.ArcheryGame
{
public class PlayerArrow : MonoBehaviour
{
    Rigidbody rb;
    BoxCollider box;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        box = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 3.0f))
        {
            string hitName = hit.collider.gameObject.name;
            if(hitName == "Test"){gm.IncreaseScore(1);}
            DeleteArrow();
        }
    }
    void DeleteArrow()
    {
        Destroy(rb);
        Destroy(box);
        Destroy(this);
    }
}
}

