using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    // Start is called before the first frame update
    public AudioClip Background;

    void Start()
    {
        musicSource.clip=Background;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
