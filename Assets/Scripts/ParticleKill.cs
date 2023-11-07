using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKill : MonoBehaviour
{
    void Start() {
        ParticleSystem parts = GetComponent<ParticleSystem>();
        float totalDuration = parts.duration + parts.startLifetime;
        Destroy(gameObject, totalDuration);
    }
}