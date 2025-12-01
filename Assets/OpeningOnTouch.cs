using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningOnTouch : MonoBehaviour
{
    
    public GameObject Key ;
    public bool isKeyCollected = false ;
    public GameObject Wall ;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && isKeyCollected == false)
        {
            isKeyCollected = true ;
            Debug.Log("OPEN SESAME") ;
            Destroy(Wall) ;
            GetComponent<Renderer>().material.color = Color.black ;
        }
    }

}
