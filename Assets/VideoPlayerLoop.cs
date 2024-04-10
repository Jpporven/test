using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerLoop : MonoBehaviour
{

    public VideoClip one;
    public VideoClip two;
    VideoPlayer video;

    // Update is called once per frame
    private void Start()
    {
        video = this.gameObject.GetComponent<VideoPlayer>();

        video.clip = one;
        video.Play();
       
    }

    private void Update()
    {
        if(video.clip == one && video.time == 10)
        {
            video.clip = two;
            video.Play();
            video.isLooping = true;
        }
    }
}
