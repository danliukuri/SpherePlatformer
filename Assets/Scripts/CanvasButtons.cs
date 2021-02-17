using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CanvasButtons : MonoBehaviour
{
    public void LoadLevelSelector()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LevelManager");
    }
    public void LoadLevel(int number)
    {
        SceneManager.LoadScene("Level"+ number.ToString());
    }
    public void LoadStartMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StartMenu");
    }
    public void QuitTheGame()
    {
#if (UNITY_EDITOR)
        UnityEditor.EditorApplication.isPlaying = false;
#elif (UNITY_STANDALONE) 
        Application.Quit();
#elif (UNITY_WEBGL)
        Application.OpenURL("https://yuriy-danyliuk.itch.io/");
#endif
    }
}
