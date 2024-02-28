using Palmmedia.ReportGenerator.Core.Reporting.Builders.Rendering;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int i = 0;
 
    public TextMeshPro number; 
    // Start is called before the first frame update
    void Start()
    {
        print("hellor world");
    }

    // Update is called once per frame
    void Update()
    {
        
        number.text = i.ToString();
        i++;
    }
}
