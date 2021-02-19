using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasAnimation : MonoBehaviour
{
    public bool IsLevelEnd { get; set; }
    private Animator animator;
    private bool isGamePause;
    private GraphicRaycaster canvasGraphicRaycaster;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        canvasGraphicRaycaster = GetComponentInParent<GraphicRaycaster>();
    }

    void Update()
    {
        if (IsLevelEnd)
        {
            animator.SetLayerWeight(1, 1); // Menu button Layer
            animator.SetLayerWeight(2, 1); // Other levels Layer
            animator.SetLayerWeight(3, 1); // Retry button Layer
            animator.SetLayerWeight(4, 1); // Next level Layer
            canvasGraphicRaycaster.enabled = true;
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
        animator.SetLayerWeight(3, 1); // Retry button Layer
        animator.SetLayerWeight(5, 1); // Pause Layer
        animator.SetBool("isGamePause", true);
        canvasGraphicRaycaster.enabled = true;
        Time.timeScale = 0;
        isGamePause = true;
    }
    private void PauseOff()
    {
        animator.SetBool("isGamePause", false);
        canvasGraphicRaycaster.enabled = false;
        Time.timeScale = 1;
        isGamePause = false;
    }
    public void PauseLayersDisable()
    {
        animator.SetLayerWeight(1, 0); // Menu Button Layer
        animator.SetLayerWeight(2, 0); // Other levels Layer
        animator.SetLayerWeight(3, 0); // Retry button Layer
        animator.SetLayerWeight(5, 1); // Pause Layer
    }

    public void PositionSave()
    {
        animator.SetLayerWeight(6, 1); // Position save Layer
        animator.SetBool("isPositionSave", true);
    }
    public void PositionSaved()
    {
        animator.SetLayerWeight(6, 0); // Position save Layer
        animator.SetBool("isPositionSave", false);
    }
}
