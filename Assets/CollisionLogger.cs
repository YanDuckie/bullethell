using UnityEngine;

/// <summary>
/// Simple diagnostic component to log collision and trigger events.
/// Attach to a GameObject to confirm whether physics callbacks occur.
/// </summary>
public class CollisionLogger : MonoBehaviour
{
    private void OnCollisionEnter(Collision c)
    {
        Debug.Log($"[CollisionLogger] {name} OnCollisionEnter with {c.gameObject.name}");
    }

    private void OnCollisionStay(Collision c)
    {
        Debug.Log($"[CollisionLogger] {name} OnCollisionStay with {c.gameObject.name}");
    }

    private void OnCollisionExit(Collision c)
    {
        Debug.Log($"[CollisionLogger] {name} OnCollisionExit with {c.gameObject.name}");
    }

    private void OnTriggerEnter(Collider c)
    {
        Debug.Log($"[CollisionLogger] {name} OnTriggerEnter with {c.gameObject.name}");
    }

    private void OnTriggerExit(Collider c)
    {
        Debug.Log($"[CollisionLogger] {name} OnTriggerExit with {c.gameObject.name}");
    }
}
