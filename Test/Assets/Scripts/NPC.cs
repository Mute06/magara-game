using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NPC : MonoBehaviour
{
    public UnityEvent ThingsToDo;
    public Key thisKeyWillBeGiven;
    public GameObject KeyImage;
    private bool didTalked;

    private void OnTriggerEnter(Collider other)
    {
        if (!didTalked)
        {
            KeyManager.instance.AddKey(thisKeyWillBeGiven);
            if (KeyImage != null)
            {
                KeyImage.SetActive(true);
            }
            ThingsToDo.Invoke();
            didTalked = true;
        }
    }
}
