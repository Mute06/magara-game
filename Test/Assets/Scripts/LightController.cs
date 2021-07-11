using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public static LightController instance;

    [SerializeField] private Light[] lights;

    public Color redColor;
    public Color blueColor;
    public Color greenColor;
    public Color yellowColor;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public ColorStates currentState;
    public enum ColorStates
    {
        Red = 0,
        Blue = 1,
        Green = 2,
        Yellow = 3
    }

    public void ChangeColorState(ColorStates nextState)
    {
        if (nextState == ColorStates.Red)
        {
            foreach (var item in lights)
            {
                item.color = redColor;
            }
        }
        else if (nextState == ColorStates.Blue)
        {
            foreach (var item in lights)
            {
                item.color = blueColor;
            }
        }
        else if (nextState == ColorStates.Green)
        {
            foreach (var item in lights)
            {
                item.color = greenColor;
            }
        }
        else if (nextState == ColorStates.Yellow)
        {
            foreach (var item in lights)
            {
                item.color = yellowColor;
            }
        }
        currentState = nextState;

    }


}
