using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerVSIa()
    {
        SceneManager.LoadScene("PlayerVSIA");
    }

    public void PlayerVSPlayer()
    {
        SceneManager.LoadScene("PlayerVSPlayer");

    }

    public void Space()
    {
        SceneManager.LoadScene("Space");
    }
}
