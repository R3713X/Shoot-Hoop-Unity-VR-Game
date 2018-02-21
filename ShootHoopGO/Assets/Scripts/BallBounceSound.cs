using UnityEngine;
using System.Collections;

public class BallBounceSound : MonoBehaviour {

	
	void OnCollisionEnter(Collision collision)
    {
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
}
