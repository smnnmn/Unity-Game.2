using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : Weapon
{
    protected override void Attack()
    {
        Debug.Log("Knife Attack");
    }
}
