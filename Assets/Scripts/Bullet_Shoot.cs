using UnityEngine;

public class Bullet_Shoot : MonoBehaviour
{
    private Rigidbody2D rb;
    public LayerMask layersDestroyingBullet;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * 10f;
        Destroy(gameObject, 2);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if ((layersDestroyingBullet.value & (1 << collision.gameObject.layer)) > 0) {
            Destroy(gameObject);
        }
    }
}
