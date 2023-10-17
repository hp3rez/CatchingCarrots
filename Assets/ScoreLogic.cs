using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;
    [SerializeField] AudioSource click;

    [ContextMenu("Increase Score")]

    public void addScore(int scoreToAdd)
    {
        click.Play();
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
}
