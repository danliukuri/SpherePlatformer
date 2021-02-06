using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpWithButton : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force = new Vector3(0f, 5f, 0f);

    [SerializeField]
    KeyCode jumpKey = KeyCode.Space;

    private bool isGrounded;

    void Update()
    {
        if (isGrounded && Input.GetKeyDown(jumpKey))
            GetComponent<Rigidbody>().AddForce(v3Force, ForceMode.Impulse);
    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
    void OnCollisionExit()
    {
        isGrounded = false;
    }
}
