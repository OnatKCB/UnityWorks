using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityWorks.BallLabyrinth
{
public class Floor : MonoBehaviour
{
    [SerializeField] float speed, x_movement, y_movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x_movement = Input.GetAxis("Mouse X") * Time.deltaTime * -speed;
        y_movement = Input.GetAxis("Mouse Y") * Time.deltaTime * speed;
        transform.eulerAngles += new Vector3(x_movement, 0, y_movement);
    }
}
}

