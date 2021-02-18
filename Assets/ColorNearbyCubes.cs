using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorNearbyCubes : MonoBehaviour
{
    
    public float detectObjectRadius = 9f;
    
    void FixedUpdate() // Fixed update is called at a fixed rate independent of frame rate
    {
        var nearbyColliders = Physics.OverlapSphere(transform.position, detectObjectRadius);
        foreach (Collider col in nearbyColliders)
        {
            if (col.gameObject.tag == "CubeColor")
            {
                var cubeRenderer = col.gameObject.GetComponent<Renderer>();
                cubeRenderer.material.SetColor("_Color", Color.blue);
            }
        }
    }


    void OnDrawGizmos() // This method draws gizmos in the editor (cannot be seen in the Game, only the scene editor!)
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectObjectRadius);
    }
}
