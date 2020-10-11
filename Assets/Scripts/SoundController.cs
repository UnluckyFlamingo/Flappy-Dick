using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    public static SoundController instance;

    public AudioSource audioSourceScore;
    public AudioSource audioSourceDie;
    public AudioSource audioSourceJump;


    public void PlayScore()
    {
        audioSourceScore.Play();
    }
    public void PlayJump()
    {
        audioSourceJump.Play();
    }
    public void PlayDie()
    {
        audioSourceDie.Play();
    }

    private void Awake()
    {
        if(SoundController.instance == null)
        {
            SoundController.instance = this;
        }else if (SoundController.instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if(SoundController.instance == this)
        {
            SoundController.instance = null;
        }
    }
}
