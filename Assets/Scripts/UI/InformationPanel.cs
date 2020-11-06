using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationPanel : MonoBehaviour
{
    public Text textFPS;
    public Text textDate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textFPS.text = $"FPS: {(int)(1 / Time.deltaTime)}";
        textDate.text = $"DATE: {DateTime.Now}";
    }
}
