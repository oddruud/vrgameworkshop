using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class AudioOnImpact : MonoBehaviour {

    protected AudioSource audioSource;

    public float VelocityTreshold = 5f;

	// Use this for initialization
	void Awake () {
        audioSource = GetComponent<AudioSource>();	
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > VelocityTreshold) {
            audioSource.Play();
        }
    }

}
