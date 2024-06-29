using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int player_score = 0;
    public Text score;
    public GameObject GameOverScreen;

    public void addScore() {
        player_score++;
        score.text = player_score.ToString();
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver() {
        GameOverScreen.SetActive(true);
    }
}
