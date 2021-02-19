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
    static float savedStartTime;
    
   
    // Update is called once per frame
    void Update()
    {
        if (!isPlayerMoved)
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                startTime = Time.timeSinceLevelLoad - PlayerPrefs.GetFloat("StartTime", 0);
                PlayerPrefs.SetFloat("StartTime", startTime);
                savedStartTime = startTime;
                isPlayerMoved = true;
            }
        if (isPlayerMoved && PlayerPrefs.HasKey("StartTime") && savedStartTime != PlayerPrefs.GetFloat("StartTime"))
        {
            savedStartTime = PlayerPrefs.GetFloat("StartTime");
            timerText.text = System.TimeSpan.FromSeconds(savedStartTime).ToString("mm':'ss':'ff");
            GetComponent<CanvasAnimation>().PositionSave();
        }
        if (IsLevelEnd)
        {
            timerText.text = System.TimeSpan.FromSeconds(Time.timeSinceLevelLoad  - startTime).ToString("mm':'ss':'ff");
            if (PlayerPrefs.HasKey("StartTime"))
                PlayerPrefs.DeleteKey("StartTime");
            IsLevelEnd = false;
        }  
    }
}
