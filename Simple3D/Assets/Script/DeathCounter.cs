using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DeathCounter : MonoBehaviour
{
    public static DeathCounter instance;
    public Text text;
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

    public void LevelCount()
    {
        text.text = "Level " + SceneManager.GetActiveScene().buildIndex.ToString();
    }

}
