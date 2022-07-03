using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showmap : MonoBehaviour
{
    public GameObject map;
    public void OnMouseOver()
    {
        map.gameObject.SetActive(true);
    }


    public void OnMouseExit()
    {
        map.gameObject.SetActive(false);
    }

}
    
