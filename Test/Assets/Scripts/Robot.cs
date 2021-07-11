using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Robot : MonoBehaviour
{
    public int health = 100;
    public Slider healthBar;
    public UnityEvent hitEffects;



    public void UpdateHealth(int increasment)
    {
        health += increasment;
        healthBar.value = health;
    }

    #region Hits
    public void HitBlue()
    {
        if (LightController.instance.currentState == LightController.ColorStates.Blue)
        {
            UpdateHealth(-10);
            hitEffects.Invoke();

            
            
            LightController.instance.ChangeColorState(LightController.instance.currentState + 1);
            
        }
    }
    public void HitRed()
    {
        if (LightController.instance.currentState == LightController.ColorStates.Red)
        {
            UpdateHealth(-10);
            hitEffects.Invoke();

            LightController.instance.ChangeColorState(LightController.instance.currentState + 1);
            
        }
    }

    public void HitGreen()
    {
        if (LightController.instance.currentState == LightController.ColorStates.Green)
        {
            UpdateHealth(-10);
            hitEffects.Invoke();

            
            
            LightController.instance.ChangeColorState(LightController.instance.currentState + 1);
            
        }
    }

    public void HitYellow()
    {
        if (LightController.instance.currentState == LightController.ColorStates.Yellow)
        {
            UpdateHealth(-10);
            hitEffects.Invoke();
           
            LightController.instance.ChangeColorState(0);
            

        }
    }
    #endregion
}
