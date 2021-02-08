using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzik : MonoBehaviour
{
    [SerializeField]
    private AudioSource ses;
    [SerializeField]
    private AudioClip klib;
    void Start()
    {
        ses = this.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!ses.isPlaying)
        {
            ses.clip = klib;
            ses.Play();
        }
    }
}
