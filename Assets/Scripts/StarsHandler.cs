using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject[] stars;

    public GameTimer gameTimer; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameTimer.timer<=75f)
        {
            for(int i=0; i<=stars.Length; i++)
            {
                stars[i].SetActive(true);
            }
        }
        if (gameTimer.timer > 75f && gameTimer.timer<=105f)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(false);
        }
        if(gameTimer.timer>105)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(false);
            stars[2].SetActive(false);
        }
    }
}
