using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward); 
        if (Physics.Raycast(ray, 0.5f + speed * Time.deltaTime))
            Destroy(gameObject);
        else
            transform.Translate(
                transform.forward * speed * Time.deltaTime, 
                Space.World
            );
    }
}
