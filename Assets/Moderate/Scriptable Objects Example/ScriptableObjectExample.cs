using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityWorks.ScriptableObjectExample
{
    [CreateAssetMenu(fileName = "Scriptable Object Example", menuName = "Scriptable Object Example")]
    public class ScriptableObjectExample : ScriptableObject
{
    public string ObjectName = "Name";
    public int ObjectVariableOne;
    public float ObjectVariableTwo;
    public Vector3 ObjectScale = Vector3.one;
    public Color ObjectColor;
}
}