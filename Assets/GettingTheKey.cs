using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingTheKey : MonoBehaviour
{
    public GameObject wall;
    public GameObject key3D;
    public GameObject keypicture;

   

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            wall.SetActive(false);
            key3D.SetActive(false);
            keypicture.SetActive(true);
        }
    }
}
