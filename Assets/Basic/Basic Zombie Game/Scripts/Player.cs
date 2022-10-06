using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.BasicZombieGame
{
    public class Player : MonoBehaviour
{
    int currentHealth;
    public TMPro.TextMeshProUGUI HealthText;

    public void DecreaseHealth()
    {
        if(currentHealth <= 0)
        {
            Debug.Log("");
        }
    }
}   
}
