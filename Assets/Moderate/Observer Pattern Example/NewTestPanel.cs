using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.ObserverPatternExample
{
    public class NewTestPanel : MonoBehaviour
{
    public static event Action OnForwardButtonClicked;
    public static event Action OnBackwardButtonClicked;
    public static event Action OnLeftButtonClicked;
    public static event Action OnRightButtonClicked;
    //public static event Action<Vector3> OnButtonClicked;
    public void ForwardOnClick()
    {
        OnForwardButtonClicked?.Invoke();
    }
    public void BackOnClick()
    {
        OnBackwardButtonClicked?.Invoke();
    }
    public void RightOnClick()
    {
        OnRightButtonClicked?.Invoke();
    }
    public void LeftOnClick()
    {
        OnLeftButtonClicked?.Invoke();
    }
}
   
}