using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.ObserverPatternExample
{
    public class NewTestSystem : MonoBehaviour
{
    public void MoveForward()
    {

    }
    public void MoveBackward()
    {
        
    }
    public void MoveLeft()
    {
        
    }
    public void MoveRight()
    {
        
    }
    private void Start() 
    {
        NewTestPanel.OnForwardButtonClicked += MoveForward;
        NewTestPanel.OnBackwardButtonClicked += MoveBackward;
        NewTestPanel.OnLeftButtonClicked += MoveLeft;
        NewTestPanel.OnRightButtonClicked += MoveRight;
    }
}
   
}