using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotRagdol : MonoBehaviour
{

    public Rigidbody rb;
    public SpringJoint sJ1;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        sJ1.GetComponent<SpringJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sJ1 != null)
        {
            var rbV = rb.velocity.magnitude;
            if (rbV >= 50f)
            {
                sJ1.breakForce = 0;
                sJ1.breakTorque = 0;


            }
        }
    }
}
