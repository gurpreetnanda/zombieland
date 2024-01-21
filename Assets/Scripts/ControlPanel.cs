using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlPanel : MonoBehaviour
{
    public GameObject gameOverPanel;
    public static bool isGameOver = false;
    public Text text;

    void Start() {
        gameOverPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && !isGameOver) {
            isGameOver = true;
        }
        
        if (isGameOver) {
            gameOverPanel.SetActive(true);
            if (Metrics.highScore < Metrics.score) {
                Metrics.highScore = Metrics.score;
                PlayerPrefs.SetInt("highscore", Metrics.highScore);
            }
            if (Input.GetKeyDown(KeyCode.R)) {
                Metrics.lives = 5;
                Metrics.score = 0;
                gameOverPanel.SetActive(false);
                isGameOver = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
            }
        
            if (Input.GetKeyDown(KeyCode.Q)) {
                print("Application Quit");
                Application.Quit();
            }
        }
    }   
      
}
