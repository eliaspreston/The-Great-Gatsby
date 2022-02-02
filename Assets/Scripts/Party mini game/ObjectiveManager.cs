using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public bool gotTask = false;
    public int taskType;    // if 1 drink, if 2 food, if 0 no task
    public bool hasTaskItem = false;

    void Start()
    {
        gotTask = false;
        taskType = 0;
        Debug.Log("get a task");
    }

    public void NewTask()
    {
        gotTask = true;
        taskType = Random.Range(1, 3);
        hasTaskItem = false;

        if (taskType == 1)
        {
            Debug.Log("task is get drink");
        }
        else
        {
            Debug.Log("task is get food");
        }
    }

    public void TaskComplete()
    {
        gotTask = false;
        taskType = 0;
        Debug.Log("task complete, get a new task");
    }
    public void InteractWithNPC()
    {
        if(!gotTask)
        {
            NewTask();
        }
        if (gotTask && hasTaskItem)
        {
            TaskComplete();
        }
    }
    public void InteractWithDrinkStand()
    {
        if (taskType == 1)
        {
            hasTaskItem = true;
            Debug.Log("got drink");
        }
    }
    public void InteractWithFoodStand()
    {
        if (taskType == 2)
        {
            hasTaskItem = true;
            Debug.Log("got food");
        }
    }
}