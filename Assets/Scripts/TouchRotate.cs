using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TouchRotate : MonoBehaviour
{
    float number;
    float[] Rotation = new float[] {-90f,90f,180f };
    public static bool level1Cleared, level0Cleared;


    private void Start() 
    {
        
        number = Rotation [Random.Range(0,Rotation.Length)];
       
        transform.Rotate(0f,0f,number);
        
    }

    public void OnMouseDown() 
    {
        if(!GameControl.youWin && GameControl.isRunning)
        {
            transform.Rotate(0f,0f,90f);
           
        }
        
        if (GameControl.youWin)
        {
            if (SceneManager.GetActiveScene().name == "1c")
                level1Cleared = true;
            else if (SceneManager.GetActiveScene().name == "0a")
                level0Cleared = true;
        }
        
        
    }
}
