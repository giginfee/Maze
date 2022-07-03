using UnityEngine.UI;
using UnityEngine;

public class GetTime : MonoBehaviour
{
    public GameObject timer;
    
    public Text timeFinalScore;
    Text timeLabel;
    void Start()
    {
        timeLabel = timer.GetComponent<Text>();
        timeFinalScore.text = timeLabel.text;
    }

   
}
