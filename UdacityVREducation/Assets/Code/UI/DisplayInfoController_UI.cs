using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInfoController_UI : MonoBehaviour {

    public Transform mainCanvas;
    public Text displayText;

    private CanvasGroup mainCanvasCanvasGroup;
    private bool isUIAnimationTransition;

	private void Start () {
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
        showHideDisplayInfo(1);
    }

    [ContextMenu("HideUI")]
    public void hide()
    {
        showHideDisplayInfo(0);
    }

    public void showHideDisplayInfo( float action, float speed = 1f)
    {
        isUIAnimationTransition = false;
        StartCoroutine(DisplayInfoVisibility(speed, action));
    }

    private IEnumerator DisplayInfoVisibility(float speed, float action)
    {
        float t = 0;
        float currentAlphaValue = mainCanvasCanvasGroup.alpha;
        isUIAnimationTransition = true;
        while (mainCanvasCanvasGroup.alpha != action && isUIAnimationTransition)
        {
            t += speed * Time.deltaTime;
            mainCanvasCanvasGroup.alpha = Mathf.Lerp(currentAlphaValue, action, t);
            yield return null;
        }
        isUIAnimationTransition = false;
    }
}
