using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public static bool pausado = false;


    // Update is called once per frame
    void Update()
    {
       
    }

    public bool Pausar()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
            return(false);
        }
        else
        {
            Time.timeScale = 0;
            return(true);
        }
    }
}
