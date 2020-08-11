using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathManager : MonoBehaviour
{
    public static DeathManager instance;
    public Text text;
    int deaths;
    public Text levelText;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(this.gameObject);
    }

    public void ChangeDeaths(int death)
    {
        deaths += death;
        text.text = "Deaths: " + deaths.ToString();
    }

    public void LevelChange(int level)
    {
        levelText.text = "Level " + level.ToString();
    }

}
