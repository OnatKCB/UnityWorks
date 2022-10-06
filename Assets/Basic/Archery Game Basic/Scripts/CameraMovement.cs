using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityWorks.ArcheryGame
{
    public class CameraMovement : MonoBehaviour
{
    float mouse_X, mouse_Y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse_X = Input.GetAxis("Mouse Y");
        mouse_Y = Input.GetAxis("Mouse X");
        transform.Rotate(-mouse_X, 0, 0);
        transform.Rotate(0, mouse_Y, 0, Space.World);
    }
}
}
