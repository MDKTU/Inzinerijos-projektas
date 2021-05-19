using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoserMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Scene 1");
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}