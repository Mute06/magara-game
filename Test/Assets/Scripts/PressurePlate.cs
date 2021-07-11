using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] private UnityEvent onTriggerEvent;
    [SerializeField] private UnityEvent onTriggerExitEvent;
    int boolHash;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        boolHash = Animator.StringToHash("hasTriggered");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Obstacle"))
        {
            animator.SetBool(boolHash, true);
            onTriggerEvent.Invoke();
        }
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Obstacle"))
        {
            animator.SetBool(boolHash, false);
            onTriggerExitEvent.Invoke();
        }
    }
}
