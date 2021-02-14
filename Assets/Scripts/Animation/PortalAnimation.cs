using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalAnimation : MonoBehaviour
{
    [SerializeField] string strTag;
    [SerializeField] GameObject menu;
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
            menu.GetComponent<Animator>().enabled = true;
            menu.GetComponentInParent<UnityEngine.UI.GraphicRaycaster>().enabled = true;
            animator.SetBool("isTriggeredByPlayer", true);
        }
    }
}