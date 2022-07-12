using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Context
public class PlayerStateManager : MonoBehaviour
{
    //abstract state
    BaseState currentState;

    //concrete state(s)
    public HurtState hurtState = new HurtState();
    public IdleState idleState = new IdleState();
    public RunState runState = new RunState();
    public JumpState jumpState = new JumpState();

    public PlayerInput playerInput;
    public Animator animator;
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

    public BaseState CurrentState { get => this.currentState; }
}
