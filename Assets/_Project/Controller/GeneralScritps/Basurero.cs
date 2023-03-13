using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basurero : MonoBehaviour
{
    [SerializeField] private string tagbasura;
    AudioSource audioSrc;
    [SerializeField] private AudioClip badAudio;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagbasura))
        {
            audioSrc.Play();
            Destroy(other.gameObject);
        }
        else if (other.transform.CompareTag("Botella") || other.transform.CompareTag("Servilleta") || other.transform.CompareTag("Bateria") || other.transform.CompareTag("Cascara"))
        {
            audioSrc.PlayOneShot(badAudio);
            Destroy(other.gameObject);
        }
    }
}
