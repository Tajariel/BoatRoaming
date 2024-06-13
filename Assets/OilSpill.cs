using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilSpill : MonoBehaviour
{
    public Collider boatCollider;
    private bool isDestroying = false;
    private Vector3 scaleDown = new Vector3(1,1,1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDestroying == true)
        {
            transform.localScale -= scaleDown * Time.deltaTime;
            if (transform.localScale.y < 0.0001f)
            {
                Destroy(this);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == boatCollider)
        {
            isDestroying = true;
        }
    }
}
