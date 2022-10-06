using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace UnityWorks.ScriptableObjectExample
{
    public class ScriptableObjectInteract : MonoBehaviour
{
    [SerializeField] private ScriptableObjectExample soe;
    [SerializeField] private TextMeshPro nameText;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = soe.ObjectColor;
        transform.localScale = soe.ObjectScale;
        nameText.text = soe.ObjectName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
