using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tween;

public class HoverAndRotate : MonoBehaviour {

    public GameObject boat;
    public bool isBoatDemoActive;
    public bool isActive;
    public float vSpeed = 0.5f;
    public float rotationSpeed = 1;

    public AudioSource waves;
    public AudioClip sound;

    // Use this for initialization
    private void Start () {
        isBoatDemoActive = false;
        isActive = false;
        waves.clip = sound;
    }
	
	// Update is called once per frame
	private void Update () {
        if(isActive)
        {
            if (isBoatDemoActive)
            {
                boatDemo();
            }
        }
	}

    private void boatDemo()
    {
        isActive = false;
        StartCoroutine(upAndDown());
    }

    private IEnumerator upAndDown()
    {
        iTween.MoveTo(boat, iTween.Hash("path", iTweenPath.GetPath("Path"), "time", 120, "islocal", true, "orientToPath", true, "lookTime", 0.2));
        waves.Play();
        while(isBoatDemoActive)
        {
            yield return null;
        }
        boat.transform.TnStop();
        waves.Stop();
    }

}
