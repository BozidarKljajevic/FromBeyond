using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject key;

    [SerializeField]
    private GameObject skull;

    public void CollectedKey()
    {
        key.SetActive(true);
    }

    public void CollectedSkull()
    {
        skull.SetActive(true);
    }

    public void ThrowOutSkull()
    {
        skull.SetActive(false);
    }
}
