using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject[] weapons;
    [SerializeField] Transform parentPosition;
    [SerializeField] List<GameObject> weaponsList;

    [SerializeField] Text attackText;

    [SerializeField] int count = 0;
    private void Start()
    {
        for(int i =0 ;i < weapons.Length; i++)
        {
            GameObject clone = Instantiate(weapons[i], parentPosition);

            clone.gameObject.SetActive(false);

            weaponsList.Add(clone);
        }
        weaponsList[count].SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }
        if(Input.GetMouseButtonDown(0))
        {
            Shot();
        }
    }
    public void Swap()
    {
        StartCoroutine(WeaponMotion());
        
        // weaponsList[index++ % weaponsList.Count].SetActive(false);
        // weaponsList[index % weaponsList.Count].SetActive(true);
    }
    IEnumerator WeaponMotion()
    {
        GameObject a = weaponsList[count]; // 내려갈 무기
        count = (count + 1) % weaponsList.Count; // 모듈러 연산
        GameObject b = weaponsList[count]; // 올라갈 무기

        b.transform.position += new Vector3(0, -0.5f, -0.2f); // 올라갈 시작 위치
        b.SetActive(true); // 올라갈 무기 활성화

        Vector3 aPos = a.transform.position; // 올라갈 무기가 도착할 위치
        Vector3 bPos = b.transform.position; // 내려갈 무기가 도착할 위치

        
        while(b.transform.position.y + 0.01f < aPos.y) // 올라갈 무기가 도착할 위치에 인접할 때 까지
        {
            a.transform.position = Vector3.Lerp(a.transform.position, aPos + new Vector3(0, -0.5f, -0.2f), 0.2f); // 자연스럽게 내려가기
            b.transform.position = Vector3.Lerp(b.transform.position, bPos + new Vector3(0, 0.5f, 0.2f), 0.2f); // 자연스럽게 올라가기
            yield return null;
        }
        b.transform.position = parentPosition.position; // 올라간 무기 최종 위치선정
        a.SetActive(false); // 내려간 무기 비활성화
        a.transform.position = parentPosition.position; // 내려간 무기 최종 위치선정
    }
    void Shot()
    {
        Weapon weapon = weaponsList[count].GetComponent<Weapon>();
        attackText.text = weapon.Attack();
        attackText.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    }
}
