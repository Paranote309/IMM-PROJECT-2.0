using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardDetectCollisions : MonoBehaviour
{
    public AudioClip potSound;
    public AudioSource ballAudio;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Hard Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Ball"))
        {
        ballAudio.PlayOneShot(potSound, 1.0f);
        Destroy(other.gameObject);
        gameManager.UpdateScore(1);
        Debug.Log("Pocketed");
        }
        
    }

    }

