using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushBall : MonoBehaviour
{
    public float pushForce = 0.1f;
    public Rigidbody ball;
    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        ball.AddForce(0, 0, pushForce, ForceMode.Impulse);    
    }
}
