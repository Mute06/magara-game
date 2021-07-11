using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour, IDoor
{
    [SerializeField] private UnityEvent onOpenEvent;

    [SerializeField] private UnityEvent onCloseEvet;

    private Animator animator;
    private int isOpenHash;
    private void Start()
    {
        animator = GetComponent<Animator>();
        isOpenHash = Animator.StringToHash("isOpen");
    }

    public void OpenDoor()
    {
        if (!animator.GetBool(isOpenHash))
        {
            animator.SetBool(isOpenHash, true);
            onOpenEvent.Invoke();
        }
        else
        {
            animator.SetBool(isOpenHash, false);
        }
    }

    public void CloseDoor()
    {
        if (animator.GetBool(isOpenHash))
        {
            animator.SetBool(isOpenHash, false);
            onCloseEvet.Invoke();
        }
        else
        {
            animator.SetBool(isOpenHash, true);
        }
    }

    
}
