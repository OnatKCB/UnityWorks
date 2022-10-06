using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace UnityWorks.FlappyBirdClone
{
    public class GameManager : MonoBehaviour
{
    public GameObject Pipe;

    int Score = 0;
    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Add_Pipe", 0.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Add_Pipe()
    {
        GameObject new_pipe = Instantiate(Pipe);
    }
    public void IncreaseScore(int variable)
    {
        Score += variable;
        ScoreText.text = Score.ToString();
    }
}
}
