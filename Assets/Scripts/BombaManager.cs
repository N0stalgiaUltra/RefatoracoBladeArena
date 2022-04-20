using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class BombaManager : MonoBehaviour
{
    //isso aqui é um singleton, n se atentem a isso agr.
    #region Singleton
    private static BombaManager _instance;
    public static BombaManager Instance => _instance;

    private void Awake() {
        if(_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    #endregion
    


    //variaveis de Game Object
    public GameObject bomba, player1, player2;
    /*
    public void LancaAdaga()
    {
        GameObject a;
        a = Instantiate
    }*/

    //função para colocar as bombas
    public void ColocaBombaP1()
    {
       //crio um objeto vazio de nome b para armazenar as bombas criadas
       GameObject b;
       //instancio a bomba criada na posição e rotação do player1
       b = Instantiate(bomba, player1.transform.position, player1.transform.rotation);
       //destruo o objeto vazio com a bomba num tempo de 3s
       Destroy(b, 3f);
       //tudo se repete para o Player2
    }
       public void ColocaBombaP2()
    {
       //cria particula
       //deleta particula
       GameObject b;
       b = Instantiate(bomba, player2.transform.position, player2.transform.rotation);
       Destroy(b, 3f);

    }
}
 