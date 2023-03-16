using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManagerController : MonoBehaviour
{
    [SerializeField]
    private GameObject joyContoller, lightCandle, magnificerGlasses;

    [SerializeField]
    private Vector3 joyPos, lightCanPos, magPos;

    public int objectiveCount;
    public int objectiveGoal = 3;

    [SerializeField]
    private float xMinRange = 0, xMaxRange = 2.5f, yMinRange = -7, yMaxRange = 0, zMinRange = -3f,zMaxRange = -1f;

    [SerializeField]
    private bool isJoyClear, isLightCanClear, isMagClear;
    
    [SerializeField]
    private bool youWin;

    private void Start()
    {
        objectiveCount = 0;
        isJoyClear = false;
        isLightCanClear = false;
        isMagClear = false;
        youWin = false;
    }

    private void Update()
    {
        youWin = isJoyClear && isLightCanClear && isMagClear;
    }

    private void FixedUpdate()
    {
        joyPos = joyContoller.transform.position;
        lightCanPos = lightCandle.transform.position;
        magPos = magnificerGlasses.transform.position;
        CheckObjectivePosition();
    }

    private void CheckObjectivePosition()
    {
        // x (0, 2.5)
        // y (-7, 0)
        // z (-1.5, -2.5)
        isJoyClear = isObjectInrange(joyPos);
        isLightCanClear = isObjectInrange(lightCanPos);
        isMagClear = isObjectInrange(magPos);
    }

    private bool isObjectInrange(Vector3 pos)
    {
        if ((pos.x >= xMinRange && pos.x <= xMaxRange) 
            && (pos.y >= yMinRange && pos.y <= yMaxRange)
            && (pos.z >= zMinRange && pos.z <= zMaxRange))
        { return true; }

        return false;
    }

    public bool getYouwin()
    {
        return youWin;
    }



}
