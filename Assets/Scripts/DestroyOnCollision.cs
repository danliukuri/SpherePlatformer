using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField] GameObject gameObj;
    [SerializeField] string strTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
            Destroy(gameObj);
    }
}
