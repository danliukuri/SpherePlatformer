using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDAnimation : MonoBehaviour
{
    private Animator animator;
    private bool isPlayerMoved;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("xPosition"))
            gameObject.SetActive(false);
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if(!isPlayerMoved)
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                animator.SetBool("isPlayerMoved", true);
                isPlayerMoved = true;
            }
                
    }
    public void Disable() => gameObject.SetActive(false);
}
