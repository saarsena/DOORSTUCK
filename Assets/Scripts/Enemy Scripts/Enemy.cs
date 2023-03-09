using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    abstract public float Health { get; set; }
    abstract public float Mana { get; set; }
    abstract public float ArmorValue { get; set; }
    abstract public float AttackValue { get; set; }
    abstract public int NumberOfAttacks { get; set; }
    abstract public int Str { get; set; }
    abstract public int Dex { get; set; }
    abstract public int Con { get; set; }
    abstract public int Int { get; set; }
    abstract public int Wis { get; set; }
    abstract public int Cha { get; set; }
    abstract public bool IsEnemy { get; set; }
}