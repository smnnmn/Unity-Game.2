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
        // 마지막 프레임이 완료한ㄴ데 경과한 시간을 초 단위로 반환하는 시간입니다.

        transform.position += direction * Time.deltaTime * speed;
    }
}
