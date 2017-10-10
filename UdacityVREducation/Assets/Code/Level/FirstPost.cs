using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPost : MonoBehaviour {

    public DisplayInfoController_UI firstDisplay;
    public string secondText;
    public string thirdText;
    public GameObject continueButton;
    public ShowHideUI continueButtonUI;
    public GameObject nextButton;
    public ShowHideUI nextButtonUI;
    public GameObject endButton;
    public ShowHideUI endButtonUI;

    public GameObject firstFirst;

    public GameObject videoPresent;

    public HoverAndRotate boatDemo;

    // Use this for initialization
    private void Start () {
        secondText = "The perception is created by surrounding the user of the VR system in images, sound or other stimuli that provide an engrossing total environment.";
        thirdText = "VR achieve real user experience within a virtual generated world and perception. Education can use this experience to evolve. Welcome to EDUCATION VR!";
        continueButtonUI = continueButton.GetComponent<ShowHideUI>();
        nextButtonUI = nextButton.GetComponent<ShowHideUI>();
        endButtonUI = endButton.GetComponent<ShowHideUI>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void init ()
    {
        continueButton.SetActive(true);
        firstDisplay.show();
    }

    public void firstContinue()
    {
        StartCoroutine(changeText(secondText));
    }

    private IEnumerator changeText(string newString)
    {
        firstDisplay.hide();
        firstDisplay.gameObject.SetActive(true);
        continueButtonUI.hideUI();
        nextButton.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        firstDisplay.displayText.text = secondText;
        firstDisplay.show();
        nextButtonUI.showUI();
    }

    public void firstNext()
    {
        firstDisplay.hide();
        nextButtonUI.hideUI();
        boatDemo.boat.SetActive(true);
        boatDemo.isActive = true;
        boatDemo.isBoatDemoActive = true;
        StartCoroutine(boatDemoSample());
        //
    }

    private IEnumerator boatDemoSample()
    {
        //
        yield return new WaitForSeconds(26);
        firstDisplay.displayText.text = thirdText;
        firstDisplay.show();
        endButton.SetActive(true);
        endButtonUI.showUI();
        boatDemo.isActive = false;
        boatDemo.isBoatDemoActive = false;
        boatDemo.boat.SetActive(false);
    }

    public void secondContinue()
    {
        firstDisplay.hide();
        endButtonUI.hideUI();
        setInfoPanelsMuseum();
    }

    public void setInfoPanelsMuseum()
    {
        firstFirst.SetActive(true);
        LevelController.Instance.initMuseum();
    }
}
