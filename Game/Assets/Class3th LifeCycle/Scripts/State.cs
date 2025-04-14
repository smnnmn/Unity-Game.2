using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    private void Awake()
    {
        // Awake �Լ���?
        // ���� ������Ʈ�� �����Ǿ��� �� �� �� ���� ȣ��Ǹ�,
        // ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ��ִ� ���¿����� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        // OnEnable �Լ���?
        // ���� ������Ʈ�� Ȱ��ȭ�Ǵ� �������� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnEnable");
    }
    private void Start()
    {
        // Start �Լ���?
        // ���� ������Ʈ�� �����Ǿ��� �� �� �� ���� ȣ��Ǹ�,
        // ��ũ��Ʈ�� ��Ȱ��ȭ�� �� ���� ��, ȣ����� �ʴ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("Start");
    }
}
