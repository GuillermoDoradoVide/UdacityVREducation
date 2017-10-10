using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudio : MonoBehaviour {

    public AudioClip audioClick;
    public AudioClip audioHover;
    public AudioSource buttonSource;
	// Use this for initialization
	private void Start () {
		
	}
	
	public void playHover()
    {
        buttonSource.PlayOneShot(audioHover);
    }

    public void playClick()
    {
        buttonSource.PlayOneShot(audioClick);
    }
}
