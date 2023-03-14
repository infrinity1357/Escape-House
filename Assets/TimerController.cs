using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public string textTime;

    public float guiTime;
    public float startTime;
    public int minutes;
    public int seconds;
    public int fraction;

    public Text textField;
    public Text overText;

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
        // textTime = string.Format("{0:00} : {1:00}", minutes, seconds, fraction);
        textTime = string.Format("{00}", guiTime);
        if (minutes <= 0 && seconds <= 0)
        {
            textField.text = "Game Over";
            // overText.SetActive(true);
        }
        else
        {
            textField.text = textTime;
        }

    }
}
