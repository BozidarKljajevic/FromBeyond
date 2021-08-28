using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<InputField>().characterLimit = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
