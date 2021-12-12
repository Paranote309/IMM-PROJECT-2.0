using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    Rigidbody RB;
 
     // Use this for initialization
     void Start () {
         RB = GetComponent<Rigidbody>();
         RB.velocity = transform.forward * 20f;
     }
 
     void OnCollisionEnter(Collision col)
     {
         if (col.collider.tag != "Wall") return;
         Vector3 newVector=Vector3.Reflect(transform.forward, col.contacts[0].normal);
         RB.velocity = newVector * RB.velocity.magnitude;
         transform.forward = newVector.normalized;
     }

}
