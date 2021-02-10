using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointAnimation : MonoBehaviour
{
    [SerializeField] string strTag;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("xPosition") == transform.position.x &&
            PlayerPrefs.GetFloat("yPosition") == transform.position.y &&
            PlayerPrefs.GetFloat("zPosition") == transform.position.z)
            gameObject.SetActive(false);
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag(strTag))
        {
            animator.SetBool("isTriggeredByPlayer", true);
        }
    }
}
