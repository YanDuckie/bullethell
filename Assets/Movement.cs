
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if (Input.GetKey(KeyCode.W)) 
        {
            rb.AddForce(0,0,250 * Time.deltaTime, ForceMode.VelocityChange);
        }
      if (Input.GetKey(KeyCode.S)) 
        {
            rb.AddForce(0,0,-250 * Time.deltaTime, ForceMode.VelocityChange);
        }
     if (Input.GetKey(KeyCode.D)) 
        {
            rb.AddForce(250 * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
     if (Input.GetKey(KeyCode.A)) 
        {
            rb.AddForce(-250 * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
    }
}
