using System.Collections;
using UnityEngine;
 
public class RotChange : MonoBehaviour {
 
    float rot_duration = 500F;
    float rot_speed = 0.25F;
    Quaternion final_rot;

    // Use this for initialization
    void Start () {
        final_rot = transform.rotation;
    }

    IEnumerator rotateOBJ () {
        final_rot = final_rot * Quaternion.Euler (0, 0, 180);
        float rot_elapsedTime = 0.0F;
        while (rot_elapsedTime < rot_duration) {
            transform.rotation = Quaternion.Slerp (transform.rotation, final_rot, rot_elapsedTime);
            rot_elapsedTime += Time.deltaTime * rot_speed;
            yield return null;
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown ("Vertical")) StartCoroutine ("rotateOBJ");
    }
}