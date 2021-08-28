using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    bool isTime = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Wait());
        
    }

    IEnumerator DisableLightning()
    {
        yield return new WaitForSeconds(1f);
        this.gameObject.GetComponent<Animator>().enabled = false;
        isTime = false;
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5f);
        if (isTime)
        {
            this.gameObject.GetComponent<Animator>().enabled = true;
            this.gameObject.GetComponent<AudioSource>().enabled = true;
            StartCoroutine(DisableLightning());
            StartCoroutine(EnableLightning());
            StartCoroutine(Sound());
        }
    }

    IEnumerator EnableLightning()
    {
        yield return new WaitForSeconds(15f);
        isTime = true;
    }

    IEnumerator Sound()
    {
        yield return new WaitForSeconds(7f);
        this.gameObject.GetComponent<AudioSource>().enabled = false;
    }
}
