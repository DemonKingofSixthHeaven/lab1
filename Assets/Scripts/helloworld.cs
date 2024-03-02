using Palmmedia.ReportGenerator.Core.Reporting.Builders.Rendering;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject BMO;
    int i = 0;
 
    public TextMeshPro number; 
    // Start is called before the first frame update
    void Start()
    {
        print("hellowo world");
    }

    // Update is called once per frame
    void Update()
    {
        
        number.text = i.ToString();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "point")
        {
            i++;
        }
    }
}
