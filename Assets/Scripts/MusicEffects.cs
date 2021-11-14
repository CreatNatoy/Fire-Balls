using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicEffects : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _shotSound; 

    public void ShoutSound()
    {
        _audioSource.PlayOneShot(_shotSound); 
    }
}
