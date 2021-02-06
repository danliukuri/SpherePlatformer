using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    [SerializeField] GameObject gameObj;
    [SerializeField] string strTag;
    [SerializeField] AnimationClip animationClip;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag(strTag))
        {
            if (animationClip)
            {
                GetComponent<Animator>().Play(animationClip.name);
                Destroy(gameObj, animationClip.length);
            }
            else
                Destroy(gameObj);
        }
    }
}
