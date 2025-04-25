using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // OnTriggerEnter : ���������� ���� �浹�� ���� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    }
    private void OnTriggerStay(Collider other)
    {
        Battery battery = other.GetComponent<Battery>();

        battery.Increase();

        // OnTriggerEnter : ���������� ���� �浹�� ���� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    }
    private void OnTriggerExit(Collider other)
    {
        // OnTriggerEnter : ���������� ���� �浹�� ���� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
    }

}
