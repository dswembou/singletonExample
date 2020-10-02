using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeShow : MonoBehaviour
{
    private Text timeText;
    
    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = "Time left: " + GameManager.Instance.timeLeft.ToString();
    }
}
