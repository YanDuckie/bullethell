using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class Collider : MonoBehaviour
{
    // Start is called before the first frame update

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("TOUCHED") ;
           
 
            FindAnyObjectByType<GameManager>().Restart();
        }
        else if (collision.gameObject.tag == "WinPad")
        {
            Debug.Log("LEVEL COMPLETE") ;
            FindAnyObjectByType<GameManager>().NextLevel();
        }
    }
} 

