using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public bool IsLevelEnd { get; set; }
    [SerializeField]
    TMPro.TextMeshProUGUI timerText;
    private bool isPlayerMoved;
    float startTime;
    // Update is called once per frame
    void Update()
    {
        if (!isPlayerMoved)
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                startTime = PlayerPrefs.GetFloat("StartTime", Time.time);
                isPlayerMoved = true;
            }
        if(IsLevelEnd)
        {
            timerText.text = System.TimeSpan.FromSeconds(Time.time - startTime).ToString("mm':'ss':'ff");
            PlayerPrefs.DeleteKey("StartTime");
            IsLevelEnd = false;
        }
    }
}
