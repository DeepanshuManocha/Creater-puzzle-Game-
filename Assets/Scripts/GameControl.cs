using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] pics;

    public GameObject GameOver;

    public static bool youWin, isRunning;
   
    void Start()
    {
        youWin=false;
        isRunning = true;
        PlayerPrefs.GetInt("levelData");
    }

    // Update is called once per frame
    void Update()
    {
        youWin = true;
        //levelCleared = false;
        
        for (int i = 0; i < pics.Length; ++i)
        {
          //  Debug.Log("Rotation at " + i + " " + pics[i].rotation.z);
            youWin = youWin && pics[i].rotation.z >= -0.001f && pics[i].rotation.z <= 0.001f;
            
        }
        if(youWin)
        {
            GameOver.SetActive(true);
            isRunning = false;
        }
    }

    

    

}
