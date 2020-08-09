using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomLoadNextLevel : MonoBehaviour
{
    public float transitionTime = 1f;
    public int random;
    public Transform player;
    public Transform respawnPoint;
    public DeathText text;

    private void OnTriggerEnter(Collider other)
    {
        random = UnityEngine.Random.Range(1, 10);
        if (random < 3)
        {
            other.gameObject.SetActive(false);
            LoadnxtLevel();
        }
        else if (other.gameObject.CompareTag("Player"))
            StartCoroutine(DieScreen());

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

    IEnumerator DieScreen()
    {
        pauseScreen.isDead = true;
        player.gameObject.SetActive(false);
        text.TurnOn();
        yield return new WaitForSeconds(1.5f);
        text.TurnOff();
        player.transform.position = respawnPoint.transform.position;
        playerMovement.rb.velocity = new Vector3(0, 0, 0);
        player.gameObject.SetActive(true);
        pauseScreen.isDead = false;

    }
}
