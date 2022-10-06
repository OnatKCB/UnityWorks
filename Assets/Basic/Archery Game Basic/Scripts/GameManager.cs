using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityWorks.ArcheryGame
{
    public class GameManager : MonoBehaviour
{
    public GameObject arrow;
    public Image throwingSpeedBar;
    [SerializeField] float throwingSpeed, resetThrowingSpeed;
    Transform Camera;
    int Score, arrowLeft, nextLevelScore;
    public Text Score_Text, arrowLeft_Text;
    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("Main Camera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(arrowLeft > 0)
            {
            GameObject newArrow = Instantiate(arrow, Camera.position, Quaternion.identity);
            throwingSpeed *= throwingSpeedBar.fillAmount;
            newArrow.GetComponent<Rigidbody>().AddForce(newArrow.transform.forward * throwingSpeed);
            throwingSpeed = resetThrowingSpeed;
            DecreaseArrow();
            }
        }
    }
    public void IncreaseScore(int value)
    {
        Score += value;
        Score_Text.text = Score.ToString();
    }
    public void DecreaseArrow()
    {
        arrowLeft--;
        arrowLeft_Text.text = arrowLeft.ToString();
        if(arrowLeft == 0)
        {
            if(Score >= nextLevelScore){}
            else{}
        }
    }
}
}
