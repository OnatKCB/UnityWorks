using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityWorks.FlappyBirdClone
{
    public class CloudBackground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= -0.5f)
        {
            float y_var = Random.Range(0.0f, 0.5f);
            transform.position = new Vector3(0.5f, y_var, transform.position.z);
        }
        transform.Translate(1.0f * Time.deltaTime, 0, 0);
    }
}
}
