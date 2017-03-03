using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnImpact : MonoBehaviour
{
    public GameObject Prefab;

    [Header("the minimum impact velocity for the spawn to occur")]
    public float VelocityTreshold;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > VelocityTreshold)
        {
            if (Prefab != null)
                GameObject.Instantiate(Prefab, collision.contacts[0].point, Quaternion.identity);
            else
                Debug.LogWarning("Je moet de prefab nog toekennen!");
        }
    }
}
