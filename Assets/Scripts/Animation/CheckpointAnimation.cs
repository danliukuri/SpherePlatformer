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
        if(PlayerPrefs.HasKey("KeyPointPosition"))
        {
            Position keyPointPosition = JsonUtility.FromJson<Position>(PlayerPrefs.GetString("KeyPointPosition"));
            if (keyPointPosition.X == transform.position.x && keyPointPosition.Y == transform.position.y && keyPointPosition.Z == transform.position.z)
                gameObject.SetActive(false);
        }  
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag(strTag))
            animator.SetBool("isTriggeredByPlayer", true);
    }
}
