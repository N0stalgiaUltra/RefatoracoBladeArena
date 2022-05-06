using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{


    public int hp = 100;
    public GameObject p1, p2;
    public GameObject adaga;
    [SerializeField] Transform goAdaga, goAdaga2;
    public float velo;
    public float shotTimer = 1.5f;
    public float shotTimer2 = 1.5f;
    public int adagaQtd;
    public int adagaQtd2;
    
    
    public bool isGrounded;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        p1 = GameObject.Find("Player1");
        p2 = GameObject.Find("Player2");
        //goAdaga2 = GameObject.Find("posAdaga2");
        rb = gameObject.GetComponent<Rigidbody2D>();
        //adaga = GameObject.FindWithTag("Adaga");
        adagaQtd = 3;
        adagaQtd2 = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        //bool estaPausado = pauseMenu.pausado;
        bool estaPausado = false;
        shotTimer -= Time.deltaTime;
        shotTimer2 -= Time.deltaTime;

        if(estaPausado == false) 
        {

            //if (Input.GetButtonDown("Fire1") && this.gameObject == p1)
            //{
            //    GameObject a = Instantiate(adaga, goAdaga.transform.position, goAdaga.transform.rotation);
            //    if (shotTimer <= 0f)
            //    {
                    
            //        //FindObjectOfType<AudioManager>().Play("LancaAdaga");
            //        //Destroy(a, 3.5f);
            //        //altera esse 
            //        shotTimer = 0.5f;
            //        adagaQtd--;
            //        if (adagaQtd == 0)
            //        {
            //            shotTimer = 1f;
            //            adagaQtd = 3;
            //        }
            //    }
            //}

            //if (Input.GetButtonDown("Fire2") && this.gameObject == p2)
            //{
            //    if(shotTimer2 <= 0f)
            //    {
            //        GameObject b = Instantiate(adaga, goAdaga2.transform.position, goAdaga2.transform.rotation);    
            //        FindObjectOfType<AudioManager>().Play("LancaAdaga");
            //        Destroy(b, 3.5f);
            //        //altera esse
            //        shotTimer2 = 0.5f;
            //        adagaQtd2--;
            //        if(adagaQtd2 == 0)
            //        {
            //            shotTimer2 = 1f;
            //            adagaQtd2 = 3;
            //        }   
            //    }
            //}

        }
          
    }
  
}
