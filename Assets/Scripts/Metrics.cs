using UnityEngine;
using UnityEngine.UI;

public class Metrics : MonoBehaviour
{
    public static int score = 0;
    public static int lives = 5;
    public static int highScore = 0;

    public void Update() {
      GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + score.ToString() + " | Lives: " + lives + "/5";
    }

}
