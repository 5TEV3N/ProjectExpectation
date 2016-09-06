using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour
{
    private AudioSource mySource;

    void Awake()
    {
        mySource = gameObject.GetComponent<AudioSource>(); //AudioSource.FindObjectOfType<AudioSource>();
    }

    public void playDing()
    {
        mySource.Play();
    }
}
