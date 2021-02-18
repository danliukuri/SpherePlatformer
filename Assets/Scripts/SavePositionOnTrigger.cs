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
            PlayerPrefs.SetFloat("xPosition", point.transform.position.x);
            PlayerPrefs.SetFloat("yPosition", point.transform.position.y);
            PlayerPrefs.SetFloat("zPosition", point.transform.position.z);
            keyPointsActivityController.GetComponent<KeyPointsActivityController>().SetActiveNextKeyPoint(transform);
        }
    }
}
