using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInfoController_UI : MonoBehaviour {

    public Transform mainCanvas;
    public Text displayText;

    private CanvasGroup mainCanvasCanvasGroup;
    private bool isUIAnimationTransition;

    private void Awake () {
        mainCanvas = transform.GetChild(0);
        displayText = mainCanvas.GetComponentInChildren<Text>();
        if (displayText == null)
        {
            Debug.LogWarning("(" + transform.name + ") couldn't find a child text component.");
            Debug.Break();
        }
        mainCanvasCanvasGroup = mainCanvas.GetComponent<CanvasGroup>();
        if (mainCanvasCanvasGroup == null)
        {
            Debug.LogWarning("(" + mainCanvas.name + ") couldn't find canvas group component.");
            Debug.Break();
        }
        isUIAnimationTransition = false;
    }

    public void setDisplayInfoText(string newText)
    {
        displayText.text = newText;
    }
    [ContextMenu("ShowUI")]
    public void show()
    {
        isUIAnimationTransition = true;
        StartCoroutine(showHideDisplayInfo(2));
    }

    [ContextMenu("HideUI")]
    public void hide()
    {
        isUIAnimationTransition = false;
        StartCoroutine(hideHideDisplayInfo(2));
    }

    private IEnumerator showHideDisplayInfo(float speed)
    {
        float t = 0;
        float currentAlphaValue = mainCanvasCanvasGroup.alpha;
        while (mainCanvasCanvasGroup.alpha < 1)
        {
            t += speed * Time.deltaTime;
            if (!isUIAnimationTransition) yield break;
            mainCanvasCanvasGroup.alpha = Mathf.Lerp(currentAlphaValue, 1, t);
            yield return null;
        }
        mainCanvasCanvasGroup.alpha = 1;
        t = 0;
    }

    private IEnumerator hideHideDisplayInfo(float speed)
    {
        float t = 0;
        float currentAlphaValue = mainCanvasCanvasGroup.alpha;
        while (mainCanvasCanvasGroup.alpha > 0)
        {
            t += speed * Time.deltaTime;
            if (isUIAnimationTransition) yield break;
            mainCanvasCanvasGroup.alpha = Mathf.Lerp(currentAlphaValue, 0, t);
            yield return null;
        }
        mainCanvasCanvasGroup.alpha = 0;
        t = 0;
    }
}
