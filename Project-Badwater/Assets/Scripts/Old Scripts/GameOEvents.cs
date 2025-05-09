//Change scene event system
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //SceneManager.LoadScene("Forest");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        //SceneManager.LoadScene("TestStartScene"); //SceneManager.LoadScene("Forest"); 
        SceneManager.LoadScene("TextIntro"); //SceneManager.LoadScene("Forest"); 
    }

    public void MenuScene()
    {
        // SceneManager.LoadScene("Credits");
        SceneManager.LoadScene("MainScene"); //SceneManager.LoadScene("Forest"); 
    }
    public void CreditsScene()
    {
        SceneManager.LoadScene("Credits"); //SceneManager.LoadScene("Forest"); 
    }
}
