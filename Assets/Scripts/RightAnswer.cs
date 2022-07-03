using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightAnswer : MonoBehaviour
{
    public GameObject quiz;
    public void clearPath()
    {
        quiz.gameObject.SetActive(false);
    }
}
