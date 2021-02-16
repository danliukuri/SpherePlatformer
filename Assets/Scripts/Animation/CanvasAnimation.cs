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
        if (IsLevelEnd)
        {
            animator.SetLayerWeight(1, 1); // Menu Button Layer
            animator.SetLayerWeight(2, 1); // Other levels Layer
            animator.SetLayerWeight(4, 1); // Next level Layer
            gameObject.GetComponentInParent<UnityEngine.UI.GraphicRaycaster>().enabled = true;
            animator.SetBool("isLevelEnd", true);
        } 
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isGamePause) PauseOn();
            else PauseOff(); 
        }
    }
    private void PauseOn()
    {
        animator.SetLayerWeight(1, 1); // Menu Button Layer
        animator.SetLayerWeight(2, 1); // Other levels Layer
        animator.SetLayerWeight(3, 1); // Pause Layer
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
    public void PauseLayersDisable()
    {
        animator.SetLayerWeight(1, 0); // Menu Button Layer
        animator.SetLayerWeight(2, 0); // Other levels Layer
        animator.SetLayerWeight(3, 0); // Pause Layer
    }
}
