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
        if(gameTimer.timer<=50)
        {
            for(int i=0; i<=stars.Length-1; i++)
            {
                stars[i].SetActive(true);
            }
        }
        if (gameTimer.timer > 50f && gameTimer.timer<=80f)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(false);
        }
        if(gameTimer.timer>80)
        {
            stars[0].SetActive(true);
            stars[1].SetActive(false);
            stars[2].SetActive(false);
        }
    }
}
