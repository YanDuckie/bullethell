
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    [SerializeField]
    PlayerInput playerInput ;
    public Rigidbody rb ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       var horizontal=playerInput.actions["Horizontal"].ReadValue<float>() ;
       var vertical=playerInput.actions["Vertical"].ReadValue<float>() ;
            rb.AddForce(0,0,200 * vertical * Time.deltaTime, ForceMode.VelocityChange);
        

   
            rb.AddForce(200 * horizontal * Time.deltaTime,0,0, ForceMode.VelocityChange);
        
    }
}
