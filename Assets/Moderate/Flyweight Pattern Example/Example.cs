using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.FlyweightExample
{
    public class Example : MonoBehaviour
{
    [SerializeField] private ExampleData edata;
    private int a,b,c,d,e;
    private float x,y,z,t;
    private string alpha, beta, charlie, epsilon;
    private void Start() 
    {
       int thisA = edata.A;
       float thisX = edata.X;
       string thisAlpha = edata.Alpha;
    }
}
}
