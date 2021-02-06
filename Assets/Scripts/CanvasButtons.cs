using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasButtons : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    public void RightButtonClick()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().velocity += v3Force;
    }
    public void LeftButtonClick()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().velocity -= v3Force;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
