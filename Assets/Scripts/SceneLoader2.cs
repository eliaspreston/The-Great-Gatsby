using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader2 : MonoBehaviour
{
    //menu is 0
    //hub is 1



    public int doorType;

    void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("scene load test");

        if (doorType == 1)
        {
            SceneManager.LoadScene(2);
        }
        else if (doorType == 2)
        {
            SceneManager.LoadScene(3);
        }
        else if (doorType == 3)
        {
            SceneManager.LoadScene(4);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
