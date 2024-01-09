using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsScript : MonoBehaviour
{

    public float health;
    public float energy;
    public float attack;
    public float defense;
    public float speed;

    public int nextActTurn;

    private bool dead = false;

    public void calculateNextActTurn(int currentTurn)
    {
        this.nextActTurn = currentTurn + (int)Math.Ceiling(100.0f / this.speed);
    }
    public int CompareTo(object otherStats)
    {
        return nextActTurn.CompareTo(((StatsScript)otherStats).nextActTurn);
    }
    public bool isDead()
    {
        return this.dead;
    }
}