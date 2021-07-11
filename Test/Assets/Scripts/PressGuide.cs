using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressGuide : MonoBehaviour
{
    public GameObject img;

    private bool isEnabled = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player") && !isEnabled)
        {
            img.SetActive(true);
            isEnabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && isEnabled)
        {
            img.SetActive(false);
            isEnabled = false;
        }
    }
}