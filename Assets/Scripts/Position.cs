using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Position
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
    public Position(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}
