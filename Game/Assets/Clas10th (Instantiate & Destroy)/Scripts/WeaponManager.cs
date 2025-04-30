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
        GameObject a = weaponsList[count]; // ������ ����
        count = (count + 1) % weaponsList.Count; // ��ⷯ ����
        GameObject b = weaponsList[count]; // �ö� ����

        b.transform.position += new Vector3(0, -0.5f, -0.2f); // �ö� ���� ��ġ
        b.SetActive(true); // �ö� ���� Ȱ��ȭ

        Vector3 aPos = a.transform.position; // �ö� ���Ⱑ ������ ��ġ
        Vector3 bPos = b.transform.position; // ������ ���Ⱑ ������ ��ġ

        
        while(b.transform.position.y + 0.01f < aPos.y) // �ö� ���Ⱑ ������ ��ġ�� ������ �� ����
        {
            a.transform.position = Vector3.Lerp(a.transform.position, aPos + new Vector3(0, -0.5f, -0.2f), 0.2f); // �ڿ������� ��������
            b.transform.position = Vector3.Lerp(b.transform.position, bPos + new Vector3(0, 0.5f, 0.2f), 0.2f); // �ڿ������� �ö󰡱�
            yield return null;
        }
        b.transform.position = parentPosition.position; // �ö� ���� ���� ��ġ����
        a.SetActive(false); // ������ ���� ��Ȱ��ȭ
        a.transform.position = parentPosition.position; // ������ ���� ���� ��ġ����
    }
    void Shot()
    {
        Weapon weapon = weaponsList[count].GetComponent<Weapon>();
        attackText.text = weapon.Attack();
        attackText.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    }
}
