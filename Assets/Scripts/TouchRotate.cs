using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    float number;
    float[] Rotation = new float[] {-90f,90f,180f };
    public static bool levelCleared;


    private void Start() 
    {
        
        number =Rotation [Random.Range(0,Rotation.Length)];
       
        transform.Rotate(0f,0f,number);
        
    }

    public void OnMouseDown() 
    {
        LoadData();
        if(!GameControl.youWin)
        {
            transform.Rotate(0f,0f,90f);
           
        }
        
        if (GameControl.youWin && (Application.loadedLevelName == "1c"))
        {
            levelCleared = true;
            SaveData();
            Debug.Log(levelCleared);
        }
        
        
    }

    public void LoadData()
    {
        PlayerPrefs.GetInt("levelData");
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("levelData", boolToInt(levelCleared));
    }

    private int boolToInt(bool val)
    {
        if (val)
            return 1;
        else
            return 0;
    }
}
