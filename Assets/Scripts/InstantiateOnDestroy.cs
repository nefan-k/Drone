using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOnDestroy : MonoBehaviour
{
    public Transform prefab;

    private bool gameIsShuttingDown = false;
 
    void OnApplicationQuit()
    {
        gameIsShuttingDown = true;
    }

    void OnDestroy() {
        if(!gameIsShuttingDown)
        {
            var t = Instantiate(prefab);
            t.position = transform.position;
        }
    }
}
