using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public GameObject p1, p2, menuPause, menuConfig, telaVitoria;
    public Transform adagasp1, adagasp2;
    bool estaPausado;


    // Start is called before the first frame update
    void Start()
    {
        telaVitoria.SetActive(false);
        //FindObjectOfType<AudioManager>().Stop("MusicaVitoria");
    }

    // Update is called once per frame
    void Update()
    {
     
        ////posicao da qtd de adagas do p1
        //Vector3 txtPos = Camera.main.WorldToScreenPoint(adagasp1.transform.position);
        //adagasText.transform.position = txtPos;
        ////pos da qtd de adagas do p2
        //Vector3 txtPos2 = Camera.main.WorldToScreenPoint(adagasp2.transform.position);
        //adagasText2.transform.position = txtPos2;
        
    }


    

}
