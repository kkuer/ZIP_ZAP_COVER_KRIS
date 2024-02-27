using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contract : MonoBehaviour
{
    public Rigidbody2D rb;
    public HingeJoint2D joint;
    private JointMotor2D jointMotor;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        joint = GetComponent<HingeJoint2D>();
        jointMotor = joint.motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            jointMotor.motorSpeed = 800;
            joint.motor = jointMotor;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            jointMotor.motorSpeed = -800;
            joint.motor = jointMotor;
        }
    }
}
