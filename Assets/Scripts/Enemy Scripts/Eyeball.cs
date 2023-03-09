using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyeball : Enemy
{
    public float health = 100f;
    public float attackValue = 2f;
    public int numberOfAttacks = 1;

    public override float Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }
    public override float AttackValue
    {
        get
        {
            return attackValue;
        }
        set
        {
            attackValue = value;
        }
    }

    public override int NumberOfAttacks
    {
        get
        {
            return numberOfAttacks;
        }
        set
        {
            numberOfAttacks = value;
        }
    }
}
