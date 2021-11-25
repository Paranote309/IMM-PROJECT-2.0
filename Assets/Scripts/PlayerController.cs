using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // private Rigidbody playerRb;
    public float speed = 5.0f;
    public GameObject  cueBallPrefab;
    public float horizontalMouseRotation;
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
        // rotating the pool stick vertically and horizontally with mouse input
          float horizontalMouseInput = Input.GetAxis("Mouse X") * speed;
          
          horizontalMouseRotation += horizontalMouseInput;
          horizontalMouseRotation = Mathf.Clamp(horizontalMouseRotation, 0f, 360f); // sets rotation limits in degrees

          transform.localRotation = Quaternion.Euler(0f, 0f , horizontalMouseRotation); // set axis rotation

        if (Input.GetMouseButtonDown(0)){
          Instantiate(cueBallPrefab , transform.position , cueBallPrefab.transform.rotation);
        }

    }
//     private void onMouseDown(){
//       Instantiate(cueBallPrefab , transform.position , cueBallPrefab.transform.rotation);
//     }
}
