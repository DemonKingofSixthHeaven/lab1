using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gottaGoFast : MonoBehaviour
{
    private Vector3 playerInput;
    private Transform PlayerCamera;
    public Rigidbody Player;
    public float speed =5;
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
        move();
    }
    private void move()
    {
        Vector3 MoveVector = transform.TransformDirection(playerInput) * speed;
        Player.velocity = new Vector3(MoveVector.x,Player.velocity.y,MoveVector.z);
    }
    
}
