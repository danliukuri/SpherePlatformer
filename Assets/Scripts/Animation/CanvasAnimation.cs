using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasAnimation : MonoBehaviour
{
    public bool IsLevelEnd { get; set; }
    private Animator animator;
    private  bool isGamePause;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(IsLevelEnd) animator.SetBool("isLevelEnd", true);
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isGamePause) PauseOn();
            else PauseOff(); 
        }
    }
    private void PauseOn()
    {
        animator.enabled = true;
        animator.SetBool("isGamePause", true);
        gameObject.GetComponentInParent<UnityEngine.UI.GraphicRaycaster>().enabled = true;
        Time.timeScale = 0;
        isGamePause = true;
    }
    private void PauseOff()
    {
        animator.SetBool("isGamePause", false);
        gameObject.GetComponentInParent<UnityEngine.UI.GraphicRaycaster>().enabled = false;
        Time.timeScale = 1;
        isGamePause = false;
    }
    public void AnimatorDisable() => animator.enabled = false;
}
