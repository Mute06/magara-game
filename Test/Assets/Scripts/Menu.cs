using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("Oundan Cikildi");
        Application.Quit();
    }

    public void CredidtsGame()
    {
        SceneManager.LoadScene(3);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
