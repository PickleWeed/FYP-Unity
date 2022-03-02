using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    private LevelManager levelManager;

    void Start()
    {
        levelManager = LevelManager.Instance;
    }

    public void Destroy()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Click is pressed");
            //Destroy(other);
        }
    }
}
