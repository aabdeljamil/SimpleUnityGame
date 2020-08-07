using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;
    public DeathText text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            StartCoroutine(DieScreen());
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
