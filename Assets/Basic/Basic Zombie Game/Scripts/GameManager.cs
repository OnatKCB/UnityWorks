using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityWorks.BasicZombieGame
{
    public class GameManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI time_text;
    int seconds;
    GameObject Zombie;
    GameObject[] spawnPoints;
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawn Points");
        InvokeRepeating("DecreaseSeconds", 0.0f, 1.0f);
        InvokeRepeating("SpawnZombie", 0.0f, 5.0f);
    }
    void DecreaseSeconds()
    {
        seconds--;
        time_text.text = seconds.ToString();
        if(seconds <= 0)
        {

        }   
    }
    void SpawnZombie()
    {
        int randspawn = Random.Range(0, spawnPoints.Length);
        GameObject spawnedZombie = Instantiate(Zombie, spawnPoints[randspawn].transform.position, Quaternion.identity);
    }
}
}
