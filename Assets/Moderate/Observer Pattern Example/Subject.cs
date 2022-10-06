using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.ObserverPatternExample
{
    public abstract class Subject : MonoBehaviour
{
    private List<Observer> _observers = null;
    [SerializeField] private SubjectType subjectType;
    public SubjectType _subjectType => subjectType; 
    public void RegisterObserver(Observer observer)
    {
        if(observer == null)
        _observers = new List<Observer>();
        _observers.Add(observer);
    }
    private void Start() 
    {
        ObserverManager.Instance.RegisterSubject(this);    
    }
    public void Notify(NotificationType notificationType)
    {
        foreach (var observer in _observers)
        {
            observer.OnNotify(notificationType);
        }
    }
}
}

