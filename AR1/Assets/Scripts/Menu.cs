using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void play1()
    {
      SceneManager.LoadScene("SampleScene");
    }
    public void exitgame()
    {
      Application.Quit();
    }
    public void backgame()
    {
      SceneManager.LoadScene("Menu");
       Debug.Log("Exit button is pressed");
    }
}
