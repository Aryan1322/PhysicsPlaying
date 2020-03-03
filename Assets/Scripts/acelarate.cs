using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acelarate : MonoBehaviour
{
    public HingeJoint hinge;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            JointMotor motor = hinge.motor;
            motor.force += 100;
            hinge.motor = motor;
        }
        else
        {
            JointMotor motor = hinge.motor;
            motor.force -= 100;
            hinge.motor = motor;
        }
        
    }
}
