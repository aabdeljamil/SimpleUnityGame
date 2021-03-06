﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScreen : MonoBehaviour
{
    public static bool OpenPauseMenu = false;
    public static bool isDead = false;
    public Canvas canvas;
    public GameObject game;

    public void Pause()
    {
        if (isDead == false)
        {
            if (Input.GetButtonDown("Cancel"))
            {
                if (!OpenPauseMenu)
                {
                    Time.timeScale = 0;
                    canvas.gameObject.SetActive(true);
                    game.gameObject.SetActive(false);
                    Cursor.visible = true;
                    GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PauseMusic();
                }
                else
                {
                    Time.timeScale = 1;
                    canvas.gameObject.SetActive(false);
                    game.gameObject.SetActive(true);
                    Cursor.visible = false;
                    GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().ResumeMusic();
                }
                OpenPauseMenu = !OpenPauseMenu;
            }
        }
    }

    private void Update()
    {
        Pause();
    }
}
