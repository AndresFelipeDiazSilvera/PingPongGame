using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gameUtils;

public class Goal : MonoBehaviour
{
    public bool player1Goal;
    public GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.CompareTag("Ball"))
        {
            IGameManager gameManagerComponent;
            if (gameManager.GetComponent<GameManager>())
            {
                gameManagerComponent = (IGameManager)gameManager.GetComponent<GameManager>();
            }else
            {
                gameManagerComponent = (IGameManager)gameManager.GetComponent<GameManagerSpace>();
            }
            if (player1Goal)
            {
                gameManagerComponent.Player1Scored();
            }

            else
            {
                gameManagerComponent.Player2Scored();
            }
        }
    }


}
