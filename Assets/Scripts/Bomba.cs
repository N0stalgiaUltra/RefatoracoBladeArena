using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    //chamada dos objetos que contém os colisores, um em cada direção
    public GameObject cima, baixo, esq, dir;
  
    
    

    void Update()
    {
        /*
        if(Input.GetKey(KeyCode.L))
        {
            cima.SetActive(true);
            baixo.SetActive(true);
            esq.SetActive(true);
            dir.SetActive(true);
        }
        else
        {
            cima.SetActive(false);
            baixo.SetActive(false);
            esq.SetActive(false);
            dir.SetActive(false);
        }*/


    }
    /*
        Aqui tratamos de colisões do tipo "trigger", esse tipo de colisão é como um gatilho "invisivel"
        para isso eu referenciei as caixas de colisão da bomba após a explosão, assim como é no Bomberman.

        Nesse caso, as colisões são reconhecidadas de n maneiras e uma delas é por tag, ou seja, colocamos
        um identificador em um dado objeto e a colisão será reconhecida por conta disso.

        no nosso caso, reconhecemos colisão, por enquanto, no jogador e nos "obstaculos"
        então eu peço pra destruir os obstaculos que entrarem em colisão(do tipo trigger) 
        com os colisores da bomba.

        obs: para haver colisão é necessário um colisor no objeto e um ridigbody.
    */
   
    //ao entrar em colisão trigger..
    private void OnTriggerEnter2D(Collider2D other) {
        
        //..com um objeto com a tag obstaculo..
        if(other.gameObject.tag == "Obstaculo")
        {
            //referenciei obstaculo aqui(podia ter referenciado antes, n tem problema)
            GameObject Obstaculos = GameObject.FindWithTag("Obstaculo");
            //..destroi o obstaculo instantaneamente
            Destroy(Obstaculos);
        }

        //..com um objeto com a tag de player
        if(other.gameObject.tag == "Player")
        {
            //..envia uma mensagem ao console da Unity reconhecendo a colisão
            // sobre Debug.log e console, n tenham medo, eu explico com calma pra vcs 
            //(junto de colisores e outras paradas)
            Debug.Log("Dano");
        }
    }
}
