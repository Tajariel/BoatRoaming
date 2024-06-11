using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    public Rigidbody rb;
    public float maxSpeed = 1;
    public float accel = 1;
    public float rotationSpeed = 1;
    public float rotaAccel = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Jump")){
            float speedDif = maxSpeed - rb.velocity.x;
            float movement = speedDif * accel;
            rb.AddForce(movement*transform.forward, ForceMode.Force);
        }
        if(Input.GetButton("Horizontal")){
            float turn = Input.GetAxis("Horizontal");
            rb.AddTorque(transform.up*rotationSpeed*turn);
        }
    }
}
