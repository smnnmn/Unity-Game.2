using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Text[] textList;
    [SerializeField] string[] buttonText;
    private void Start()
    {
        for(int i  = 0; i < textList.Length; i++)
        {
            textList[i].text = buttonText[i];
        }
    }
    public void Execute()
    {
        Debug.Log("Execute");
    }
    public void Shop()
    {
        Debug.Log("Shop");
    }
    public void Quit()
    {
        Debug.Log("Quit");
    }
}
