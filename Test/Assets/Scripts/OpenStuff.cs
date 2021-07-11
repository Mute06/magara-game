using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStuff : MonoBehaviour
{
    public GameObject[] stuff;


    public void OpenTheStuff()
    {
        foreach (var item in stuff)
        {
            item.SetActive(true);
        }
    }

    public void CloseTheStuff()
    {
        foreach (var item in stuff)
        {
            item.SetActive(false);
        }
    }
}
