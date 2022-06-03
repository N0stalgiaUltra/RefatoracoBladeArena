using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{   
    public Som[] sons;

    public static AudioManager instance;
    void Awake()
    {
        #region Singleton
        if (instance != null)
        {
            Destroy(instance);
        }
        else
        {
            instance = this;
        }
        #endregion

        foreach (Som s in sons)
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


    #region SoundMethods

    public void MenuSound() { Play("MusicaMenu"); }

    /// <summary>
    /// Called when someone wins the match
    /// </summary>
    public void VictorySound()
    {
        Stop("MusicaFundo");
        Play("MusicaVitoria");
    }

    public void BackgroundSound()
    {
        Play("MusicaFundo");
    }
    public void OpenUISound()
    {

        Stop("MusicaFundo");
        Play("AbreMenu");
    }

    /// <summary>
    /// Called to play the UI button click sound effect
    /// </summary>
    public void ClickButtonSound()
    {
        Play("ClicaBotao");

    }
    public void DaggerHitSound() { Play("ColisaoAdaga"); }

    public void PlatformHitSound() { Play("ColisaoPlataforma"); }

    public void ScoreSound() { Play("AlteraPlacar"); }
    public void RunSound() { Play("Passos"); }
   
    
    
    #endregion
}
