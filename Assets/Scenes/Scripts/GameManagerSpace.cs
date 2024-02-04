using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using gameUtils;

public class GameManagerSpace : MonoBehaviour, IGameManager
{
    public GameObject ball;

    public GameObject player1;
    public GameObject palyer1Goal;

    public GameObject player2;
    public GameObject player2Goal;

    public Text player1Text;
    public Text player2Text;

    public Text player1TextLives;
    public Text player2TextLives;

    private int player1Lives = 3;
    private int player2Lives = 3;

    private int player1Scored;
    private int player2Scored;

    public bool IAGame;
    public bool hasLives;


    public void checkVictory()
    {
        if (player1Lives <= 0)
        {
            SceneManager.LoadScene("Player2Win");
        }

        if (player2Lives <= 0)
        {
            SceneManager.LoadScene("Player1Win");
        }
    }

    public void checkLives()
    {
        if (player1Scored == 3)
        {
            player1Scored = 0; player2Scored = 0;
            player1Text.text = player1Scored.ToString(); player2Text.text = player2Scored.ToString();
            player2Lives--; player2TextLives.text = player2Lives.ToString();
        }
        if (player2Scored == 3)
        {
            player1Scored = 0;
            player2Scored = 0; player1Text.text = player1Scored.ToString();
            player2Text.text = player2Scored.ToString(); player1Lives--;
            player1TextLives.text = player1Lives.ToString();
        }
    }
    public void Player1Scored()
    {
        player1Scored++; player1Text.text = player1Scored.ToString();
        checkLives(); 
        checkVictory();
        ResetPosition();
    }
    public void Player2Scored()
    {
        player2Scored++;
        player2Text.text = player2Scored.ToString(); 
        checkLives();
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
