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
            Debug.Log(JsonUtility.FromJson<Position>( PlayerPrefs.GetString("CheckPointPosition")));
            SetPosition(new Vector3(PlayerPrefs.GetFloat("xPosition"),PlayerPrefs.GetFloat("yPosition"), PlayerPrefs.GetFloat("zPosition")));
        }
    }
    private void Start() => SetPosition(defaultPosition);
    private void SetPosition(Vector3 position) => gameObj.transform.position = position;
}
