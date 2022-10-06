using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.ObserverPatternExample
{
    public abstract class Observer : MonoBehaviour
{
    public abstract void OnNotify(NotificationType notificationType);
}   
}
