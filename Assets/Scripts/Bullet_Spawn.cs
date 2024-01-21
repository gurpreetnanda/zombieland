using UnityEngine;

public class Bullet_Spawn : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    float lastEscPressed = -999f;
    public float bulletDelay = 0.3f;

    void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) {
            if (Time.time > lastEscPressed + bulletDelay) {
                lastEscPressed = Time.time;
                Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            }
        }
    }

}
