using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;
    private Rigidbody rigidbody; 
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate ()
    {
        if (Input.GetKey(keyPositive))
            rigidbody.velocity += v3Force;

        if (Input.GetKey(keyNegative))
            rigidbody.velocity -= v3Force;
    }
}
