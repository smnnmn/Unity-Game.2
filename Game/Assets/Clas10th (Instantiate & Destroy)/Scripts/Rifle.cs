using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    public  override string Attack()
    {
        Debug.Log("Rifle Attack");
        return "Rifle Attack";
    }
}
