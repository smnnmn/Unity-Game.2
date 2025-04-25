using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    [SerializeField] int temperture;

    public void Increase()
    {
        temperture++;
        Debug.Log("temperture : " + temperture);
    }
}
