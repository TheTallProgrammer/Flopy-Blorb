using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("increase score")]
    public void addScore(int scoreToAdd) {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartScene() {
        SceneManager.LoadSceneAsync("GameScene"); // reload the current game scene instead of going back to the start screen, as they've already started 
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }

}
