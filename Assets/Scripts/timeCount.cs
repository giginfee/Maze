using UnityEngine.UI;
using UnityEngine;

public class timeCount : MonoBehaviour
{
    public float TimeLeft;
    public Text timeLabel;
    float timeLeft = 2.0f;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            TimeLeft += Time.deltaTime;
            updateTimer(TimeLeft);
            
            
        }
        
   
        }

    void updateTimer(float currentTime)
    {
     currentTime += 1;
       float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

    timeLabel.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
