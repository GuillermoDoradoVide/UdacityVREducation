using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthSample : MonoBehaviour {

    public GameObject atmoshpere;
    public GameObject nameplates;
    public bool isAtmosphere;
    public bool isNameplates;

    // Use this for initialization
    private void Start () {
        isAtmosphere = true;
        isNameplates = false;

    }
	
	// Update is called once per frame
	private void Update () {
		
	}

    public void toggleAtmosphere()
    {
        if (isAtmosphere)
        {
            isAtmosphere = false;
            atmoshpere.SetActive(false);
        }
        else
        {
            isAtmosphere = true;
            atmoshpere.SetActive(true);
        }
    }

    public void toggleNameplates()
    {
        if (isNameplates)
        {
            isNameplates = false;
            nameplates.SetActive(false);
        }
        else
        {
            isNameplates = true;
            nameplates.SetActive(true);
        }
    }
}
