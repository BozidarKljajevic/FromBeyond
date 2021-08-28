using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public GameObject wizard;
    public GameObject scholars;
    public GameObject hat;
    public GameObject tool;
    public GameObject death;
    public GameObject skull;
    public GameObject painter;
    public GameObject life1;
    public GameObject life2;
    public GameObject startButton;
    public GameObject startText;
    //public GameObject skip1;
    //public GameObject skip1Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WizardFadeIn());
        StartCoroutine(WizardFadeOut());
        StartCoroutine(ScholarsFadeIn());
        StartCoroutine(ScholarsFadeOut());
        StartCoroutine(HatFadeIn());
        StartCoroutine(HatFadeOut());
        StartCoroutine(ToolFadeIn());
        StartCoroutine(ToolFadeOut());
        StartCoroutine(DeathFadeIn());
        StartCoroutine(DeathFadeOut());
        StartCoroutine(SkullFadeIn());
        StartCoroutine(SkullFadeOut());
        StartCoroutine(PainterFadeIn());
        StartCoroutine(PainterFadeOut());
        StartCoroutine(Life1FadeIn());
        StartCoroutine(Life2FadeIn());
        StartCoroutine(Life2FadeOut());
        StartCoroutine(ButtonFadeIn()); 
        StartCoroutine(TextButtonFadeIn());
        //StartCoroutine(Skip1FadeIn());
        //StartCoroutine(Skip1FadeOut());
        //StartCoroutine(Skip1TextFadeIn());
        //StartCoroutine(Skip1TextFadeOut());

    }
    IEnumerator WizardFadeIn()
    {
        yield return new WaitForSeconds(2.5f);
        wizard.GetComponent<Animator>().enabled = true;
    }
    IEnumerator HatFadeIn()
    {
        yield return new WaitForSeconds(35f);
        hat.GetComponent<Animator>().enabled = true;
    }
    IEnumerator ToolFadeIn()
    {
        yield return new WaitForSeconds(35f);
        tool.GetComponent<Animator>().enabled = true;
    }
    IEnumerator ScholarsFadeIn()
    {
        yield return new WaitForSeconds(29.5f);
        scholars.GetComponent<Animator>().enabled = true;
    }
    IEnumerator DeathFadeIn()
    {
        yield return new WaitForSeconds(62f);
        death.GetComponent<Animator>().enabled = true;
    }
    IEnumerator SkullFadeIn()
    {
        yield return new WaitForSeconds(62f);
        skull.GetComponent<Animator>().enabled = true;
    }
    IEnumerator PainterFadeIn()
    {
        yield return new WaitForSeconds(82.5f);
        painter.GetComponent<Animator>().enabled = true;
    }
    IEnumerator Life1FadeIn()
    {
        yield return new WaitForSeconds(100.5f);
        life1.GetComponent<Animator>().enabled = true;
    }
    IEnumerator Life2FadeIn()
    {
        yield return new WaitForSeconds(100.5f);
        life2.GetComponent<Animator>().enabled = true;
    }
    /*IEnumerator Skip1FadeIn()
    {
        yield return new WaitForSeconds(2.5f);
        skip1.SetActive(true);
        //skip1.GetComponent<Animator>().enabled = true;
    }
    IEnumerator Skip1FadeOut()
    {
        yield return new WaitForSeconds(53.5f);
        //skip1.GetComponent<Animator>().enabled = false;
        //skip1.SetActive(false);
    }*/
    /*IEnumerator Skip1TextFadeIn()
    {
        yield return new WaitForSeconds(2.5f);
        skip1Text.GetComponent<Animator>().enabled = true;
    }*/

    /*IEnumerator Skip1TextFadeOut()
    {
        yield return new WaitForSeconds(50f);
        skip1Text.GetComponent<Animator>().SetBool("skip1TextFadeOut", true);
    }*/
    IEnumerator ButtonFadeIn()
    {
        yield return new WaitForSeconds(131.5f);
        startButton.SetActive(true);
        startButton.GetComponent<Animator>().enabled = true;
    }
    IEnumerator TextButtonFadeIn()
    {
        yield return new WaitForSeconds(132.5f);
        startText.GetComponent<Animator>().enabled = true;
    }
    IEnumerator WizardFadeOut()
    {
        yield return new WaitForSeconds(50f);
        wizard.GetComponent<Animator>().SetBool("wizardFadeOut", true);
    }
    IEnumerator ScholarsFadeOut()
    {
        yield return new WaitForSeconds(50f);
        scholars.GetComponent<Animator>().SetBool("scholarsFadeOut", true);
    }
    IEnumerator HatFadeOut()
    {
        yield return new WaitForSeconds(50f);
        hat.GetComponent<Animator>().SetBool("hatFadeOut", true);
    }
    IEnumerator ToolFadeOut()
    {
        yield return new WaitForSeconds(50f);
        tool.GetComponent<Animator>().SetBool("toolFadeOut", true);
    }
    IEnumerator DeathFadeOut()
    {
        yield return new WaitForSeconds(94f);
        death.GetComponent<Animator>().SetBool("deathFadeOut", true);
    }
    IEnumerator SkullFadeOut()
    {
        yield return new WaitForSeconds(68.5f);
        skull.GetComponent<Animator>().SetBool("skullFadeOut", true);
    }
    IEnumerator PainterFadeOut()
    {
        yield return new WaitForSeconds(94f);
        painter.GetComponent<Animator>().SetBool("painterFadeOut", true);
    }
    IEnumerator Life2FadeOut()
    {
        yield return new WaitForSeconds(106.5f);
        life2.GetComponent<Animator>().SetBool("life2FadeOut", true);
    }

}
