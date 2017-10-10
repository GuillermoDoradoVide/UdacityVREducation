using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideUI : MonoBehaviour {

    public GameObject UI;

    public CanvasGroup canvasGroup;

	// Use this for initialization
	private void Start () {
		
	}
	
	public void showUI() {
        StartCoroutine(show());
    }

    private IEnumerator show()
    {
        while (canvasGroup.alpha < 0.9)
        {
            canvasGroup.alpha += 5 * Time.deltaTime;
            yield return null;
        }
        canvasGroup.alpha = 1;
        yield return new WaitForSeconds(0.1f);
        UI.SetActive(true);
    }


    public void hideUI()
    {
        StartCoroutine(hide());
    }

    private IEnumerator hide()
    {
        while (canvasGroup.alpha > 0.1)
        {
            canvasGroup.alpha -= 5 * Time.deltaTime;
            yield return null;
        }
        canvasGroup.alpha = 0;
        yield return new WaitForSeconds(0.1f);
        UI.SetActive(false);
    }
}
