using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFaceFordward : MonoBehaviour {

    public Transform lookAtPosition;

	void Start () {
		
	}

	private void Update () {
        transform.LookAt(lookAtPosition);
	}

}
