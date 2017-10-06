using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInfoController_UI : MonoBehaviour {

    public Text displayText;

	private void Start () {
        displayText = transform.GetComponentInChildren<Text>();
        if (displayText == null)
        {
            Debug.LogWarning("(" + transform.name + ") couldn't find a child text component.");
            Debug.Break();
        }
	}

    public void setDisplayInfoText(string newText)
    {
        displayText.text = newText;
    }
}
