using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterFade : MonoBehaviour
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
        yield return new WaitForSeconds(2.5f);
        textNarrator.AddNarrator(textComponent, "Let me tell you a story of how it all began. For centuries, mankind ", 0.12f);
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(50f);
        this.GetComponent<Animator>().enabled = true;
    }
}
