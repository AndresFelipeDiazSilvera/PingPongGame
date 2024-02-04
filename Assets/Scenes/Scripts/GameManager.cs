using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using gameUtils;

public class GameManager : MonoBehaviour, IGameManager
{
    public GameObject ball;

    public GameObject player1;
    public GameObject palyer1Goal;

    public GameObject player2;
    public GameObject player2Goal;

    public Text player1Text;
    public Text player2Text;

    private int player1Scored;
    private int player2Scored;

    public bool IAGame;

    public int maxScore = 5;

    public void checkVictory()
    {
        if (player1Scored == maxScore)
        {
            SceneManager.LoadScene("Player1Win");
        }

        if (player2Scored == maxScore)
        {
            SceneManager.LoadScene("Player2Win");
        }
    }

    public void Player1Scored()
    {
        player1Scored++;
        player1Text.text = player1Scored.ToString();
        checkVictory();
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2Scored++;
        player2Text.text = player2Scored.ToString();
        checkVictory();
        ResetPosition();
    }

    private void ResetPosition()
    {
        if (IAGame)
        {
            ball.GetComponent<Ball>().Reset();
            player2.GetComponent<Players>().Reset();
        }
        else
        {
            ball.GetComponent<Ball>().Reset();
            player1.GetComponent<Players>().Reset();
            player2.GetComponent<Players>().Reset();
        }
 
    }

}
