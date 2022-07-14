using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Context
public class PlayerStateManager : PlayerInput
{
    public PlayerMovement playerMov;
    public ReconheceChao groundCollider;
    public PlayerData playerData;
    //abstract state
    BaseState currentState;

    //concrete state(s)
    public HurtState hurtState = new HurtState();
    public IdleState idleState; 
    public RunState runState;
    public JumpState jumpState;


    private void Awake()
    {
        idleState = new IdleState();
        runState = new RunState(playerMov);
        jumpState = new JumpState(playerMov);
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

/*
    idle -> run : com movimento
    idle -> jump : quando ele não está no chão

 
 */