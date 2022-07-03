using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    public GameObject WinMenu;
    

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag =="Player")
        {
            WinMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
    }
}
