using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack
{

    public string name;
    public string color;
    public string damage;
    public int size;

    public Attack(string name, string color, string damage, int size)
    {
        this.name = name;
        this.color = color;
        this.damage = damage;
        this.size = size;
    }
}
