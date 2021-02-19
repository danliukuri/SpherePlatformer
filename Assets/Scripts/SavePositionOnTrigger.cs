using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePositionOnTrigger : MonoBehaviour
{
    [SerializeField] Transform point;
    [SerializeField] string strTag;
    [SerializeField] GameObject keyPointsActivityController;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag(strTag))
        {
            PlayerPrefs.SetFloat("StartTime", Time.time);
            PlayerPrefs.SetString("KeyPointPosition", JsonUtility.ToJson(new Position(point.position.x, point.position.y, point.position.z)));
            keyPointsActivityController.GetComponent<KeyPointsActivityController>().SetActiveNextKeyPoint(transform);
        }
    }
}