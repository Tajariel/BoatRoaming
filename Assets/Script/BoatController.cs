using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    public Rigidbody rb;
    public float maxSpeed = 10;
    private float currentSpeed = 0;
    public float accel = 10;
    public float rotationSpeed = 0.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Jump")){
            currentSpeed = (currentSpeed+accel)*Time.deltaTime;
            rb.AddForce(maxSpeed*transform.right, ForceMode.Force);            
        }
        if(Input.GetButton("Horizontal")){
            float turn = Input.GetAxis("Horizontal");
            rb.AddTorque(transform.up*rotationSpeed*turn);
        }
    }
}
