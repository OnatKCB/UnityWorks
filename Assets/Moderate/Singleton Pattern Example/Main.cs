using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityWorks.SingletonPatternExample
{
    public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
                GameManager.Instance.testText = "Valid";
    }

    // Update is called once per frame
    void Update()
    {
        Singleton.Instance.getText();
        Debug.Log(Singleton.Instance.getText());
        Debug.Log(GameManager.Instance.testText);
    }
}
}
