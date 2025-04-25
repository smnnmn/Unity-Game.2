using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform parentPosition;
    private void Start()
    {
        Instantiate(prefab,parentPosition);
    }
}
