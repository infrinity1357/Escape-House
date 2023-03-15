using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public string textTime;
    public Text textField;
    public float startTime;

    private float guiTime;
    private int minutes;
    private int seconds;
    private int fraction;

    

    // Start is called before the first frame update
    void Start()
    {
        startTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        guiTime = startTime - Time.time;
        minutes = (int)guiTime / 60;
        seconds = (int)guiTime % 60;
        fraction = (int)guiTime  * 100 % 100;
        textTime = string.Format("{0:00} : {1:00}", minutes, seconds, fraction);
        // textTime = string.Format("{00}", guiTime);
        if (minutes <= 0 && seconds <= 0)
        {
            textField.text = "Game Over";
        }
        else
        {
            textField.text = textTime;
        }

    }
}
