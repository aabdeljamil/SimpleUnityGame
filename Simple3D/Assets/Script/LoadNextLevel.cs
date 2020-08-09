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
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
