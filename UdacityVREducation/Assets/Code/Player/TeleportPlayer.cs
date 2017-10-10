using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour {

    public Transform teleportPositionSchool;
    public Transform teleportMainHall;
    public Transform teleportCompanies;
    public Transform teleportFuture;
    public Transform teleportSamples;
    public Transform Player;
    public PlayerVisionFade_UI fadeUI;
	// Use this for initialization
	private void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void teleportToPosition(Transform position)
    {
        StartCoroutine(transitionToTeleport(position));
    }

    public IEnumerator transitionToTeleport(Transform teleportPosition)
    {
        fadeUI.show();
        yield return new WaitForSeconds(1);
        Player.position = teleportPosition.position;
        fadeUI.hide();
    }
}
