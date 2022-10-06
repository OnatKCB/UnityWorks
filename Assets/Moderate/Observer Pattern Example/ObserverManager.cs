using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.ObserverPatternExample
{
public class ObserverManager : MonoBehaviour
{
    #region Singleton
    private static ObserverManager _instance = null;
    public static ObserverManager Instance => _instance; 
    #endregion
    private List<Subject> _subjects = null;
    public void RegisterSubject(Subject subject)
    {
        if(_subjects == null)
        {
            _subjects = new List<Subject>();
        }
        _subjects.Add(subject);
    }
    private void Awake() 
    {
        _instance = null;    
    }
    public void RegisterObserver(Observer observer, SubjectType subjectType)
    {
        foreach (var _subject in _subjects)
        {
            if(_subject._subjectType == subjectType)
            {
                _subject.RegisterObserver(observer);
            }
        }
    }
}
}
public enum NotificationType
{
    ForwardButton, BackButton, LeftButton, RightButton
}
public enum SubjectType
{
    TestType
}