using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnCollision : MonoBehaviour
{
    [SerializeField] Transform gameObj;
    [SerializeField] Vector3 defaultPosition;
    [SerializeField] string strTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
            gameObj.GetComponent<Rigidbody>().Sleep();
            SetPosition();
        }
    }
    private void Start() => SetPosition();
    private void SetPosition() => gameObj.transform.position = new Vector3(PlayerPrefs.GetFloat("xPosition", defaultPosition.x),
        PlayerPrefs.GetFloat("yPosition", defaultPosition.y), PlayerPrefs.GetFloat("zPosition", defaultPosition.z));
}
