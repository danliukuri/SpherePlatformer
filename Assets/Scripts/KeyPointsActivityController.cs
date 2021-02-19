using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPointsActivityController : MonoBehaviour
{
    [SerializeField]
    List<GameObject> KeyPoints;
    private void Start()
    {
        if(PlayerPrefs.HasKey("KeyPointPosition"))
        {
            Position keyPointPosition = JsonUtility.FromJson<Position>(PlayerPrefs.GetString("KeyPointPosition"));
            for (int i = 0; i < KeyPoints.Count - 1; i++)
                if (keyPointPosition.X == KeyPoints[i].transform.position.x && keyPointPosition.Y == KeyPoints[i].transform.position.y &&
                    keyPointPosition.Z == KeyPoints[i].transform.position.z)
                {
                    for (int j = i; j >= 0; j--)
                        KeyPoints[j].SetActive(false);
                    KeyPoints[i + 1].SetActive(true);
                }
        }
    }
    public void SetActiveNextKeyPoint(Transform keyPoint)
    {
        for (int i = 0; i < KeyPoints.Count - 1; i++)
            if (keyPoint.transform.position == KeyPoints[i].transform.position)
                KeyPoints[i + 1].SetActive(true);
    }
}
