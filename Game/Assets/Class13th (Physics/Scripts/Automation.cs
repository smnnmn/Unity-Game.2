using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automation : MonoBehaviour
{
    [SerializeField] bool state;
    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        StartCoroutine(Coroutine());
    }
    private void FixedUpdate()
    {
        if(state)
        {
            rigidBody.AddForce(direction, ForceMode.Impulse);
            state = false;
        }
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            state = true;
        }
    }
    IEnumerator Coroutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(5);
            state = true;
        }
    }
}
