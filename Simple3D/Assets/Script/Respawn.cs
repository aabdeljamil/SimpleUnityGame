using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;
    public static bool isDead;
    public DeathText text;
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(DieScreen());
    }

    IEnumerator DieScreen()
    {
        player.gameObject.SetActive(false);
        text.TurnOn();
        yield return new WaitForSeconds(1.5f);
        text.TurnOff();
        player.transform.position = respawnPoint.transform.position;
        player.gameObject.SetActive(true);
    }
}
