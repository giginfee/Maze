using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class obstacleEnter : MonoBehaviour
{
    public static int livesCount = 3;
    public GameObject heart1, heart2, heart3, redBg;
    float timeLeft = 0f;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Obstacle")
        {
            timeLeft = 0.2f;
            livesCount -= 1;
            redBg.gameObject.SetActive(true);
        }
    }
    void Start()
    {
        livesCount = 3;

    }

    void Update()
    {                 
        if (livesCount == 2)
        {
            heart3.gameObject.SetActive(false);
        }
        if (livesCount == 1)
        {
            heart2.gameObject.SetActive(false);
        }
        if (livesCount == 0)
        {
            heart1.gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            livesCount = 3;
        }
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            redBg.gameObject.SetActive(false); ;
        }
    }
    public void WrongEnter()
    {
        
            timeLeft = 0.2f;
            livesCount -= 1;
            redBg.gameObject.SetActive(true);
        
    }
}
