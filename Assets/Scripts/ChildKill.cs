using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildKill : MonoBehaviour
{
    private int childCount;

    private void Awake()
    {
        childCount = transform.childCount;
    }

    private void Update()
    {
        if (transform.childCount < childCount)
            Destroy(gameObject);
    }
}
