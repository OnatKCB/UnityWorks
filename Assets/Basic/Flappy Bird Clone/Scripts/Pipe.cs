using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityWorks.FlappyBirdClone
{
    public class Pipe : MonoBehaviour
{
    [SerializeField]
    float firstLengthGen, secondLengthGen;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        float randomPipe = Random.Range(firstLengthGen, secondLengthGen);
        transform.position = new Vector3(0.4f, randomPipe, transform.position.z);
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= -0.5f)
        {
            gm.IncreaseScore(1);
            Destroy(gameObject);
        }
        transform.Translate(-0.2f * Time.deltaTime, 0, 0);
    }
}
}