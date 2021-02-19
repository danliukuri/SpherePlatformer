using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalAnimation : MonoBehaviour
{
    [SerializeField] string strTag;
    [SerializeField] GameObject canvas;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag(strTag))
        {
            canvas.GetComponent<Timer>().IsLevelEnd = true;
            canvas.GetComponent<CanvasAnimation>().IsLevelEnd = true;
            animator.SetBool("isTriggeredByPlayer", true);
            if (PlayerPrefs.HasKey("KeyPointPosition"))
                PlayerPrefs.DeleteKey("KeyPointPosition");
        }
    }
}