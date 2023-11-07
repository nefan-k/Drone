using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeBomb : MonoBehaviour
{
    public float explosionRadius = 10f;
    public Color gizmosColor = Color.red;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = gizmosColor;
        Gizmos.DrawSphere(transform.position, explosionRadius);
    }

    void OnDestroy() {
        Collider[] hitColliders = Physics.OverlapSphere(
            transform.position, 
            explosionRadius
        );

        foreach(var hitCollider in hitColliders)
        {
            if(hitCollider.transform.root.tag == "Destructable")
            {
                Destroy(hitCollider.gameObject);
                Destroy(gameObject);
                ScoreKeeper.AddScore(1);
            }
        }
    }
}
