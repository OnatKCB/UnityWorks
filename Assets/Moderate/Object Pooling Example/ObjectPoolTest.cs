using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityWorks.ObjectPoolExample
{
    public class ObjectPoolTest : MonoBehaviour
{
    [SerializeField] private float spawnInterval;
    [SerializeField] private ObjectPool ope;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nameof(SpawnRoutine));
    }
    private IEnumerator SpawnRoutine()
    {
        int counter = 0;
        while(true)
        {
            GameObject obj = ope.GetPooledObject(counter++ % 2);
            obj.transform.position = Vector3.zero;
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
}