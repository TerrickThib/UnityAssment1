using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehaviour : MonoBehaviour
{
    bool stopwatchActive = false;
    float currentTime;
    public Text currentTimeText;

    void Start()
    {
        currentTime = 0;
    }
    void Update()
    {
        stopwatchActive = true;
        if (stopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        System.TimeSpan time = System.TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Seconds.ToString();
    }
}
