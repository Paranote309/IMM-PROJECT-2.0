using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsHole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onTriggerEnter(Collider other){
             Destroy(other.gameObject);
    }
}
