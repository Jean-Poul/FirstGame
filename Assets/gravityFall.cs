using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityFall : MonoBehaviour
{
    Rigidbody platform;
    void Start()
    {
        platform = GetComponent<Rigidbody>();
    }

    void OnCollisionExit(Collision other)
    {
        platform.mass = 1.0f;
        platform.useGravity = true;
    }

}
