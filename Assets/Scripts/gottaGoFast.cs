using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gottaGoFast : MonoBehaviour
{
    private Vector3 playerInput;
    private Transform PlayerCamera;
    public Rigidbody Player;
    public GameObject playerObject;
    float gorundDistance;
    bool jumpSuccsess;
    public float speed =5;
    public int jumpForce = 5;
    public Material jump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigid = Player.GetComponent<Rigidbody>();
        playerInput = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        
        Player.AddForce(transform.forward*speed);
        gorundDistance = playerObject.transform.localPosition.y;
        if (Input.GetKeyDown("space"))
        {
            print(gorundDistance.ToString());
            if (gorundDistance < 1f)
            {
                jumpSuccsess = true;
            }
            else
            {
                jumpSuccsess &= false;
            }
        }
        if(gorundDistance > 1f)
 {
     jump.color = Color.red;
 }
else if (gorundDistance <= 1f)
 {
     jump.color = Color.green;
 }
        move();
        


    }
    
    private void move()
    {
        Vector3 MoveVector = transform.TransformDirection(playerInput) * speed;
        Player.velocity = new Vector3(MoveVector.x,Player.velocity.y,MoveVector.z);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag== "ground" ) {
            if (jumpSuccsess)
            {
                Player.AddForce(transform.up * jumpForce);
            }
            else
            {
                Player.AddForce(transform.up * -jumpForce);
            } }
    }

}
