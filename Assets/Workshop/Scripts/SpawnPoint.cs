using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public GameObject Prefab;

    public float SpawnDelay = 0f;
    public float SpawnInterval = 1f;

    private void Start()
    {
        Timer.Register(SpawnDelay, StartTimer);
    }

    private void SpawnObject()
    {
        GameObject.Instantiate(Prefab, transform.position, Quaternion.identity);
        StartTimer();
    }

    private void StartTimer() {
        Timer.Register(SpawnInterval, SpawnObject);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 1.0f);
    }



}
