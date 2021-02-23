/*using UnityEngine;

public class MyFirstScript : MonoBehaviour //: means implement
{
    public Rigidbody rigidbody;

    void Start() // Start is called before the first frame update
    {
//        rigidbody = GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision collider) // Listens to collision events
    {
        Debug.Log(collider.gameObject.name);
        rigidbody.AddForce(Vector3.up * 100);
    }

    void Update() // Update is called for every frame
    {
        if (Input.GetKeyDown(KeyCode.H)) // Listen to keypress
        {
            Debug.Log("H key was pressed"); // C# sout
            rigidbody.AddForce(Vector3.up * 1000); // Adds collision force for y axis
            
        }   
        
    }

}
*/