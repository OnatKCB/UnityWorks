using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace UnityWorks.BasicZombieGame
{
public class Zombie : MonoBehaviour
{
    NavMeshAgent zombieNavMesh;
    Animator zombieAnim;
    bool isAttacking;
    int health;
    // Start is called before the first frame update
    void Start()
    {
        zombieNavMesh = GetComponent<NavMeshAgent>();
        zombieAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, GameObject.FindWithTag("Player").transform.position);
        if(distance > 1.1f)
        {
            zombieAnim.SetTrigger("Walk");
            zombieNavMesh.destination = GameObject.FindWithTag("Player").transform.position;
            isAttacking = false;
            CancelInvoke("GiveDamageToPlayer");
        }
        else
        {
            zombieAnim.SetTrigger("Attack");
            if(isAttacking == false)
            {
                InvokeRepeating("GiveDamageToPlayer", 0.0f, 2.0f);
                isAttacking = true;
            }
        }

    }
    public void DecreaseHealth(int value)
    {
        health -= value;
        if(health <= 0)
        {
            zombieAnim.SetTrigger("Die");
            GetComponent<BoxCollider>().enabled = false;
            Destroy(zombieNavMesh);
            Destroy(this);
        }
    }
    void TakeDamage()
    {
        //GameObject.FindWithTag("Player").GetComponent<Player>.DecreaseHealth();
    }
}

}
