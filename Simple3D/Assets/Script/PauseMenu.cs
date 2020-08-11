using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Canvas canvas;
    public GameObject game;

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
        DeathManager.instance.levelText.gameObject.SetActive(false);
    }

    public void ResumeGame()
    {
        pauseScreen.OpenPauseMenu = !pauseScreen.OpenPauseMenu;
        Time.timeScale = 1;
        canvas.gameObject.SetActive(false);
        game.gameObject.SetActive(true);
        Cursor.visible = false;
    }
}
