using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForthPost : MonoBehaviour {

    public SpinFree spin;
    public ShowHideUI uiButton;
    void Start () {
		
	}

	void Update () {
		
	}

    public void disableInteractions()
    {
        StartCoroutine(closePost());
    }

    private IEnumerator closePost()
    {
        uiButton.hideUI();
        yield return new WaitForSeconds(1);
        LevelController.Instance.showInfoPanels();
    }

    public void setSlowSpeed()
    {
        spin.speed = 1;
    }

    public void setFastSpeed()
    {
        spin.speed = 12;
    }

    public void OnEnable()
    {
        StartCoroutine(enableUI());
    }

    private IEnumerator enableUI()
    {
        yield return new WaitForSeconds(1);
        uiButton.showUI();
    }
}
