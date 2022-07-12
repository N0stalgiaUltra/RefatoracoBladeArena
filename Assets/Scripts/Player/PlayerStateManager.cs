using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Context
public class PlayerStateManager : PlayerInput
{
    public Transform playerTransform;
    public Rigidbody2D rb;
    public Animator animator;
    public PlayerData playerData;

    //abstract state
    BaseState currentState;

    //concrete state(s)
    public HurtState hurtState = new HurtState();
    public IdleState idleState = new IdleState();
    public RunState runState;
    public JumpState jumpState = new JumpState();


    private void Awake()
    {
        runState = new RunState(rb, animator, playerTransform);
    }
    void Start()
    {
        currentState = idleState;
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

}
