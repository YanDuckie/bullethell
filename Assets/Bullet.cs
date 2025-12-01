using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private Vector3 direction = Vector3.left;
    [SerializeField] private float lifeTime = 10f;

    private Rigidbody rb;
    private float spawnTime;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        spawnTime = Time.time;
    }

    private void Start()
    {
        direction = direction.normalized;
    }

    private void FixedUpdate()
    {
        if (rb != null)
        {
            rb.velocity = direction * speed;
        }
        else
        {
            transform.position += direction * speed * Time.fixedDeltaTime;
        }

        if (Time.time - spawnTime > lifeTime)
            Destroy(gameObject);
    }

    // Optional helpers for runtime configuration
    public void SetDirection(Vector3 dir)
    {
        direction = dir.normalized;
    }

    public void SetSpeed(float s)
    {
        speed = s;
    }
}
