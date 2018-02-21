using UnityEngine;
using System.Collections;

public class BallLaucher : MonoBehaviour {

    public GameObject ballPrefab;
    public float ballSpeed=5.0f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject instance = Instantiate(ballPrefab);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            Camera camera = GetComponentInChildren<Camera>();
            rb.velocity = camera.transform.rotation * Vector3.forward *ballSpeed;
        }
    }
}
