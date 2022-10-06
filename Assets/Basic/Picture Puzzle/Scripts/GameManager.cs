using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.PicturePuzzle
{
    public class GameManager : MonoBehaviour
{
    int placedParts, totalParts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreasePart()
    {
        placedParts++;
        if(placedParts == totalParts)
        {
            Debug.Log("");
        }
    }
}
}
