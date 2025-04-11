using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public Creature()
    {
        Debug.Log("Creature");
        Stat stat = new Stat();
        stat.health = 10;
        stat.level = 3;
        stat.name = "MonMon";
    }
}
