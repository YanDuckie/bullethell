using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLavaScript : MonoBehaviour
{

    public Vector3 position1 ;
    public Vector3 position2 ;
    public float speed ;

    public GameObject Part ;


    public bool movingToPosition2 = true ;
    private Rigidbody partRb;
    private const float positionEpsilon = 0.01f;

    private void Start()
    {
        if (Part == null)
        {
            Debug.LogError("MovingLavaScript: Part is not assigned.");
            enabled = false;
            return;
        }

        partRb = Part.GetComponent<Rigidbody>();
        if (partRb == null)
        {
            // Prefer having a kinematic Rigidbody on moving colliders so physics interactions work correctly
            Debug.LogWarning("MovingLavaScript: Part has no Rigidbody. Adding a kinematic Rigidbody for correct physics behaviour.");
            partRb = Part.AddComponent<Rigidbody>();
            partRb.isKinematic = true;
        }
        else
        {
            // Ensure kinematic so we can control movement via MovePosition
            partRb.isKinematic = true;
        }
    }

    void FixedUpdate()
    {
        if (partRb == null) return;

        Vector3 current = partRb.position;
        Vector3 target = movingToPosition2 ? position2 : position1;

        // Move using Rigidbody.MovePosition for reliable physics collisions
        Vector3 next = Vector3.MoveTowards(current, target, speed * Time.fixedDeltaTime);
        partRb.MovePosition(next);

        // Switch direction when close enough to the target
        if (Vector3.Distance(next, target) <= positionEpsilon)
        {
            movingToPosition2 = !movingToPosition2;
        }
    }
    // Start is called before the first frame update

}
