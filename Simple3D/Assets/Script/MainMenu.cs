using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
        Cursor.visible = false;
        DeathManager.instance.levelText.gameObject.SetActive(true);
        DeathManager.instance.LevelChange(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void LoadLevel(int level)
    {
        SceneManager.LoadScene(level);
        Time.timeScale = 1;
        Cursor.visible = false;
        DeathManager.instance.levelText.gameObject.SetActive(true);
        DeathManager.instance.LevelChange(level);
    }

}
