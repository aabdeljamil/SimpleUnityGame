using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SliderInfo : MonoBehaviour
{
    public bool paused = false;
    public Slider sldr;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyChildOnLoad(sldr.gameObject);
    }   

    void Update()
    {
        /*
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            sldr.gameObject.SetActive(false);
        }
        
        if (Input.GetButtonDown("Cancel") && paused == false)
        {
            sldr.gameObject.SetActive(true);
            paused = true;
        }
        if (Input.GetButtonDown("Cancel") && paused == true)
        {
            sldr.gameObject.SetActive(false);
            paused = false;
        }
        */
    }


    public static void DontDestroyChildOnLoad( GameObject child )
    {
        Transform parentTransform = child.transform;
 
        // If this object doesn't have a parent then its the root transform.
        while ( parentTransform.parent != null )
        {
            // Keep going up the chain.
            parentTransform = parentTransform.parent;
        }
        GameObject.DontDestroyOnLoad(parentTransform.gameObject);
    }
}
