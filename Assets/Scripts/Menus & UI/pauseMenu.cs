using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool pausado = false;


    public bool Pausar()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
            return false;
        }
        else
        {
            Time.timeScale = 0;
            return true;
        }
    }
}
