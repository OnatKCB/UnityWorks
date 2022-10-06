using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.ObserverPatternExample
{
    public class TestSystem : Observer
{
    private void Start() 
    {
        ObserverManager.Instance.RegisterObserver(this, SubjectType.TestType);    
    }
    public override void OnNotify(NotificationType notificationType)
    {
        switch(notificationType)
        {
            case NotificationType.ForwardButton:
                break;
            case NotificationType.BackButton:
                break;
            case NotificationType.LeftButton:
                break;
            case NotificationType.RightButton:
                break;
            default:
                break;
        }
        
    }
}   
}