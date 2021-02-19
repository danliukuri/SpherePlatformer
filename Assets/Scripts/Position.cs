using UnityEngine;

[System.Serializable]
public class Position
{
    [SerializeField] float x;
    [SerializeField] float y;
    [SerializeField] float z;
    public float X { get => x; set => x = value; }
    public float Y { get => y; set => y = value; }
    public float Z { get => z; set => z = value; }

    public Position(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}
