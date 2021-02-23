using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTombColor : MonoBehaviour
{
    
    [SerializeField] private Light myLight;
   
    void OnCollisionEnter(Collision collider) // Listens to collision events
    {
        Debug.Log("Fruit found"); // C# sout
        myLight.color = Color.green; // Adds collision force for y axis
        
    }



    /*
    void Update() // Update is called for every frame
    {
        if (Input.GetKeyDown(KeyCode.H)) // Listen to keypress
        {
            Debug.Log("H key was pressed"); // C# sout
            myLight.color = Color.green; // Adds collision force for y axis
            
        }   
        
    }
    */
}
