using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public PlayerVisionFade_UI playerVision;

    public AudioClip clip1;
    public AudioClip clip2;
    public AudioSource playerSource;
	// Use this for initialization
	private void Awake () {
        playerVision = GetComponent<PlayerVisionFade_UI>();
        if (playerVision == null)
        {
            Debug.LogWarning("(" + transform.name + ")  (gameobject)Player hasn't a PlayerVisionFade_UI component asigned.");
            Debug.Break();
        }

        playerSource.clip = clip1;
    }
	
	// Update is called once per frame
	private void Update () {
		
	}

    public void init ()
    {
        playerVision.hide();
    }

    public void stopAmbientSound()
    {
        playerSource.Stop();
    }

    public void playAmbientSound()
    {
        playerSource.Play();
    }
    public void changeAmbientSound()
    {
        playerSource.clip = clip2;
    }
}
