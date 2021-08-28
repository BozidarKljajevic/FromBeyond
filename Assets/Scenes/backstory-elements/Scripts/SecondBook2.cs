using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondBook2 : MonoBehaviour
{
    [SerializeField] private Narrator textNarrator;
    public AudioSource audio;
    private Text textComponent;

    public void Start()
    {
        StartCoroutine(Enable());
        StartCoroutine(FadeOut());
    }
    private void Awake()
    {
        textComponent = this.gameObject.GetComponent<Text>();
    }

    IEnumerator Enable()
    {
        yield return new WaitForSeconds(82.5f);
        audio.Play();
        textNarrator.AddNarrator(textComponent, "The painter realized the mistake they were making but none of his companions would listen.  ", 0.12f);
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(94f);
        this.GetComponent<Animator>().enabled = true;
    }
}
