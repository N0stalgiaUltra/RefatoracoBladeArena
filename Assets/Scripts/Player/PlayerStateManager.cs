using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Context
public class PlayerStateManager : PlayerInput
{
    public PlayerMovement playerMov;
    public GroundCollider groundCollider;
    public Rigidbody2D playerRB;
    public Animator playerAnim;
    //abstract state
    BaseState currentState;

    //concrete state(s)
    public HurtState hurtState;
    public RunState runState;
    public JumpState jumpState;


    private void Awake()
    {
        runState = new RunState(playerMov, groundCollider);
        jumpState = new JumpState(playerMov);
        hurtState = new HurtState(playerAnim, playerRB);
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
