using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // OnTriggerEnter : 물리적이지 않은 충돌을 했을 때
        // 호출되는 이벤트 함수입니다.
    }
    private void OnTriggerStay(Collider other)
    {
        Battery battery = other.GetComponent<Battery>();

        battery.Increase();

        // OnTriggerEnter : 물리적이지 않은 충돌을 했을 때
        // 호출되는 이벤트 함수입니다.
    }
    private void OnTriggerExit(Collider other)
    {
        // OnTriggerEnter : 물리적이지 않은 충돌을 했을 때
        // 호출되는 이벤트 함수입니다.
    }

}
