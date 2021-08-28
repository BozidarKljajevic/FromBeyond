using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdBook2 : MonoBehaviour
{
    [SerializeField] private Narrator textNarrator;
    public AudioSource audio;
    private Text textComponent;

    public void Start()
    {
        StartCoroutine(Enable());
        //StartCoroutine(FadeOut());
    }
    private void Awake()
    {
        textComponent = this.gameObject.GetComponent<Text>();
    }

    IEnumerator Enable()
    {
        yield return new WaitForSeconds(110.5f);
        audio.Play();
        textNarrator.AddNarrator(textComponent, "The natural cycle of life and death had been broken, leaving humanity with a variety  of  otherwise fatal diseases which are now, without death, worse than they had ever been.  ", 0.11f);
    }
}
