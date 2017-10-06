using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public PlayerVisionFade_UI playerVision;
	// Use this for initialization
	private void Awake () {
        playerVision = GetComponent<PlayerVisionFade_UI>();
        if (playerVision == null)
        {
            Debug.LogWarning("(" + transform.name + ")  (gameobject)Player hasn't a PlayerVisionFade_UI component asigned.");
            Debug.Break();
        }
    }
	
	// Update is called once per frame
	private void Update () {
		
	}

    public void init ()
    {
        playerVision.hide();
    }
}
