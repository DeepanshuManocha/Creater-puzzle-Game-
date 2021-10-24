using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoLoader : MonoBehaviour
{
    public VideoPlayer video;

    // Start is called before the first frame update
    void Start()
    {
        video.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Tutorial.mp4");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
