using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadNextLevel : MonoBehaviour
{
    public float transitionTime = 1f;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        LoadnxtLevel();
        Cursor.visible = false;
    }

    public void LoadnxtLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        switch (SceneManager.GetActiveScene().buildIndex + 1)
        {
            case 3:
                LevelSelect.pass2 = true;
                break;
            case 4:
                LevelSelect.pass3 = true;
                break;
            case 5:
                LevelSelect.pass4 = true;
                break;
            case 6:
                LevelSelect.pass5 = true;
                break;
            case 7:
                LevelSelect.pass6 = true;
                break;
            case 8:
                LevelSelect.pass7 = true;
                break;
            case 9:
                LevelSelect.pass8 = true;
                break;
            case 10:
                LevelSelect.pass9 = true;
                break;
            default:
                break;
        }
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
