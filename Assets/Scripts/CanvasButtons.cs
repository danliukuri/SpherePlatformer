using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CanvasButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LevelManager");
    }
    public void LoadLevel(int number)
    {
        SceneManager.LoadScene("Level"+ number.ToString());
    }
    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StartMenu");
    }
}
