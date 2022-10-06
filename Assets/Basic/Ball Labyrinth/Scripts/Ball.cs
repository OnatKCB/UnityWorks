using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityWorks.BallLabyrinth
{
public class Ball : MonoBehaviour
{
    float destroySpeed;
    public GameObject Panel;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Hole")
        {
            Destroy(GetComponent<Rigidbody>());
            transform.position = other.gameObject.transform.position;
            InvokeRepeating("DestroyBall", 0.0f, 0.02f);
        }
        if(other.gameObject.name == "ArrivePoint")
        {
            Panel.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
    void DestroyBall()
    {
        transform.localScale -= new Vector3(destroySpeed, destroySpeed, destroySpeed);
        if(transform.localScale.x <= 0.0f)
        {
            /*SceneManager.LoadScene();*/
        }
    }
}
}
