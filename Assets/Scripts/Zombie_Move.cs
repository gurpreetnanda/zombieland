using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Zombie_Move : MonoBehaviour
{

    private void Update() {
        transform.position -= new Vector3(3f * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if (!ControlPanel.isGameOver) {
            if (collider.CompareTag("Bullet")) {
                Destroy(gameObject);
                Metrics.score += 5;
            }
            if (collider.CompareTag("LeftWall")) {
                Destroy(gameObject);
                Metrics.lives -= 1;
                if (Metrics.lives == 0) {
                    ControlPanel.isGameOver = true;
                }
            }
        }
    }
}
