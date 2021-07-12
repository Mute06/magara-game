using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySimulation : MonoBehaviour
{
    private int ready = 0;
    private int totalNeed = 1;

    public void ReadyOne()
    {
        ready++;
        if (ready >= totalNeed)
        {
            //Destroy Simulation
            
            AudioManager.instance.PlaySound("warning");
            StartCoroutine(GotoCredits());
            
        }
    }
    private IEnumerator GotoCredits()
    {
        yield return new WaitForSeconds(8f);
        AudioManager.instance.PlaySound("explosion");
        LevelLoader.instance.LoadNextScene();

    }

}
