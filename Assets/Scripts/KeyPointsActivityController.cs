using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPointsActivityController : MonoBehaviour
{
    [SerializeField]
    List<GameObject> KeyPoints;
    public void SetActiveNextKeyPoint(Transform keyPoint)
    {
        for (int i = 0; i < KeyPoints.Count - 1; i++)
            if (keyPoint.transform.position == KeyPoints[i].transform.position)
                KeyPoints[i + 1].SetActive(true);
    }
}
