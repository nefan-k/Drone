using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    void OnDestroy()
    {
        if (gameObject.scene.isLoaded)
        {
            SceneManager.LoadScene("Death");
        }
    }
}
