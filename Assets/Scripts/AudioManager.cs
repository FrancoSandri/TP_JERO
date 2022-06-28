using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip derrota;
    public AudioSource fuenteAudio;
    public AudioClip salto;
    public AudioClip victoria;
    public AudioClip caida;
    public AudioClip danio;
    public AudioClip checkpoint;
    public GameObject MusicFondo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayDerrota()
    {
        fuenteAudio.clip = derrota;
        fuenteAudio.Play();
        MusicFondo.SetActive(false);
    }
    public void PlaySalto()
    {
        fuenteAudio.clip = salto;
        fuenteAudio.Play();
    }
    public void PlayVictoria()
    {
        fuenteAudio.clip = victoria;
        fuenteAudio.Play();
        MusicFondo.SetActive(false);
    }
    public void PlayCaida()
    {
        fuenteAudio.clip = caida;
        fuenteAudio.Play();
    }
    public void PlayDanio()
    {
        fuenteAudio.clip = danio;
        fuenteAudio.Play();
    }
    public void PlayCheckpoint()
    {
        fuenteAudio.clip = checkpoint;
        fuenteAudio.Play();
    }
}
