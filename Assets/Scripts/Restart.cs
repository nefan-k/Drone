using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public KeyCode resetCode = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(resetCode))
            SceneManager.LoadScene("Menu");
    }
}
