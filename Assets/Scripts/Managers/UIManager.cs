using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text adagasText;
    public Text adagasText2;
    public Text p1Hp;
    public Text p2Hp;
    public Text placar1, placar2;
    public Text Vitoria;
    public GameObject p1, p2, menuPause, menuConfig, telaVitoria;
    public Transform adagasp1, adagasp2;
    bool estaPausado;


    // Start is called before the first frame update
    void Start()
    {
        telaVitoria.SetActive(false);
        FindObjectOfType<AudioManager>().Stop("MusicaVitoria");
    }

    // Update is called once per frame
    void Update()
    {
     
        //posicao da qtd de adagas do p1
        Vector3 txtPos = Camera.main.WorldToScreenPoint(adagasp1.transform.position);
        adagasText.transform.position = txtPos;
        //pos da qtd de adagas do p2
        Vector3 txtPos2 = Camera.main.WorldToScreenPoint(adagasp2.transform.position);
        adagasText2.transform.position = txtPos2;
        
    }
    public void Config()
    {
        menuPause.SetActive(false);
        menuConfig.SetActive(true);
        AudioManager.instance.ClickButtonSound();
    }
    public void VoltaMenu()
    {
        AudioManager.instance.ClickButtonSound();
        SceneManager.LoadScene("menu");

    }
    public void Continuar()
    {
        AudioManager.instance.ClickButtonSound();
        menuPause.SetActive(false);
        Time.timeScale = 1;
        estaPausado = false;
         
    }
    public void VoltaPauseMenu()
    {
        AudioManager.instance.ClickButtonSound();
        menuPause.SetActive(true);
        menuConfig.SetActive(false);
    }
    public void ReiniciarPartida()
    {
        AudioManager.instance.ClickButtonSound();
        SceneManager.LoadScene("01");
    }
    public void VitoriaP1()
    {
         FindObjectOfType<AudioManager>().Stop("MusicaFundo");
         FindObjectOfType<AudioManager>().Play("MusicaVitoria");
         Time.timeScale = 0;
         Vitoria.text = "Player 1 Wins!";
         telaVitoria.SetActive(true);
         GameManager.Instance.placar1 = 0;
    }

    public void VitoriaP2()
    {
         FindObjectOfType<AudioManager>().Stop("MusicaFundo");
         FindObjectOfType<AudioManager>().Play("MusicaVitoria");
         Time.timeScale = 0;
         Vitoria.text = "Player 2 Wins!";
         telaVitoria.SetActive(true);
         GameManager.Instance.placar2 = 0;
    }
}
