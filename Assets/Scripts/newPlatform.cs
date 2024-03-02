using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class newPlatform : MonoBehaviour
{
    bool platformneed = true;
    public GameObject platform;
    Vector3 position;
    public GameObject playerObject;
    float gorundDistance;
    bool jumpSuccsess;
    public Rigidbody Player;
    public int jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (platformneed)
        {
            position = transform.position;
            Vector3 newcoords = position + new Vector3(0, 0, 10);
            Instantiate(platform,newcoords,transform.rotation);
            platformneed = false;
        }
        else
        {
           // StartCoroutine(ExampleCoroutine());
        }

    }
}
