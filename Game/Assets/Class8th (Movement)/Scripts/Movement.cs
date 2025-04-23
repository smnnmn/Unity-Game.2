using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        transform.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(transform.rotation.eulerAngles.x, direction.x * (-60), 0.5f));

        direction.Normalize();

        // Time.deltaTime
        // ������ �������� �Ϸ��Ѥ��� ����� �ð��� �� ������ ��ȯ�ϴ� �ð��Դϴ�.

        transform.position += direction * Time.deltaTime * speed;
    }
}
