﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnCollision : MonoBehaviour
{
    [SerializeField] Transform gameObj;
    [SerializeField] Vector3 defaultPosition;
    [SerializeField] string strTag;
    Rigidbody gameObjRigidbody;
    Position keyPointPosition;
    Vector3 position;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
            gameObjRigidbody.Sleep();
            SetKeyPointPositionFromJson();
        }
    }
    private void Start()
    {
        keyPointPosition = new Position(defaultPosition.x, defaultPosition.y, defaultPosition.z);
        if (PlayerPrefs.HasKey("KeyPointPosition"))
            SetKeyPointPositionFromJson();
        else
            SetPosition(defaultPosition);
        gameObjRigidbody = gameObj.GetComponent<Rigidbody>();
    }
    private void SetPosition(Vector3 position) => gameObj.position = position;
    private void SetKeyPointPositionFromJson()
    {
        JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString("KeyPointPosition"), keyPointPosition);
        position.Set(keyPointPosition.X, keyPointPosition.Y, keyPointPosition.Z);
        SetPosition(position);
    }
}