using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource music;
    void Start()
    {
        music = transform.Find("RadioMusic").gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        if(music.isPlaying)
        {
            music.Pause();
        } else
        {
            music.Play();
        }
    }
}
