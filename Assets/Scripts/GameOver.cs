using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    void Update() {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Your Score: " + Metrics.score.ToString() + "\nHigh Score: " + PlayerPrefs.GetInt("highscore") + "\nPress r to restart!\nPress q to quit!";
    }
}
