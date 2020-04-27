using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private static BgSound instance=null;
    public static BgSound Instance{
        get{return instance;}
    }

    void Awake()
    {
        if(instance!=null && instance!=this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance=this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

