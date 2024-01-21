using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController character;
    private float moveAmount = 2;
    
    private void Awake() {
        character = GetComponent<CharacterController>();
    }

    private void Update() {
        if (!ControlPanel.isGameOver) {
            if (Input.GetKeyDown(KeyCode.UpArrow) && character.transform.position.y + moveAmount < 9) {
                character.transform.position = new Vector3(character.transform.position.x, character.transform.position.y + moveAmount);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && character.transform.position.y - moveAmount > 0) {
                character.transform.position = new Vector3(character.transform.position.x, character.transform.position.y - moveAmount);
            }
            Collider2D[] colliders = Physics2D.OverlapBoxAll(character.bounds.center, character.bounds.size/2, 0f);
            foreach (Collider2D collider in colliders) {
                if (collider.CompareTag("Zombie")) {
                    // Destroy(gameObject);
                    ControlPanel.isGameOver = true;
                }
            }
        }
    }

}
