using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public GameObject config, creditos, menu, cj, onlineMenu;
     void Start() {
        Screen.SetResolution(1024, 768, false);
        FindObjectOfType<AudioManager>().Play("MusicaMenu");    
    }

    public void ComoJogar()
    {
        FindObjectOfType<AudioManager>().Play("ClicaBotao");
        menu.SetActive(false);
        cj.SetActive(true);
    }

    public void VoltarComoJogar()
    {
        FindObjectOfType<AudioManager>().Play("ClicaBotao");
        menu.SetActive(true);
        cj.SetActive(false);
    }

    public void Creditos()
    {
        FindObjectOfType<AudioManager>().Play("ClicaBotao");
        menu.SetActive(false);
        creditos.SetActive(true);
    }

    public void VoltarCreditos()
    {
        FindObjectOfType<AudioManager>().Play("ClicaBotao");
        menu.SetActive(true);
        creditos.SetActive(false);
    }
    public void Config()
    {
        FindObjectOfType<AudioManager>().Play("ClicaBotao");
        config.SetActive(true);
    }
    public void Voltar()
    {
        FindObjectOfType<AudioManager>().Play("ClicaBotao");
        config.SetActive(false);
    }
    public void Iniciar()
    {
        FindObjectOfType<AudioManager>().Play("ClicaBotao");
        SceneManager.LoadScene(1);
    }

    public void Sair()
    {
        FindObjectOfType<AudioManager>().Play("ClicaBotao");
        Application.Quit();
    }

    public void OnlineMenu()
    {
        FindObjectOfType<AudioManager>().Play("ClicaBotao");
        onlineMenu.SetActive(true);
    }
} 
