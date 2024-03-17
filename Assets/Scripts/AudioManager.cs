using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource[] music;
    public AudioSource[] sfx;

    public int randomMusic;

    private float startDelay =2;
    private float spawnInterval = 20;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        randomMusic = Random.Range(0, music.Length);
        PlayMusic(randomMusic);

        InvokeRepeating("SFXRandom", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void PlayMusic(int musicToPlay)
    {
        music[musicToPlay].Play();
    }

    public void PlaySFX(int sfxToPlay)
    {
        sfx[sfxToPlay].Play();
    }

    public void StopPlaySFX(int sfxToPlay)
    {
        sfx[sfxToPlay].Stop();
    }

    public void StopPlayMusic(int musicStop)
    {
        music[musicStop].Stop();
    }

    public void SFXRandom()
    {
        int randomSFX = Random.Range(0, sfx.Length);
        Debug.Log("Efecto");
        sfx[randomSFX].Play();
    }
}
