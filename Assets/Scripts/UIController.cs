using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    public void StartGame()
    {
        GameControl.isRunning = true;
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }

    public void Close()
    {
        Application.Quit();
    }

    public void LoadLevelMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadLeve1()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadLeve1_a()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadLeve1_b()
    {
        SceneManager.LoadScene(7);
    }

     public void LoadLeve1_c()
     {
         SceneManager.LoadScene(9);
     }
     public void LoadLeve2()
     {
         SceneManager.LoadScene(10);
     }
     public void LoadLeve2_a()
     {
         SceneManager.LoadScene(12);
     }
    public void LoadLeve2_b()
    {
        SceneManager.LoadScene(14);
    }

    public void LoadLeve2_c()
    {
        SceneManager.LoadScene(15);
    }

    public void LoadLevel0()
    {
        SceneManager.LoadScene(17);
    }

    public void LoadLevel0a()
    {
        SceneManager.LoadScene(19);
    }

    public void ReStart()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }
}
