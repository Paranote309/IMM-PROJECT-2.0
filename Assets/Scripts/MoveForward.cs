using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 1.0f;
    public float force = 0.1f;
    private Rigidbody ballRb;
    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody>();
        ballRb.AddForce(Vector3.forward *force , ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}

