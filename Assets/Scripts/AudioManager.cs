using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   
    public AudioSource audioSource;
    [SerializeField]
    private AudioClip newComboSound;
    [SerializeField]
    private AudioClip oldComboSound;

    private void Start() 
    {
        audioSource = gameObject.GetComponent<AudioSource>();    
    }

    public void PlayOldCombo()
    {
       
        audioSource.Play();
        Debug.Log("old sound");
    }

     public void PlayNewCombo()
    {
       audioSource.Play();
        Debug.Log("new sound");
    }
}
