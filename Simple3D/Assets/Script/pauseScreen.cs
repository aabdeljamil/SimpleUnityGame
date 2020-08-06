using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScreen : MonoBehaviour
{
    public bool OpenPauseMenu = false;
    public Canvas canvas;
    public GameObject game;
    public void Pause()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (!OpenPauseMenu)
            {
                Time.timeScale = 0;
                canvas.gameObject.SetActive(true);
                game.gameObject.SetActive(false);
            }
            else
            {
                Time.timeScale = 1;
                canvas.gameObject.SetActive(false);
                game.gameObject.SetActive(true);
                Cursor.visible = false;
            }
            OpenPauseMenu = !OpenPauseMenu;
        }
    }

    private void Update()
    {
        Pause();
    }
}
