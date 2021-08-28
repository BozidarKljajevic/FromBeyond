using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorySecondPart : MonoBehaviour
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
        yield return new WaitForSeconds(11f);
        textNarrator.AddNarrator(textComponent, "has been seeking a way to extend their lifespans, dreaming of one day achieving immortality.", 0.11f);
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(50f);
        this.GetComponent<Animator>().enabled = true;
    }
}
