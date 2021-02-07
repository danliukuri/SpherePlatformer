using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Lava"))
        {
            animator.SetBool("isFallingIntoLava", true);
        }
        if (collider.CompareTag("Portal"))
        {
            animator.SetBool("isPlayerInPortal", true);
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Lava"))
        {
            animator.SetBool("isFallingIntoLava", false);
        }
        if (collider.CompareTag("Portal"))
        {
            animator.SetBool("isPlayerInPortal", false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void EventFinished(string parameterName) => animator.SetBool(parameterName, false);
}
