using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public Button level2_Button;
    public Image img;
    

    // Start is called before the first frame update
    void Start()
    {
        level2_Button.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        LevelCleared();
        Debug.Log(TouchRotate.levelCleared);
    }

    public void LevelCleared()
    {
        if(TouchRotate.levelCleared)
        {
            level2_Button.interactable = true;
            img.color = new Color(255, 255, 255, 255);
        }
    }
    
}
