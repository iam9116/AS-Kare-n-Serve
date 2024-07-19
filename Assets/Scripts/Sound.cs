using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public float vol = 0.05f;
    public float initialVol = 0.1f;
    public float maxVol = 0.7f;

    private AudioSource Soundd;

    // Start is called before the first frame update
    void Start()
    {
        Soundd = GetComponent<AudioSource>();
        Soundd.volume = initialVol;

        InvokeRepeating("IncreaseVolume", 0.5f, (int)(maxVol - initialVol) / vol);
    }

    private void FixedUpdate()
    {
       
    }

    public void PlaySoundWhenClicked()
    {
        
    }

    private void IncreaseVolume()
    {
        if (Soundd.volume >= maxVol) return;
        Soundd.volume += vol;
    }
}
