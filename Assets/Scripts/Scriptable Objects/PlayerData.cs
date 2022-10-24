using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "BladeArena/Create Player Data")]
public class PlayerData : ScriptableObject
{
    public float velocity;
    public float jumpTimer;
    public float jumpFactor;
}

