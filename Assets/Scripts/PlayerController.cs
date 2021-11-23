using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
      playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // move the cue sitck around the pool table
        float forwardInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.forward * speed * forwardInput);
    }
}
