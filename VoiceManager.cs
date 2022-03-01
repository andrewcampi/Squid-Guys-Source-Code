using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceManager : MonoBehaviour
{
    public AudioSource voice1;
    public AudioSource voice2;
    public AudioSource voice3;
    public AudioSource voice4;
    public AudioSource voice5;

    public void playRandomVoiceAtLocation(GameObject guy)
    {

        int choice = Random.Range(1, 6);
        if (choice == 1)
        {
            AudioSource.PlayClipAtPoint(voice1.clip, guy.transform.position);
        }
        else if (choice == 2)
        {
            AudioSource.PlayClipAtPoint(voice2.clip, guy.transform.position);
        }
        else if (choice == 3)
        {
            AudioSource.PlayClipAtPoint(voice3.clip, guy.transform.position);
        }
        else if (choice == 4)
        {
            AudioSource.PlayClipAtPoint(voice4.clip, guy.transform.position);
        }
        else
        {
            AudioSource.PlayClipAtPoint(voice5.clip, guy.transform.position);
        }
    }
}
