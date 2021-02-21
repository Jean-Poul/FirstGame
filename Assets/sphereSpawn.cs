using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereSpawn : MonoBehaviour
{
    public Transform spawnpoint;
    public GameObject Prefab;

    void OnTriggerEnter(Collider collide)
    {
        Instantiate(Prefab, spawnpoint.position, spawnpoint.rotation);
    }

}
