using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Creats array of Audio Clips that can be used in the background
    public AudioClip[] audioArr;

    // Gets a variable for the audioSource
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //At the start of the game, randomly pick an audioclip and play it from the audiosource
        int randomNum = Random.Range(0, 3);
        audioSource.clip = audioArr[randomNum];
        audioSource.Play();
    }

    
}
