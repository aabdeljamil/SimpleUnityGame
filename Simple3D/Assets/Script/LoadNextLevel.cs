using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    public float transitionTime = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            LoadnextLevel();
        }
    }

    public void LoadnextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        switch (SceneManager.GetActiveScene().buildIndex + 1)
        {
            case 2:
                LevelSelect.pass2 = true;
                break;
            case 3:
                LevelSelect.pass3 = true;
                break;
            case 4:
                LevelSelect.pass4 = true;
                break;
            case 5:
                LevelSelect.pass5 = true;
                break;
            case 6:
                LevelSelect.pass6 = true;
                break;
            case 7:
                LevelSelect.pass7 = true;
                break;
            case 8:
                LevelSelect.pass8 = true;
                break;
            case 9:
                LevelSelect.pass9 = true;
                break;
            default:
                break;
        }
         GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
        Cursor.visible = false;
        if ((SceneManager.GetActiveScene().buildIndex + 1) == 10)
        {
            Cursor.visible = true;
            DeathManager.instance.DeathEnd();
        }    
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
        DeathManager.instance.LevelChange(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
