using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFX;
    
    // Start is called before the first frame update
    [SerializeField]public AudioClip Background;
    [SerializeField]public AudioClip click;
    [SerializeField]public AudioClip ratle;
    [SerializeField]public AudioClip switcch;
    [SerializeField]public AudioClip windd;


    void Start()
    {
        musicSource.clip=Background;
        musicSource.Play();
    }

    public void resetSound()
    {
        SFX.clip=click;
        SFX.Play();
    }
    public void lever()
    {
        SFX.clip=switcch;
        SFX.Play();
    }
    public void wind()
    {
        SFX.clip=windd;
        SFX.Play();
    }
    public void stop()
    {
        SFX.Stop();
    }
}
