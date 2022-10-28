using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStateManager : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMov;
    [SerializeField] private PlayerShoot playerShoot;
    [SerializeField] private GroundCollider groundCollider;
    [SerializeField] private Rigidbody2D playerRB;
    [SerializeField] private Animator playerAnim;
    

    //abstract state
    BaseState currentState;

    //concrete state(s)
    public HurtState hurtState;
    public RunState runState;
    public JumpState jumpState;


    private void Awake()
    {
        runState = new RunState(this.playerMov, this.groundCollider, this.playerShoot);
        jumpState = new JumpState(this.playerMov, this.groundCollider);
        hurtState = new HurtState(this.playerAnim, this.playerRB);
    }
    void Start()
    {

        currentState = runState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(BaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

    void FixedUpdate()
    {
        currentState.PhysicsUpdate(this);
    }
}
