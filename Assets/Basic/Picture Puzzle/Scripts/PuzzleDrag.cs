using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityWorks.PicturePuzzle
{
    public class PuzzleDrag : MonoBehaviour
{
    Camera cam;
    Vector2 startingPos;
    GameObject[] pictureSeries;
    GameManager gamemanager;

    private void OnMouseDrag() 
    {
        Vector3 position = cam.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0;
        transform.position = position;
    }
    void Start() 
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        startingPos = transform.position;
        pictureSeries = GameObject.FindGameObjectsWithTag("Picture");
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update() 
    {
        if(Input.GetMouseButtonUp(0))
        {
            foreach(GameObject picture in pictureSeries)
            {
                if(picture.name == gameObject.name)
                {
                    float distance = Vector3.Distance(picture.transform.position, transform.position);
                    if(distance <= 1)
                    { 
                        transform.position = picture.transform.position; 
                        gamemanager.IncreasePart();
                        this.enabled = false;
                    }
                    else{transform.position = startingPos;}
                }
            }
        }
    }
}
}
