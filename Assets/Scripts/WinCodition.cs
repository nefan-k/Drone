using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCodition : MonoBehaviour
{
    private void Update()
    {
        if (transform.childCount == 0)
            SceneManager.LoadScene("Win");
    }
}
