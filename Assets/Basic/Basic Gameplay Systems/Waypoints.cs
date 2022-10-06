using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.BasicGameplaySystems
{
    public class Waypoints : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    [SerializeField] GameObject player;
    int current = 0;
    [SerializeField] float speed, WPradius;
	
	void Update () {
		if(Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            current = Random.Range(0,waypoints.Length);
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

    }

    void OnTriggerEnter(Collider n)
    {
        if (n.gameObject == player)
        {
            player.transform.parent = transform;
        }
    }
    void OnTriggerExit(Collider n)
    {
        if (n.gameObject == player)
        {
            player.transform.parent = null;
        }
    }
}
}
