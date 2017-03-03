using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionOnImpact : MonoBehaviour {

    public float explosionForce = 100f;
    public float explosionRadius = 10f;

    public bool DestroySelfOnImpact = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody != null)
            collision.rigidbody.AddExplosionForce(explosionForce, collision.contacts[0].point, explosionRadius, 10f, ForceMode.Impulse);


        if (DestroySelfOnImpact)
            GameObject.Destroy(gameObject);
    }
}
