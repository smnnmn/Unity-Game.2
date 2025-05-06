using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rivolver : Weapon
{
    public  override string Attack()
    {
        Debug.Log("Rivolver Attack");
        return "Rivolver Attack";
    }
}
