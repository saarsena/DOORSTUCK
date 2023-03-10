using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : Enemy
{
    public float health = 100f;
    public float mana = 100f;
    public float armorValue = 0;
    public float attackValue = 2f;
    public int numberOfAttacks = 1;
    public int str = 10;
    public int dex = 10;
    public int con = 10;
    public int intel = 10;
    public int wis = 10;
    public int charis = 10;
    public bool isEnemy = true;

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
    public override float Mana
    {
        get
        {
            return mana;
        }
        set
        {
            mana = value;
        }
    }
    public override float ArmorValue
    {
        get
        {
            return armorValue;
        }
        set
        {
            armorValue = value;
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
    public override int Str
    {
        get { return str; }
        set { str = value; }
    }
    public override int Dex
    {
        get { return dex; }
        set { dex = value; }
    }
    public override int Con
    {
        get { return con; }
        set { con = value; }
    }
    public override int Int
    {
        get { return intel; }
        set { intel = value; }
    }
    public override int Wis
    {
        get { return wis; }
        set { wis = value; }
    }
    public override int Cha
    {
        get { return charis; }
        set { charis = value; }
    }
    public override bool IsEnemy
    {
        get { return isEnemy; }
        set { isEnemy = value; }
    }
}
