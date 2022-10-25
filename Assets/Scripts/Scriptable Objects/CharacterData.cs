using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "BladeArena/Create Player Data")]
public class CharacterData : ScriptableObject
{
    public float velocity;
    public float jumpTimer;
    public float jumpFactor;
    public float shootRate;
}


