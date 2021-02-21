using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnTrigger : MonoBehaviour
{
    public Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = respawnPoint.position;
        }
    }
}
