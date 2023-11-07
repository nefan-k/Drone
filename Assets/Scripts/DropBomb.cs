using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBomb : MonoBehaviour
{
    public Transform dropPoint;
    public Transform bombPrefab;
    public KeyCode activationKey = KeyCode.Space;

    void Update()
    {
        if(Input.GetKeyDown(activationKey) && AmmoKeeper.ammo > 0)
        {
            var t = Instantiate(bombPrefab);
            t.position = dropPoint.position;
            t.rotation = transform.rotation;
            AmmoKeeper.DepleetAmmo();
        }
    }
}
