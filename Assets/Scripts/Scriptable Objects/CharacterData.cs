using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "BladeArena/Create Character Data")]
public class CharacterData : ScriptableObject
{
    public float Velocity;
    public float JumpTimer;
    public float JumpFactor;
    public float ShootRate;
    public Sprite MainSprite;
    public int CharIndex;
}


