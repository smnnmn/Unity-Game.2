using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    [SerializeField] AudioManager audioManager;
    [SerializeField] AudioClip audioClip;
    [SerializeField] float soundTime;
    [SerializeField] float time;
    private void Start()
    {
        StartCoroutine(SoundPlay());
        audioManager = FindObjectOfType<AudioManager>();
        time = Random.Range(0, 6);
    }
    /*private void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            time = Random.Range(0, 6);
            audioManager.Listener(audioClip);
        }
    }
    */
    IEnumerator SoundPlay()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(0.5f,soundTime));
            audioManager.Listener(audioClip);
            // AudioManager.Instance.Listener(audioClip);
            StartCoroutine(Long());
        }
    }
    IEnumerator Long()
    {
        while (transform.localScale.y + 0.01f <= 2)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1, 2, 1), 0.3f);
            yield return null;
        }
        while(transform.localScale.y - 0.01f >= 1)
        {
            Debug.Log(gameObject.name);
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1, 1, 1), 0.3f);
            yield return null;
        }
    }
}
