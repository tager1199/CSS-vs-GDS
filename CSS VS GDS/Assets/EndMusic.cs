using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMusic : MonoBehaviour
{

    AudioSource audioData;


    // Start is called before the first frame update
    void Start()
        {
            DontDestroyOnLoad(this.gameObject);
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        }
}
