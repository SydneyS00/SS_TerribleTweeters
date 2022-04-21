using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeMenu : MonoBehaviour
{
    public static bool ChangeSound = false;
    public GameObject soundMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (ChangeSound)
            {
                Continue();
            }
        }
    }

    public void Continue()
    {
        soundMenuUI.SetActive(false);
        Time.timeScale = 1f;
        ChangeSound = false;
    }
}
