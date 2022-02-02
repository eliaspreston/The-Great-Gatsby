using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader2 : MonoBehaviour
{
    //menu is 0
    //hub is 1

    //platformer is level 2;
    //race is 3;
    //party  is 4;

    public int doorType;

    void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("scene load test");

        if (doorType == 2)
        {
            SceneManager.LoadScene(2);
        }
        else if (doorType == 3)
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            SceneManager.LoadScene(4);
        }
    }
}
