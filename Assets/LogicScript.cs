using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int player_score = 0;
    public Text score;

    public void addScore() {
        player_score++;
        score.text = player_score.ToString();
    }
}
