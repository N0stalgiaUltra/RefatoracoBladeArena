using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{   
    public Som[] sons;

    void Awake()
    {
        //DontDestroyOnLoad(gameObject);
        foreach(Som s in sons)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.som;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string nome)
    {
        Som s = Array.Find(sons, som => som.nome == nome);
        s.source.Play();
    }
    public void Stop(string nome)
    {
        Som s = Array.Find(sons, som => som.nome == nome);
        s.source.Stop();
    }
}
