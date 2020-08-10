using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelSelect : MonoBehaviour
{
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button level6;
    public Button level7;
    public Button level8;
    public Button level9;
    public Button level10;

    public static bool pass2;
    public static bool pass3;
    public static bool pass4;
    public static bool pass5;
    public static bool pass6;
    public static bool pass7;
    public static bool pass8;
    public static bool pass9;
    public static bool pass10;

    public void ActivateLevel()
    {
        if (pass2)
            level2.interactable = true;
        if (pass3)
            level3.interactable = true;
        if (pass4)
            level4.interactable = true;
        if (pass5)
            level5.interactable = true;
        if (pass6)
            level6.interactable = true;
        if (pass7)
            level7.interactable = true;
        if (pass8)
            level8.interactable = true;
        if (pass9)
            level9.interactable = true;
        if (pass10)
            level10.interactable = true;
    }
}
