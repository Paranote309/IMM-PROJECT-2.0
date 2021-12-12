using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // private Rigidbody playerRb;
    public float speed = 45.0f;
    public GameObject  cueBallPrefab;
    public float verticalMouseRotation;
    public float horizontalInput;
    public float turnSpeed= 100.0f;
    // Start is called before the first frame update
    void Start()
    {
      // playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // move the cue sitck around the pool table
         // Code from Alan (https://github.com/alan-oregan)
         // Idea inspired from Olamide Animashaun (https://github.com/OlaAni)
        // rotating the pool stick vertically and vertically with mouse input
          float verticalMouseInput = Input.GetAxis("Mouse Y") * speed;
          horizontalInput = Input.GetAxis("Horizontal");

          verticalMouseRotation += verticalMouseInput;
          verticalMouseRotation = Mathf.Clamp(verticalMouseRotation, 0f, 360f); // sets rotation limits in degrees

          transform.localRotation = Quaternion.Euler(0f, verticalMouseRotation , 90f ); // set axis rotation
        if(Input.GetKey(KeyCode.Space)){
              transform.Translate(Vector3.right* Time.deltaTime * turnSpeed * horizontalInput);
              transform.Translate(Vector3.forward* Time.deltaTime *speed);
        }

        if (Input.GetMouseButtonDown(0)){
          Instantiate(cueBallPrefab , transform.position , cueBallPrefab.transform.rotation);
        }
    }
}
