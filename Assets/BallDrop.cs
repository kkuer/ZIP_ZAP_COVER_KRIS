using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDrop : MonoBehaviour
{
    public Rigidbody2D ballRigid;

    // Start is called before the first frame update
    void Start()
    {
        ballRigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            ballRigid.gravityScale = 1;
        }
    }
}
