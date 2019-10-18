﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskCounter : MonoBehaviour
{
    private TaskController taskControllerScript;

    private TextMeshProUGUI tmp;

    private string totalCount;

    // Start is called before the first frame update
    private void Start()
    {
        tmp = this.GetComponent<TextMeshProUGUI>();
        tmp.text = "0";
    }

    // Update is called once per frame
    private void Update()
    {
        if (taskControllerScript == null)
        {
            if (GameObject.FindGameObjectWithTag("Task"))
            {
                taskControllerScript = GameObject.FindGameObjectWithTag("Task").GetComponent<TaskController>();
                if (GameObject.FindGameObjectWithTag("Task").name == "FishTask")
                {
                    totalCount = "/150";
                }
                else
                {
                    totalCount = "/68";
                }
            }
        }
        else
        {
            if (Time.frameCount % 10 == 0)
            {
                
                tmp.text = taskControllerScript.tasksAchieved + totalCount;
            }
        }
       
        
    }
}
