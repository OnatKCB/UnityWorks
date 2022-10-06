using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityWorks.SingletonPatternExample
{
    public class MonoSingleton<T> : MonoBehaviour where T: MonoSingleton<T>
{
    private static volatile T instance = null;
    /*
    The volatile keyword indicates that a field might be modified by multiple threads that are executing at the same time. 
    The compiler, the runtime system, and even hardware may rearrange reads and writes to memory locations for performance reasons. 
    Fields that are declared volatile are excluded from certain kinds of optimizations. 
    There is no guarantee of a single total ordering of volatile writes as seen from all threads of execution.
    */
    public static T Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType(typeof(T)) as T;
            }
            return instance;
        }
    }

}
}
