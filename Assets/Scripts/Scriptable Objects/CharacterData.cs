using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "BladeArena/Create Character Data")]
public class CharacterData : ScriptableObject
{
    //TODO: CHANGE THE VELOCITIES TO A SINGLE OBJECT
    public float Velocity;
    public float JumpTimer;
    public float JumpFactor;
    public float ShootRate;
    public CharacterCardData cardData;
    //public CharacterPrefabData prefabData;
}


