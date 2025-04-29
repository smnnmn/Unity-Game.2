using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject[] weapons;
    [SerializeField] Transform parentPosition;
    [SerializeField] List<GameObject> weaponsList;

    int index = 0;
    private void Start()
    {
        for(int i =0;i < weapons.Length; i++)
        {

        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
}
