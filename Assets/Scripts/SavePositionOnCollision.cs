using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePositionOnCollision : MonoBehaviour
{
    [SerializeField] Transform point;
    [SerializeField] string strTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
            PlayerPrefs.SetFloat("xPosition", point.transform.position.x);
            PlayerPrefs.SetFloat("yPosition", point.transform.position.y);
            PlayerPrefs.SetFloat("zPosition", point.transform.position.z);
        }
            
    }
}
