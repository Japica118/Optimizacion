using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [SerializeField] private AudioClip bulletSFX;

    private AudioSource _audioSource;

    void Awake()
    {
       _audioSource = GetComponent<AudioSource>();
    }

     public void BulletSound()
    {
        _audioSource.PlayOneShot(bulletSFX);
    }


}
