using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Linq;

public class ConfigMenu : MonoBehaviour
{
    Resolution[] resolutions;
    public Dropdown resolutionDropdown;
    
    
    
    void Start() {
        //resolutions = resolutions = Screen.resolutions;
        resolutions = Screen.resolutions.Select(resolution => new Resolution { width = resolution.width, 
        height = resolution.height }).Distinct().ToArray(); 
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        
        int currentResolutionIndex = 0;
        for(int i =0; i<resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            /*
            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            currentResolutionIndex = i;*/

            if(resolutions[i].width == Screen.width && 
            resolutions[i].height == Screen.height)
            currentResolutionIndex = i;
        }


        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }    
    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }

    public void TesteVolume()
    {
        FindObjectOfType<AudioManager>().Play("Teste");
    }
    
    public void Fullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

}
