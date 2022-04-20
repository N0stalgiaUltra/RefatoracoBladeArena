using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    //chamada de variaveis
    //essas variaveis fazerm referencia aos objetos do tipo GameObject
    /*Objetos do tipo GameObject são basicamente todas as entidades na Unity, então 
    pensem em GameObject como uma superclasse para todos os objetos. 
    Por exemplo: temos um script proprio para a classe Bomba, porém aqui eu 
    referencio o 'objeto' bomba, ao invés da classe, pois Bomba é um Game Object acima de tudo.
    */
   
    /* obs: a Unity utiliza de linguagem orientada a objeto, então imaginem uma receita de bolo
    essa receita contém todos os ingredientes para a criação de um bolo.
    Se trouxessemos para esse contexto, a receita de bolo seria a Classe; os ingredientes 
    seriam os Atributos; enquanto o bolo, seria a instancia da classe, ou seja, o objeto gerado.
    */
    //aqui eu referencio os objetos: player1, player2 e bomba
    public GameObject p1;
    public GameObject p2;
    public GameObject bomba;
    public GameObject adaga;
    GameObject posAdaga, posAdaga2;

    //essas variaveis fazerm referencia ao componente RigidBody
    //Rigidbody é conhecido por simular a física em um objeto
    Rigidbody2D rb; // para o player1
    Rigidbody2D rb2;// para o player2

    //aqui eu crio um float(a grosso modo: pode usar casas decimais) para definir um valor de velocidade
    public float velo = 15f;
    //aqui eu criei float para armazenar os Inputs horizontais e verticais de cada jogador
    //p1 = player1, p2 = player2
    public float p1x;
    public float p1y;
    float p2x;
    float p2y;
    Vector2 jump;
    public float jumpForce;
    public bool chao1;
    public bool chao2;
   
    // Start é chamada no inicio de cada frame
    void Start()
    {
        //aqui eu referencio as variaveis de Rigidbody
        /*
        O GetComponent serve para atribuir componentes adicionados via inspector(aquela aba na direita)
        nesse caso, estamos atribuindo o componente Rigidbody2D para as duas variaveis
        */
        rb = p1.GetComponent<Rigidbody2D>();
        rb2 = p2.GetComponent<Rigidbody2D>();
        posAdaga = GameObject.Find("posAdaga");
        posAdaga2 = GameObject.Find("posAdaga2");
        jump = new Vector2(0f, 2f);
        //jumpForce = 2f;
        
    }

    // Update é chamada uma vez por frame
    void Update()
    {
        chao1 = p1.GetComponent<PlayerManager>().isGrounded;
        chao2 = p2.GetComponent<PlayerManager>().isGrounded;
    }
    void FixedUpdate()
    {
        
        p1x = Input.GetAxis("Horizontal");
        //p1y = Input.GetAxis("Vertical");
        p2x = Input.GetAxis("Horizontal2");
        //p2y = Input.GetAxis("Vertical2");
        
        rb.velocity = new Vector2(velo * p1x, 0);
        rb2.velocity = new Vector2(velo * p2x, 0);   

        if(p1x > 0){
        p1.transform.eulerAngles = new Vector3(0,0,0);
        //rb.velocity = new Vector2(p1x * velo, 0);   
        }
        
        else if(p1x < 0)
        {
        p1.transform.eulerAngles = new Vector3(0,180,0);
        //rb.velocity = new Vector2(p1x * velo, 0); 
        }

        else if(Input.GetButtonDown("Jmp"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        
        if(p1y > 0 && chao1 == true) 
        rb.velocity = new Vector2(0, p1y * velo);

        if(p2x < 0)
        p2.transform.eulerAngles = new Vector3(0,0,0);
        else if(p2x > 0)
        p2.transform.eulerAngles = new Vector3(0,180,0);
    
        //criar um GO para definir onde pular
        //get a girl
        //get a life
        //do a freelance job
        /*
        else if (Input.GetKeyDown("space") && m_grounded) {
            m_animator.SetTrigger("Jump");
            m_grounded = false;
            m_animator.SetBool("Grounded", m_grounded);
            m_body2d.velocity = new Vector2(m_body2d.velocity.x, m_jumpForce);
            m_groundSensor.Disable(0.2f);
        }*/

    }

    
}
