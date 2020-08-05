using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScreen : MonoBehaviour
{
    public GameObject ball;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            this.gameObject.SetActive(true);
        }
    }
    void LateUpdate()
    {
        transform.position = ball.transform.position;
    }
}
