using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour
{
    private AudioSource mySource;

    void Awake()
    {
        playDing();
    }

    public void playDing()
    {
        mySource = gameObject.GetComponent<AudioSource>(); //AudioSource.FindObjectOfType<AudioSource>();
        //mySource.clip = Instantiate(Resources.Load("196106__aiwha__ding")) as AudioClip;
        mySource.Play();
    }
}
