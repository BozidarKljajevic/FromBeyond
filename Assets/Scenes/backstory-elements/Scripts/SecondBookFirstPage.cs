using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondBookFirstPage : MonoBehaviour
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
        yield return new WaitForSeconds(56.5f);
        audio.Play();
        textNarrator.AddNarrator(textComponent, "They conducted a series of deadly experiments hoping to lure Death. It fell into the trap they had prepared. The scholars took aways its skull which rendered death powerless, unable to escape their trap. ", 0.12f);
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(94f);
        this.GetComponent<Animator>().enabled = true;
    }
}
