using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    protected override void Attack()
    {
        Debug.Log(damage + "�� ���ݷ�");
    }
}
