using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBallScript : MonoBehaviour

{
    public GameObject otherBall;
    public AudioClip potSound;
    public AudioSource ballAudio;
    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

    }

    void onDestroy(){
        ballAudio.PlayOneShot(potSound, 1.0f);
    }
}
