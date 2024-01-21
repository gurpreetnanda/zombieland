using UnityEngine;

public class Zombie_Spawn : MonoBehaviour
{
    public GameObject zombiePrefab;
    public float spawnInterval = 1f;

    void Start()
    {
        InvokeRepeating("SpawnZombie", 0f, spawnInterval);
    }

    void SpawnZombie()
    {
        if (!ControlPanel.isGameOver) {
            Vector3 spawnPosition = new Vector3(11f, Random.Range(0,5) * 2);
            Instantiate(zombiePrefab, spawnPosition, Quaternion.identity);
        }
    }
}