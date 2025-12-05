using UnityEngine;

public class Spinning : MonoBehaviour
{
    [Header("Rotation")]
    [Tooltip("Degrees per second around Y axis")]
    public float speed = 90f;

    [Tooltip("If true the script will add a kinematic Rigidbody automatically for correct physics collisions")]
    public bool autoAddRigidbody = true;

    private Rigidbody rb;
    private Collider col;

    private void Start()
    {
        col = GetComponent<Collider>();
        if (col == null)
        {
            Debug.LogWarning($"{name}: Spinning object has no Collider. Add a Collider so it blocks the player.");
        }

        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            if (autoAddRigidbody)
            {
                rb = gameObject.AddComponent<Rigidbody>();
                rb.isKinematic = true;
                rb.useGravity = false;
                Debug.Log($"{name}: Added kinematic Rigidbody for physics-aware rotation.");
            }
            else
            {
                Debug.LogWarning($"{name}: No Rigidbody found. Consider adding a kinematic Rigidbody for reliable physics collisions.");
            }
        }
        else
        {
            // Make sure existing Rigidbody is configured for kinematic movement
            rb.isKinematic = true;
            rb.useGravity = false;
        }
    }

    private void FixedUpdate()
    {
        float angle = speed * Time.fixedDeltaTime;

        if (rb != null)
        {
            // Use MoveRotation on a kinematic Rigidbody so physics engine sees the rotation
            Quaternion newRot = rb.rotation * Quaternion.Euler(0f, angle, 0f);
            rb.MoveRotation(newRot);
        }
        else
        {
            // Fallback if no Rigidbody is present
            transform.Rotate(0f, speed * Time.deltaTime, 0f);
        }
    }
}
