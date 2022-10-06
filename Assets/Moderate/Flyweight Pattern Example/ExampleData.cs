using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.FlyweightExample
{
    [CreateAssetMenu(fileName = "ExampleData", menuName = "FlyweightExample")]
    public class ExampleData : ScriptableObject
{
    private int a,b,c,d,e;
    private float x,y,z,t;
    private string alpha, beta, charlie, epsilon;
    public int A => a;
    public int B => b;
    public int C => c;
    public int D => d;
    public int E => e;
    public float X => x;
    public float Y => y;
    public float Z => z;
    public float T => t;
    public string Alpha => alpha;
    public string Beta => beta;
    public string Charlie => charlie;
    public string Epsilon => epsilon;
}
}