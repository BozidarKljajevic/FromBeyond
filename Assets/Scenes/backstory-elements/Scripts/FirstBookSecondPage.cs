using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstBookSecondPage : MonoBehaviour
{
    [SerializeField] private Narrator textNarrator;
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
        yield return new WaitForSeconds(24.5f);
        textNarrator.AddNarrator(textComponent, "Many years ago, led by an idea of eternal life, four great scholars of those times, one of them - a painter, gathered in dark, secluded chambers in order to devise a plan to capture Death itself.", 0.13f);
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(50f);
        this.GetComponent<Animator>().enabled = true;
    }
}
