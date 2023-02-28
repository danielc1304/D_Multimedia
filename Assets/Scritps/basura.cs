using UnityEngine;

public class basura : MonoBehaviour
{
    AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSrc.pitch = Random.Range(-0.5f, 0.7f);
        audioSrc.Play();
    }
}
