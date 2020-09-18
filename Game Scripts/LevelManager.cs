using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene ("Main");
    }

    public void Level2()
    {
        SceneManager.LoadScene ("Level2");
    }

    public void Level3()
    {
        SceneManager.LoadScene ("Level3");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene ("Instruction");
    }

    public void GameStory()
    {
        SceneManager.LoadScene ("Story");
    }

    public void GameMenu()
    {
        SceneManager.LoadScene ("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit ();
    }
}
