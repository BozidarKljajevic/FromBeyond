using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private bool isTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WaitForHalfASecond1());
        //StartCoroutine(WaitForHalfASecond2());
    }
    IEnumerator WaitForHalfASecond1()
    {
        yield return new WaitForSeconds(10f);
        //this.GetComponent<Animator>().SetBool("idle", false);
        this.GetComponent<Animator>().SetBool("wave", true);
        StartCoroutine(WaitForHalfASecond2());
    }
    IEnumerator WaitForHalfASecond2()
    {
        yield return new WaitForSeconds(4f);
        this.GetComponent<Animator>().SetBool("wave", false);
    }

}
