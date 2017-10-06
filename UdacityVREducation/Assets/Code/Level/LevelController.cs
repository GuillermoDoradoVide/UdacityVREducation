using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    public GameObject player;
    private PlayerController playerController;
	// Use this for initialization
	private void Awake () {
        if (player == null)
        {
            Debug.LogWarning("(" + transform.name + ")  (gameobject)Player hasn't beeing asigned.");
            Debug.Break();
        }
        playerController = player.GetComponent<PlayerController>();

    }

    private void Start()
    {
        playerController.init();
    }

    // Update is called once per frame
    private void Update () {
		
	}
}
