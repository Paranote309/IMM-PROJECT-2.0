using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f;
    Rigidbody RB;
 
     // Use this for initialization
     void Start () {
         RB = GetComponent<Rigidbody>();
         RB.velocity = transform.forward * 5.0f;
     }

    //https://answers.unity.com/questions/1591845/how-do-the-ball-moving-like-billiard-after-collisi.html
     void OnCollisionEnter(Collision col)
     {
         if (col.collider.tag != "Wall") return;
         Vector3 newVector=Vector3.Reflect(transform.forward, col.contacts[0].normal);
         RB.velocity = newVector * RB.velocity.magnitude;
         transform.forward = newVector.normalized;
     }

}
