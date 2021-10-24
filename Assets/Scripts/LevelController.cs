using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public Button level1_Button, level2_button;
    public Image level1_img, level2_img;
    

    // Start is called before the first frame update
    void Start()
    {
        level1_Button.interactable = false;
        level2_button.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        LevelCleared();
    }

    public void LevelCleared()
    {
        if(TouchRotate.level1Cleared)
        {
            level2_img.color = new Color(255, 255, 255, 255);
            level2_button.interactable = true;
            level1_img.color = new Color(255, 255, 255, 255);
            level1_Button.interactable = true;
        }
        else if(TouchRotate.level0Cleared)
        {
            level1_img.color = new Color(255, 255, 255, 255);
            level1_Button.interactable = true;

        }
    }
    
}
