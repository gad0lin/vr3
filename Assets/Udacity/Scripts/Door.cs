using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip doorLockedSound;
    public AudioClip doorOpenSound;
    private bool locked = true;
    private bool opening = false;
    private float startTime;
    private float journeyLength;
   


    void Update() {
        if (opening) {
          transform.position = Vector3.Slerp(new Vector3(0,0,0), new Vector3(0, 8, 0), (Time.time - startTime)/10 );
        }
    }

    public void OnDoorClicked() { 

        if (locked)
        {
            audioSource.clip = doorLockedSound;

        }  else
        {
            audioSource.clip = doorOpenSound;
            opening = true;
            startTime = Time.time;
            
        }
        audioSource.Play();
    }

    public void Unlock()
    {
        locked = false;
    }
}
