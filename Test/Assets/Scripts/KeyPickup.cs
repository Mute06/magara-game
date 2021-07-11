using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public Key key;
    public GameObject KeyImage;

    private void OnTriggerEnter(Collider other)
    {
        KeyManager.instance.AddKey(key);
        if (KeyImage != null)
        {
            KeyImage.SetActive(true);
        }
        Destroy(gameObject);
    }
}
