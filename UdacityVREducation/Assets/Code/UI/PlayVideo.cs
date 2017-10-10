using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class PlayVideo : MonoBehaviour {

    public VideoPlayer videoPlayer;
    public Text buttonText;

    public bool isPlaying;

	// Use this for initialization
	private void Start () {
        isPlaying = false;

    }

    private void FixedUpdate()
    {
        if (isPlaying)
        {
            if(videoPlayer.isPrepared)
            {
                if (!videoPlayer.isPlaying)
                {
                    videoPlayer.Stop();
                    isPlaying = false;
                    buttonText.text = "PLAY";
                }
            }
           
        }
    }

    public void triggerVideoAction()
    {
        if (isPlaying)
        {
            stopVideo();
        }
        else
        {
            playVideo();
        }
    }

    public void playVideo()
    {
        isPlaying = true;
        videoPlayer.Play();
        buttonText.text = "PAUSE";
    }

    public void stopVideo()
    {
        if(videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            isPlaying = false;
            buttonText.text = "PLAY";
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
