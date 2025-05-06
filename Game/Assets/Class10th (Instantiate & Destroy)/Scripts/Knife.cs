using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : Weapon
{
    public  override string Attack()
    {
        Debug.Log("Knife Attack");
        return "Knife Attack";
    }
}
