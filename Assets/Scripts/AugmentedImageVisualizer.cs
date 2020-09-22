using GoogleARCore;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AugmentedImageVisualizer : MonoBehaviour
{
    [SerializeField] private VideoClip[] objectList;
    public AugmentedImage Image;
    private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += Onstop;
    }

    private void Onstop(VideoPlayer source)
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Image == null || Image.TrackingState != TrackingState.Tracking)
        {
            return;
        }
  
            if (!videoPlayer.isPlaying)
            {
                videoPlayer.clip =objectList[Image.DatabaseIndex];
                videoPlayer.Play();
            Console.WriteLine("Playing...");
            }
        
            
        transform.localScale = new Vector3(Image.ExtentX, Image.ExtentZ, 1);

    }
}
