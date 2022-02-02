using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivePoint : MonoBehaviour
{
    public int myType = 1; //if 1 human, if 2 drinks stand, if 3 food point
    public ObjectiveManager objectiveManager;

    int taskType;    // if 1 drink, if 2 food

    void Awake()
    {
        objectiveManager = transform.parent.GetComponent<ObjectiveManager>();
    }
    void Start()
    {
        if (myType == 1)
        {
            
        }
        else if (myType == 2)
        {

        }
        else
        {

        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (myType == 1)
        {
            objectiveManager.InteractWithNPC();
        }
        else if (myType == 2)
        {
            objectiveManager.InteractWithDrinkStand();
        }
        else
        {
            objectiveManager.InteractWithFoodStand();
        }
    }
}
