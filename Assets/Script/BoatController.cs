using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    public Rigidbody rb;
    public float maxSpeed = 10;
    private float currentSpeed = 0;
    public float rotationSpeed = 0.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Fire1")!=0){
            float accel = Input.GetAxis("Fire1");
            rb.AddForce(maxSpeed*transform.right*accel, ForceMode.Force);            
        }
        if(Input.GetAxis("Horizontal")!= 0){
            float turn = Input.GetAxis("Horizontal");
            rb.AddTorque(transform.up*rotationSpeed*turn);
        }
    }
}
